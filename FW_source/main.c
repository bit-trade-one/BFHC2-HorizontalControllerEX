// HorizontalControllerEX
//	ver 006		SW入力で変化時にしか送信していない不具合修正(Volumeは１回のみ出力)
//	ver 005		量産用
//	ver 004		CW,CCWの順番を入れ替え、デフォルト値設定
//	ver 003		量産基板用 LED追加
//	ver 002		試作2 PRODUCT ID 0x0041 -> 0x0042
//	ver 001		試作


/********************************************************************
 FileName:		main.c
 Dependencies:	See INCLUDES section
 Processor:		PIC18, PIC24, and PIC32 USB Microcontrollers
 Hardware:		This demo is natively intended to be used on Microchip USB demo
 				boards supported by the MCHPFSUSB stack.  See release notes for
 				support matrix.  This demo can be modified for use on other hardware
 				platforms.
 Complier:  	Microchip C18 (for PIC18), C30 (for PIC24), C32 (for PIC32)
 Company:		Microchip Technology, Inc.

 Software License Agreement:

 The software supplied herewith by Microchip Technology Incorporated
 (the 鼎ompany・ for its PICｮ Microcontroller is intended and
 supplied to you, the Company痴 customer, for use solely and
 exclusively on Microchip PIC Microcontroller products. The
 software is owned by the Company and/or its supplier, and is
 protected under applicable copyright laws. All rights are reserved.
 Any use in violation of the foregoing restrictions may subject the
 user to criminal sanctions under applicable laws, as well as to
 civil liability for the breach of the terms and conditions of this
 license.

 THIS SOFTWARE IS PROVIDED IN AN 鄭S IS・CONDITION. NO WARRANTIES,
 WHETHER EXPRESS, IMPLIED OR STATUTORY, INCLUDING, BUT NOT LIMITED
 TO, IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
 PARTICULAR PURPOSE APPLY TO THIS SOFTWARE. THE COMPANY SHALL NOT,
 IN ANY CIRCUMSTANCES, BE LIABLE FOR SPECIAL, INCIDENTAL OR
 CONSEQUENTIAL DAMAGES, FOR ANY REASON WHATSOEVER.

********************************************************************
********************************************************************/

#ifndef MAIN_C
#define MAIN_C

/** INCLUDES *******************************************************/
#include <p18f14k50.h>
#include <adc.h>
#include <string.h>
#include <timers.h>
#include <delays.h>
#include "./USB/usb.h"
#include "HardwareProfile.h"
#include "./USB/usb_function_hid.h"
#include "app.h"
#include "eeprom.h"
#include "eeprom_data.h"

/** CONFIGURATION **************************************************/
#pragma config CPUDIV = NOCLKDIV
#pragma config USBDIV = OFF
#pragma config FOSC   = HS
#pragma config PLLEN  = ON
#pragma config FCMEN  = OFF
#pragma config IESO   = OFF
#pragma config PWRTEN = OFF
#pragma config BOREN  = OFF
#pragma config BORV   = 30
#pragma config WDTEN  = OFF
#pragma config WDTPS  = 32768
#pragma config MCLRE  = OFF
#pragma config HFOFST = OFF
#pragma config STVREN = ON
#pragma config LVP    = OFF
#pragma config XINST  = OFF
#pragma config BBSIZ  = OFF
#pragma config CP0    = OFF
#pragma config CP1    = OFF
#pragma config CPB    = OFF
#pragma config WRT0   = OFF
#pragma config WRT1   = OFF
#pragma config WRTB   = OFF
#pragma config WRTC   = OFF
#pragma config EBTR0  = OFF
#pragma config EBTR1  = OFF
#pragma config EBTRB  = OFF


/** PRIVATE PROTOTYPES *********************************************/
static void InitializeSystem(void);
void ProcessIO(void);
void UserInit(void);
void YourHighPriorityISRCode();
void YourLowPriorityISRCode();
void Switch_Input(void);
void Mode_Set(BYTE p_ini_flag);

/** DECLARATIONS ***************************************************/


#define SW_NUM					4		// SW入力数
#define	SW_ENCORDER_A			PORTBbits.RB4
#define	SW_ENCORDER_B			PORTBbits.RB5
#define SW_SWA					PORTCbits.RC5
#define SW_SWB					PORTCbits.RC4
#define	SW_ENCORDER_A_IDX		0
#define	SW_ENCORDER_B_IDX		1
#define	SW_SATRT_IDX			2
#define	SW_SWB_IDX				2
#define	SW_SWA_IDX				3
#define SW_ON_DEFAULT_COUNT		10		// SW ON判定回数
#define	SW_OFF_DEFAULT_COUNT	10		// SW OFF判定回数


#define N_ON    1		// normal ON
#define N_OFF   0		// normal OFF
#define R_ON    0		// reverse ON
#define R_OFF   1		// reverse OFF

#define MOVE_OFF	0
#define MOVE_ON		1

#define	ENCORDER_A_EEPROM_IDX		0
#define	ENCORDER_B_EEPROM_IDX		1
#define	SW1_EEPROM_IDX				2
#define	SW2_EEPROM_IDX				3

unsigned char eeprom_data[SET_DATA_NUM][SET_DATA_LEN] = {0};
#define EEPROM_SAVE_NUM		5
#define EEPROM_SAME_COUNT	3


#if 1 // 0.1ms
#define LED1_ON()	LATCbits.LATC1=1
#define LED1_OFF()	LATCbits.LATC1=0
#define LED2_ON()	LATCbits.LATC2=1
#define LED2_OFF()	LATCbits.LATC2=0
#define LED_DUTY_CYCLE	100
#define LED_NORMAL_DUTY	20
#define LED_CHANGE_DUTY	100
BYTE led_duty_counter = 0;
#define LED_CHANGE_TIME	20000
WORD led_duty_up_timer_counter = 0;

#define LED_SW_ONOFF_NUM		9
BYTE led_updown_now_duty = 0;
BYTE led_updown_set_duty = 0;
BYTE led_updown_timer_counter = 0;
#endif



/* Timer0 1.0ms */
/* 1000us / ( 0.021us x 4 ) = 12000  48MHz = 1/48us = 0.021us */
/* 12000 / 1 = 12000    プリスケーラ=1*/
/* 0x10000 - 0x2EE0 = 0xD120    16bitカウンタ*/
#define WRITE_TIMER0_COUNT        0xD120        //Timer0の時間 
/* Timer1 0.1ms */
/* 100us / ( 0.021us x 4 ) = 1200  48MHz = 1/48us = 0.021us */
/* 6000 / 1 = 1200    プリスケーラ=1*/
/* 0x10000 - 0x04B0 = 0xFB50    16bitカウンタ*/
#define WRITE_TIMER1_COUNT        0xFB50        //Timer1の時間 
/* Timer1 0.5ms */
/* 500us / ( 0.021us x 4 ) = 6000  48MHz = 1/48us = 0.021us */
/* 6000 / 1 = 6000    プリスケーラ=1*/
/* 0x10000 - 0x1770 = 0xE890    16bitカウンタ*/
//#define WRITE_TIMER1_COUNT        0xE890        //Timer1の時間 


#define PIN1	PORTCbits.RC5
#define	PIN2	PORTCbits.RC4
#define	PIN3	PORTCbits.RC3
#define PIN4	PORTCbits.RC6
#define	PIN5	PORTCbits.RC7
#define	PIN6	PORTBbits.RB7
#define	PIN7	PORTBbits.RB6
#define	PIN8	PORTBbits.RB5
#define	PIN9	PORTBbits.RB4
#define	PIN10	PORTCbits.RC2
#define PIN11	PORTCbits.RC1
#define	PIN12	PORTCbits.RC0

//--------------------------------------------------
//受信ディレイ関数
//--------------------------------------------------
// 48MHz = 1命令 0.083us
// 1ms = 12,000命令 = Delay1KTCYx(12);
// 10ms = 120,000命令 = Delay10KTCYx(12);
// 100ms = 1,200,000命令 = Delay10KTCYx(120)
#define DELAY_1ms() Delay1KTCYx(12)
#define DELAY_5ms() Delay1KTCYx(60)
#define DELAY_10ms() Delay10KTCYx(12)
#define DELAY_50ms() Delay10KTCYx(60)
#define DELAY_100ms() Delay10KTCYx(120)

/** VARIABLES ******************************************************/
#pragma udata
char	c_version[]="0.0.6";
#define MOUSE_BUFFER_SIZE		4
#define VOLUME_BUFFER_SIZE		1
#define KEYBOARD_BUFFER_SIZE	8
BYTE mouse_buffer[MOUSE_BUFFER_SIZE];
BYTE volume_buffer[VOLUME_BUFFER_SIZE];
BYTE keyboard_buffer[KEYBOARD_BUFFER_SIZE]; 
USB_HANDLE lastTransmissionMouse;
USB_HANDLE lastTransmissionVolume;
USB_HANDLE lastINTransmissionKeyboard;
USB_HANDLE lastOUTTransmissionKeyboard;
USB_HANDLE USBOutHandle = 0;
USB_HANDLE USBInHandle = 0;


// SW入力
BYTE sw_now_fix[SW_NUM]={0};
BYTE sw_now_fix_pre[SW_NUM]={0};
BYTE sw_output_flag[SW_NUM]={0};
BYTE sw_output_volume_flag[SW_NUM]={0};	// Volumeは、変化時に１回のみ出力するための出力状態記憶用
BYTE sw_press_on_cnt[SW_NUM]={0};
BYTE sw_press_off_cnt[SW_NUM]={0};

// Mode
#define MODE_SW					PORTCbits.RC7
#define MODE_NUM	2
#define MODE_A	0
#define MODE_B	1
BYTE mode_sw_fix = MODE_A;
BYTE mode_sw_fix_pre = MODE_A;
BYTE mode_sw_on_cnt = 0;
BYTE mode_sw_off_cnt = 0;
#define MODE_SW_ON_DEFAULT_COUNT	20		// MODE SW ON判定回数
#define	MODE_SW_OFF_DEFAULT_COUNT	20		// MODE SW OFF判定回数

BYTE set_eeprom_idx = 0;

#define MOUSE_DOUBLE_CLICK_STATUS_NONE		0x00
#define MOUSE_DOUBLE_CLICK_STATUS_CLICK1	0x01
#define MOUSE_DOUBLE_CLICK_STATUS_INTERVAL	0x02
#define MOUSE_DOUBLE_CLICK_STATUS_CLICK2	0x04
BYTE mouse_w_click_status = MOUSE_DOUBLE_CLICK_STATUS_NONE;
WORD mouse_w_click_interval_counter = 0;


//エンコーダ処理用
BYTE state_re = 0;
BYTE pre_state_re = 0;
BYTE rotate_state = 0;
#define	ENCORDER_A	PORTBbits.RB4
#define	ENCORDER_B	PORTBbits.RB5
#define MOVE_OFF	0
#define MOVE_ON		1
WORD temp_input_sense_left = 0;
WORD temp_input_sense_right = 0;


// キーボード 出力キーオーバーフロー対策
#define KEY_OUTPUT_OVER_BUFF_SIZE	0x08
BYTE key_output_over_buff[KEY_OUTPUT_OVER_BUFF_SIZE] = {0};
BYTE key_output_over_read_idx = 0;
BYTE key_output_over_write_idx = 0;
BYTE key_output_over_full = 0;


// ソフトリセット
#define SOFT_RESET_INTERVAL		100	// ソフトリセットコマンド受信間隔（この間隔以内でn回コマンドを受信しないとリセットしない）
#define SOFT_RESET_COMMAND_NUM	10	// ソフトリセットコマンドを、連続してこの回数受信したらソフトリセットを行う
BYTE soft_reset_cmd_counter = 0;
BYTE soft_reset_interval_counter = 0;



// DEBUG
BYTE debug_arr1[16]={0};
BYTE debug_arr2[16]={0};


// usbでの送信に使うバッファはここで宣言
#pragma udata usbram2

BYTE mouse_input[MOUSE_BUFFER_SIZE];
BYTE volume_input[VOLUME_BUFFER_SIZE];
BYTE keyboard_input[KEYBOARD_BUFFER_SIZE];
unsigned char volume_input_out_flag = 0;
unsigned char mouse_input_out_flag = 0;
unsigned char keyboard_input_out_flag = 0;
unsigned char ReceivedDataBuffer[64];
unsigned char ToSendDataBuffer[64];

#pragma udata

//EEPROM初期値
#if 1
// ModeA Encoder CW,CCW,SWB,SWA,
// ModeB Encoder CW,CCW,SWB,SWA,
rom BYTE eeprom_default[SET_DATA_NUM][SET_DATA_LEN] = 
{
	{SET_TYPE_MOUSE_MOVE,	0x00, 0x06, 0x00, 0x00, MASTER_INPUT_SENSE},
	{SET_TYPE_MOUSE_MOVE,	0x00, 0xFA, 0x00, 0x00, MASTER_INPUT_SENSE},
	{SET_TYPE_MOUSE_RCLICK,	0x02, 0x00, 0x00, 0x00, MASTER_INPUT_SENSE},
	{SET_TYPE_MOUSE_LCLICK,	0x01, 0x00, 0x00, 0x00, MASTER_INPUT_SENSE},
	{SET_TYPE_VOLUME_UP,	0x00, 0x00, 0x00, 0x00, MASTER_INPUT_SENSE},
	{SET_TYPE_VOLUME_DOWN,	0x00, 0x00, 0x00, 0x00, MASTER_INPUT_SENSE},
	{SET_TYPE_KEYBOARD_KEY,	0x00, 0x2C, 0x00, 0x00, MASTER_INPUT_SENSE},
	{SET_TYPE_VOLUME_MUTE,	0x00, 0x00, 0x00, 0x00, MASTER_INPUT_SENSE},
};
#endif
	
/** VECTOR REMAPPING ***********************************************/
#if defined(__18CXX)
	//On PIC18 devices, addresses 0x00, 0x08, and 0x18 are used for
	//the reset, high priority interrupt, and low priority interrupt
	//vectors.  However, the current Microchip USB bootloader 
	//examples are intended to occupy addresses 0x00-0x7FF or
	//0x00-0xFFF depending on which bootloader is used.  Therefore,
	//the bootloader code remaps these vectors to new locations
	//as indicated below.  This remapping is only necessary if you
	//wish to program the hex file generated from this project with
	//the USB bootloader.  If no bootloader is used, edit the
	//usb_config.h file and comment out the following defines:
	//#define PROGRAMMABLE_WITH_USB_HID_BOOTLOADER
	//#define PROGRAMMABLE_WITH_USB_LEGACY_CUSTOM_CLASS_BOOTLOADER
	
	#if defined(PROGRAMMABLE_WITH_USB_HID_BOOTLOADER)
		#define REMAPPED_RESET_VECTOR_ADDRESS			0x1000
		#define REMAPPED_HIGH_INTERRUPT_VECTOR_ADDRESS	0x1008
		#define REMAPPED_LOW_INTERRUPT_VECTOR_ADDRESS	0x1018
	#elif defined(PROGRAMMABLE_WITH_USB_MCHPUSB_BOOTLOADER)	
		#define REMAPPED_RESET_VECTOR_ADDRESS			0x800
		#define REMAPPED_HIGH_INTERRUPT_VECTOR_ADDRESS	0x808
		#define REMAPPED_LOW_INTERRUPT_VECTOR_ADDRESS	0x818
	#else	
		#define REMAPPED_RESET_VECTOR_ADDRESS			0x00
		#define REMAPPED_HIGH_INTERRUPT_VECTOR_ADDRESS	0x08
		#define REMAPPED_LOW_INTERRUPT_VECTOR_ADDRESS	0x18
	#endif
	
	#if defined(PROGRAMMABLE_WITH_USB_HID_BOOTLOADER)||defined(PROGRAMMABLE_WITH_USB_MCHPUSB_BOOTLOADER)
	extern void _startup (void);        // See c018i.c in your C18 compiler dir
	#pragma code REMAPPED_RESET_VECTOR = REMAPPED_RESET_VECTOR_ADDRESS
	void _reset (void)
	{
	    _asm goto _startup _endasm
	}
	#endif
	#pragma code REMAPPED_HIGH_INTERRUPT_VECTOR = REMAPPED_HIGH_INTERRUPT_VECTOR_ADDRESS
	void Remapped_High_ISR (void)
	{
	     _asm goto YourHighPriorityISRCode _endasm
	}
	#pragma code REMAPPED_LOW_INTERRUPT_VECTOR = REMAPPED_LOW_INTERRUPT_VECTOR_ADDRESS
	void Remapped_Low_ISR (void)
	{
	     _asm goto YourLowPriorityISRCode _endasm
	}
	
	#if defined(PROGRAMMABLE_WITH_USB_HID_BOOTLOADER)||defined(PROGRAMMABLE_WITH_USB_MCHPUSB_BOOTLOADER)
	//Note: If this project is built while one of the bootloaders has
	//been defined, but then the output hex file is not programmed with
	//the bootloader, addresses 0x08 and 0x18 would end up programmed with 0xFFFF.
	//As a result, if an actual interrupt was enabled and occured, the PC would jump
	//to 0x08 (or 0x18) and would begin executing "0xFFFF" (unprogrammed space).  This
	//executes as nop instructions, but the PC would eventually reach the REMAPPED_RESET_VECTOR_ADDRESS
	//(0x1000 or 0x800, depending upon bootloader), and would execute the "goto _startup".  This
	//would effective reset the application.
	
	//To fix this situation, we should always deliberately place a 
	//"goto REMAPPED_HIGH_INTERRUPT_VECTOR_ADDRESS" at address 0x08, and a
	//"goto REMAPPED_LOW_INTERRUPT_VECTOR_ADDRESS" at address 0x18.  When the output
	//hex file of this project is programmed with the bootloader, these sections do not
	//get bootloaded (as they overlap the bootloader space).  If the output hex file is not
	//programmed using the bootloader, then the below goto instructions do get programmed,
	//and the hex file still works like normal.  The below section is only required to fix this
	//scenario.
	#pragma code HIGH_INTERRUPT_VECTOR = 0x08
	void High_ISR (void)
	{
	     _asm goto REMAPPED_HIGH_INTERRUPT_VECTOR_ADDRESS _endasm
	}
	#pragma code LOW_INTERRUPT_VECTOR = 0x18
	void Low_ISR (void)
	{
	     _asm goto REMAPPED_LOW_INTERRUPT_VECTOR_ADDRESS _endasm
	}
	#endif	//end of "#if defined(PROGRAMMABLE_WITH_USB_HID_BOOTLOADER)||defined(PROGRAMMABLE_WITH_USB_LEGACY_CUSTOM_CLASS_BOOTLOADER)"

	#pragma code
	
	
	//These are your actual interrupt handling routines.
	#pragma interrupt YourHighPriorityISRCode
	void YourHighPriorityISRCode()
	{
		//Check which interrupt flag caused the interrupt.
		//Service the interrupt
		//Clear the interrupt flag
		//Etc.
        #if defined(USB_INTERRUPT)
	        USBDeviceTasks();
        #endif
	
	}	//This return will be a "retfie fast", since this is in a #pragma interrupt section 
	#pragma interruptlow YourLowPriorityISRCode
	void YourLowPriorityISRCode()
	{
		BYTE tmp_led_on_flag = 0;
		//Check which interrupt flag caused the interrupt.
		//Service the interrupt
		//Clear the interrupt flag
		//Etc.
		if(INTCONbits.TMR0IF == 1)
		{
			INTCONbits.TMR0IF = 0;
			WriteTimer0(WRITE_TIMER0_COUNT);

			// SW Input
			Switch_Input();

			// Mose Set
			Mode_Set(0);
			
			// マウスダブルクリック間隔
			if(mouse_w_click_interval_counter > 0)
			{
				mouse_w_click_interval_counter--;
			}

			// Soft Reset
			if( soft_reset_interval_counter > 0)
			{
				soft_reset_interval_counter--;
			}
			else
			{
				soft_reset_cmd_counter = 0;
			}

debug_arr1[1]++;
		}
		
		if(PIR1bits.TMR1IF == 1)
		{	// Timer 1
			PIR1bits.TMR1IF = 0;
			WriteTimer1(WRITE_TIMER1_COUNT);


#if 1
			// LED点灯制御
			// A:LED2, B:LED1
			if(led_duty_counter == 0)
			{
				led_duty_counter = LED_DUTY_CYCLE;
			}
			if(led_duty_up_timer_counter > 0)
			{	// 点灯Duty Up
				led_duty_up_timer_counter--;
				if(led_duty_counter <= LED_CHANGE_DUTY)
				{	// 点灯
					tmp_led_on_flag = 1;
				}
				if(led_duty_up_timer_counter == 0)
				{
					led_updown_set_duty = LED_CHANGE_DUTY;
					led_updown_timer_counter = 100;
				}	
			}
			else if(led_updown_set_duty > 0)
			{
				if(led_updown_timer_counter > 0)
				{
					led_updown_timer_counter--;
					
					if(led_duty_counter <= led_updown_set_duty)
					{	// 点灯
						tmp_led_on_flag = 1;
					}
					
					if(led_updown_timer_counter == 0)
					{
						led_updown_set_duty--;
						if(led_updown_set_duty < LED_NORMAL_DUTY)
						{
							led_updown_set_duty = 0;
						}	
					}
				}
				else
				{
					led_updown_timer_counter = 100;
				}
			}	
			else
			{	// 通常点灯
				if(led_duty_counter <= LED_NORMAL_DUTY)
				{	// 点灯
					tmp_led_on_flag = 1;
				}
			}
			if(tmp_led_on_flag == 1)
			{
				if(mode_sw_fix == MODE_A)
				{
					LED1_ON();
					LED2_OFF();
				}
				else if(mode_sw_fix == MODE_B)
				{
					LED1_OFF();
					LED2_ON();
				}
				else
				{
					LED1_OFF();
					LED2_OFF();
				}
			}
			else
			{
				LED1_OFF();
				LED2_OFF();
			}
			led_duty_counter--;
#endif
		}
	
	}	//This return will be a "retfie", since this is in a #pragma interruptlow section 
#endif

#pragma code

/********************************************************************
 * Function:        void main(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        Main program entry point.
 *
 * Note:            None
 *******************************************************************/
void main(void)
{   
    InitializeSystem();

    #if defined(USB_INTERRUPT)
        USBDeviceAttach();
    #endif

    while(1)
    {
        #if defined(USB_POLLING)
		// Check bus status and service USB interrupts.
        USBDeviceTasks(); // Interrupt or polling method.  If using polling, must call
        				  // this function periodically.  This function will take care
        				  // of processing and responding to SETUP transactions 
        				  // (such as during the enumeration process when you first
        				  // plug in).  USB hosts require that USB devices should accept
        				  // and process SETUP packets in a timely fashion.  Therefore,
        				  // when using polling, this function should be called 
        				  // frequently (such as once about every 100 microseconds) at any
        				  // time that a SETUP packet might reasonably be expected to
        				  // be sent by the host to your device.  In most cases, the
        				  // USBDeviceTasks() function does not take very long to
        				  // execute (~50 instruction cycles) before it returns.
        #endif
    				  

		// Application-specific tasks.
		// Application related code may be added here, or in the ProcessIO() function.
        ProcessIO();
    }//end while
}//end main


/********************************************************************
 * Function:        static void InitializeSystem(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        InitializeSystem is a centralize initialization
 *                  routine. All required USB initialization routines
 *                  are called from here.
 *
 *                  User application initialization routine should
 *                  also be called from here.                  
 *
 * Note:            None
 *******************************************************************/
static void InitializeSystem(void)
{
    ADCON1 |= 0x0F;                 // Default all pins to digital

//	The USB specifications require that USB peripheral devices must never source
//	current onto the Vbus pin.  Additionally, USB peripherals should not source
//	current on D+ or D- when the host/hub is not actively powering the Vbus line.
//	When designing a self powered (as opposed to bus powered) USB peripheral
//	device, the firmware should make sure not to turn on the USB module and D+
//	or D- pull up resistor unless Vbus is actively powered.  Therefore, the
//	firmware needs some means to detect when Vbus is being powered by the host.
//	A 5V tolerant I/O pin can be connected to Vbus (through a resistor), and
// 	can be used to detect when Vbus is high (host actively powering), or low
//	(host is shut down or otherwise not supplying power).  The USB firmware
// 	can then periodically poll this I/O pin to know when it is okay to turn on
//	the USB module/D+/D- pull up resistor.  When designing a purely bus powered
//	peripheral device, it is not possible to source current on D+ or D- when the
//	host is not actively providing power on Vbus. Therefore, implementing this
//	bus sense feature is optional.  This firmware can be made to use this bus
//	sense feature by making sure "USE_USB_BUS_SENSE_IO" has been defined in the
//	HardwareProfile.h file.    
    #if defined(USE_USB_BUS_SENSE_IO)
    tris_usb_bus_sense = INPUT_PIN; // See HardwareProfile.h
    #endif
    
//	If the host PC sends a GetStatus (device) request, the firmware must respond
//	and let the host know if the USB peripheral device is currently bus powered
//	or self powered.  See chapter 9 in the official USB specifications for details
//	regarding this request.  If the peripheral device is capable of being both
//	self and bus powered, it should not return a hard coded value for this request.
//	Instead, firmware should check if it is currently self or bus powered, and
//	respond accordingly.  If the hardware has been configured like demonstrated
//	on the PICDEM FS USB Demo Board, an I/O pin can be polled to determine the
//	currently selected power source.  On the PICDEM FS USB Demo Board, "RA2" 
//	is used for	this purpose.  If using this feature, make sure "USE_SELF_POWER_SENSE_IO"
//	has been defined in HardwareProfile.h, and that an appropriate I/O pin has been mapped
//	to it in HardwareProfile.h.
    #if defined(USE_SELF_POWER_SENSE_IO)
    tris_self_power = INPUT_PIN;	// See HardwareProfile.h
    #endif
    
    UserInit();

    USBDeviceInit();	//usb_device.c.  Initializes USB module SFRs and firmware
    					//variables to known states.
}//end InitializeSystem



/******************************************************************************
 * Function:        void UserInit(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        This routine should take care of all of the demo code
 *                  initialization that is required.
 *
 * Note:            
 *
 *****************************************************************************/
void UserInit(void)
{
	BYTE fi,fj;
	unsigned char uc_temp;
	BYTE ng_count = 0;

	TRISB = 0xF0;	//RB4,5,6,7を入力
	TRISC = 0xD0;	//RC4,5,7を入力

	LATC = 0xff;

	ANSEL = 0x00;
	ANSELH = 0x00;	//全てデジタル

	INTCON2bits.RABPU = 1;	//内蔵プルアップ無効
//	INTCON2bits.RABPU = 0;	//内蔵プルアップを使えるようにする
//	WPUBbits.WPUB4 = 1;
//	WPUBbits.WPUB5 = 1;
//	WPUBbits.WPUB6 = 1;
//	WPUBbits.WPUB7 = 1;

	LED1_OFF();
	LED2_OFF();

    //initialize the variable holding the handle for the last
    // transmission
    lastTransmissionMouse = 0;
    lastTransmissionVolume = 0;
    lastINTransmissionKeyboard = 0;
    lastOUTTransmissionKeyboard = 0;
    USBOutHandle = 0;
    USBInHandle = 0;

//	for(fi = 0; fi < VOLUME_BUFFER_SIZE; fi++)
//	{
//		volume_input[fi] = 0;
//		volume_buffer[fi] = 0;
//	}
	volume_input[0] = 0;
	volume_buffer[0] = 0;
	for(fi = 0; fi < MOUSE_BUFFER_SIZE; fi++)
	{
		mouse_input[fi] = 0;
		mouse_buffer[fi] = 0;
	}
	for(fi = 0; fi < KEYBOARD_BUFFER_SIZE; fi++)
	{
		keyboard_input[fi] = 0;
		keyboard_buffer[fi] = 0;
	}

//EEPROMのボタン設定値を読み込み
	for(fi = 0;fi < SET_DATA_NUM; fi++)
	{
		for(fj = 0;fj < SET_DATA_LEN;fj++)
		{
			uc_temp = ReadEEPROM_Agree(EEPROM_SAVE_NUM*(fi*SET_DATA_LEN+fj), EEPROM_SAVE_NUM, EEPROM_SAME_COUNT, &eeprom_data[fi][fj]);
		}
	}
		
#if 1
	if(0x5A == eeprom_data[0][0])
	{//初期化されていたら、全部0デフォルト値を設定する
		for(fi = 0;fi < SET_DATA_NUM; fi++)
		{
			for(fj = 0;fj < SET_DATA_LEN;fj++)
			{
				eeprom_data[fi][fj] = eeprom_default[fi][fj];
				uc_temp = (BYTE)EEPROM_SAVE_NUM*(((BYTE)fi*(BYTE)SET_DATA_LEN)+(BYTE)fj);
				uc_temp = WriteEEPROM_Agree(uc_temp, eeprom_data[fi][fj], EEPROM_SAVE_NUM);
			}
		}
	}
	else
	{
		// 不正な設定タイプなら、デフォルト値に設定
		for(fi = 0;fi < SET_DATA_NUM; fi++)
		{
			if(SET_TYPE_VAL_MIN > eeprom_data[fi][0] || eeprom_data[fi][0] > SET_TYPE_VAL_MAX)
			{
				ng_count++;
				for(fj = 0;fj < SET_DATA_LEN;fj++)
				{
					eeprom_data[fi][fj] = eeprom_default[fi][fj];
					uc_temp = (BYTE)EEPROM_SAVE_NUM*(((BYTE)fi*(BYTE)SET_DATA_LEN)+(BYTE)fj);
					uc_temp = WriteEEPROM_Agree(uc_temp, eeprom_data[fi][fj], EEPROM_SAVE_NUM);
				}
			}
		}
//		if(ng_count > 0)
		if(ng_count == SET_DATA_NUM)
		{
			// 不正な値の場合は初期化要求をセット
			uc_temp = WriteEEPROM_Agree(0, 0x5A, EEPROM_SAVE_NUM);
		}	
	}
#endif

	
	// スイッチ初期値取得
	for(fi = 0; fi < SW_ON_DEFAULT_COUNT; fi++)
	{
		Switch_Input();
	}

	// Mode Set初期値セット
	for(fi = 0; fi < MODE_SW_ON_DEFAULT_COUNT; fi++)
	{
		Mode_Set(1);
	}

//	タイマ0の設定
	OpenTimer0(TIMER_INT_ON & T0_16BIT & T0_SOURCE_INT & T0_PS_1_1);
	WriteTimer0(WRITE_TIMER0_COUNT);
//	タイマ1の設定
	OpenTimer1(TIMER_INT_ON & T1_16BIT_RW & T1_SOURCE_INT & T1_OSC1EN_OFF & T1_SYNC_EXT_OFF & T1_PS_1_1);
	WriteTimer1(WRITE_TIMER1_COUNT);

//	割り込み開始
	RCONbits.IPEN = 1;	//割り込み優先付あり
	INTCON2bits.TMR0IP = 0;	//タイマ0を低位レベル割り込みに設定
	INTCONbits.TMR0IE = 1;	//タイマ0割り込み許可
	IPR1bits.TMR1IP = 0;	//タイマ1を低位レベル割り込みに設定
//	IPR1bits.TMR1IP = 1;	//タイマ1を高位レベル割り込みに設定
	PIE1bits.TMR1IE = 1;	//タイマ1割り込み許可
	INTCONbits.GIEL = 1;	//低位レベル割り込みの許可
//	INTCONbits.GIEH = 1;	//高位レベル割り込みの許可
	INTCONbits.GIE = 1;
	
	
}//end UserInit


/********************************************************************
 * Function:        void ProcessIO(void)
 *	
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        This function is a place holder for other user
 *                  routines. It is a mixture of both USB and
 *                  non-USB tasks.
 *
 * Note:            None
 *******************************************************************/
void ProcessIO(void)
{
	BYTE fi,fj;
	char tmp;
	BYTE uc_temp;
	BYTE set_eeprom_idx = 0;
	BYTE set_key_data_idx = EEPROM_DATA_MODIFIER;

debug_arr1[0]++;


//エンコーダの入力を受けてマウス入力する処理を追加
	state_re = ENCORDER_A + (ENCORDER_B << 1);
//ロータリエンコーダの処理
	tmp = 0;
	switch(pre_state_re)
	{
		case 0: tmp = (state_re == 0) ? 0 : (state_re == 1) ? 1 : (state_re == 2) ? -1 : 0; break;
		case 1: tmp = (state_re == 0) ? -1 : (state_re == 1) ? 0 : (state_re == 2) ? 0 : 1; break;
		case 2: tmp = (state_re == 0) ? 1 : (state_re == 1) ? 0 : (state_re == 2) ? 0 : -1; break;
		case 3: tmp = (state_re == 0) ? 0 : (state_re == 1) ? -1 : (state_re == 2) ? 1 : 0; break;
		default: break;
	}
	pre_state_re = state_re;
	
	if(tmp == -1)
	{
		temp_input_sense_left += eeprom_data[ENCORDER_A_EEPROM_IDX + (SW_NUM * mode_sw_fix)][EEPROM_DATA_SENSE];
		temp_input_sense_right = 0;
		rotate_state++;
		if(rotate_state == 200)
		{
			rotate_state = 0;
		}

	    if(temp_input_sense_left >= MASTER_INPUT_SENSE)
	    {
		    temp_input_sense_left -= MASTER_INPUT_SENSE;
			sw_output_flag[SW_ENCORDER_A_IDX] = N_ON;
	    }
	}
	else if(tmp == 1)
	{
		temp_input_sense_right += eeprom_data[ENCORDER_B_EEPROM_IDX + (SW_NUM * mode_sw_fix)][EEPROM_DATA_SENSE];
		temp_input_sense_left = 0;		
		if(rotate_state == 0)
		{
			rotate_state = 199;
		}
		else
		{
			rotate_state--;
		}

	    if(temp_input_sense_right >= MASTER_INPUT_SENSE)
	    {
		    temp_input_sense_right -= MASTER_INPUT_SENSE;
			sw_output_flag[SW_ENCORDER_B_IDX] = N_ON;
	    }
	}

	// 前周期にキー出力出来なかったキーがあった場合は、そのキーを先に出力する
	while(key_output_over_read_idx != key_output_over_write_idx || key_output_over_full == 1)
	{
		keyboard_buffer[set_key_data_idx++] = key_output_over_buff[key_output_over_read_idx++];
		
		key_output_over_read_idx &= (KEY_OUTPUT_OVER_BUFF_SIZE-1);
		key_output_over_full = 0;
		
		if(set_key_data_idx >= KEYBOARD_BUFFER_SIZE)
		{
			break;
		}
	}

	// SW ONチェック
	for( fi = 0; fi < SW_NUM; fi++ )
	{
		if(sw_output_flag[fi] == N_ON)
		{
			if(fi == SW_ENCORDER_A_IDX || fi == SW_ENCORDER_B_IDX)
			{
				sw_output_flag[fi] = N_OFF;
			}

			set_eeprom_idx = fi + (SW_NUM * mode_sw_fix);

			// データセット
			switch(eeprom_data[set_eeprom_idx][DEVICE_DATA_SET_TYPE_IDX])
			{
				case SET_TYPE_MOUSE_LCLICK:
					mouse_buffer[0] = MOUSE_DATA_LEFT_CLICK;
					mouse_input_out_flag = 5;
					break;
				case SET_TYPE_MOUSE_RCLICK:
					mouse_buffer[0] = MOUSE_DATA_RIGHT_CLICK;
					mouse_input_out_flag = 5;
					break;
				case SET_TYPE_MOUSE_WHCLICK:
					mouse_buffer[0] = MOUSE_DATA_WHEEL_CLICK;
					mouse_input_out_flag = 5;
					break;
				case SET_TYPE_MOUSE_DCLICK:
					mouse_buffer[0] = MOUSE_DATA_LEFT_CLICK;
					mouse_w_click_status = MOUSE_DOUBLE_CLICK_STATUS_CLICK1;
					mouse_input_out_flag = 5;
					break;
				case SET_TYPE_MOUSE_MOVE:
					mouse_buffer[1] = eeprom_data[set_eeprom_idx][DEVICE_DATA_X_MOVE_IDX];	// 左右
					mouse_buffer[2] = eeprom_data[set_eeprom_idx][DEVICE_DATA_Y_MOVE_IDX];	// 上下
					mouse_input_out_flag = 5;
					break;
				case SET_TYPE_MOUSE_WHSCROLL:
					mouse_buffer[3] = eeprom_data[set_eeprom_idx][DEVICE_DATA_WHEEL_IDX];	// スクロール
					mouse_input_out_flag = 5;
					break;
				case SET_TYPE_KEYBOARD_KEY:
					keyboard_buffer[0] = eeprom_data[set_eeprom_idx][DEVICE_DATA_MODIFIER_IDX];
					keyboard_buffer[1] = 0;
					if(eeprom_data[set_eeprom_idx][DEVICE_DATA_KEY1_IDX] != 0)
					{
						if(set_key_data_idx < KEYBOARD_BUFFER_SIZE)
						{
							keyboard_buffer[set_key_data_idx++] = eeprom_data[set_eeprom_idx][DEVICE_DATA_KEY1_IDX];
						}
						else if(key_output_over_full == 0)
						{
							key_output_over_buff[key_output_over_write_idx++] = eeprom_data[set_eeprom_idx][DEVICE_DATA_KEY1_IDX];
							key_output_over_write_idx &= (KEY_OUTPUT_OVER_BUFF_SIZE-1);
							if(key_output_over_read_idx == key_output_over_write_idx)
							{
								key_output_over_full = 1;
							}
						}
					}
					if(eeprom_data[set_eeprom_idx][DEVICE_DATA_KEY2_IDX] != 0)
					{
						if(set_key_data_idx < KEYBOARD_BUFFER_SIZE)
						{
							keyboard_buffer[set_key_data_idx++] = eeprom_data[set_eeprom_idx][DEVICE_DATA_KEY2_IDX];
						}
						else if(key_output_over_full == 0)
						{
							key_output_over_buff[key_output_over_write_idx++] = eeprom_data[set_eeprom_idx][DEVICE_DATA_KEY2_IDX];
							key_output_over_write_idx &= (KEY_OUTPUT_OVER_BUFF_SIZE-1);
							if(key_output_over_read_idx == key_output_over_write_idx)
							{
								key_output_over_full = 1;
							}
						}
					}
					if(eeprom_data[set_eeprom_idx][DEVICE_DATA_KEY3_IDX] != 0)
					{
						if(set_key_data_idx < KEYBOARD_BUFFER_SIZE)
						{
							keyboard_buffer[set_key_data_idx++] = eeprom_data[set_eeprom_idx][DEVICE_DATA_KEY3_IDX];
						}
						else if(key_output_over_full == 0)
						{
							key_output_over_buff[key_output_over_write_idx++] = eeprom_data[set_eeprom_idx][DEVICE_DATA_KEY3_IDX];
							key_output_over_write_idx &= (KEY_OUTPUT_OVER_BUFF_SIZE-1);
							if(key_output_over_read_idx == key_output_over_write_idx)
							{
								key_output_over_full = 1;
							}
						}
					}
					keyboard_input_out_flag = 5;
					break;
				case SET_TYPE_VOLUME_UP:
					if(sw_output_volume_flag[fi] == N_OFF)
					{
						volume_buffer[0] = VOLUME_DATA_UP;
						volume_input_out_flag = 5;
						sw_output_volume_flag[fi] = N_ON;
					}
					break;
				case SET_TYPE_VOLUME_DOWN:
					if(sw_output_volume_flag[fi] == N_OFF)
					{
						volume_buffer[0] = VOLUME_DATA_DOWN;
						volume_input_out_flag = 5;
						sw_output_volume_flag[fi] = N_ON;
					}
					break;
				case SET_TYPE_VOLUME_MUTE:
					if(sw_output_volume_flag[fi] == N_OFF)
					{
						volume_buffer[0] = VOLUME_DATA_MUTE;
						volume_input_out_flag = 5;
						sw_output_volume_flag[fi] = N_ON;
					}
					break;
				case SET_TYPE_NONE:
				default:
					break;
			}
		}
		else
		{
			sw_output_volume_flag[fi] = N_OFF;
		}	
	}	


    // User Application USB tasks
    if((USBDeviceState < CONFIGURED_STATE)||(USBSuspendControl==1)) return;


//---------------------------------------------------------------------
//	USBデータ送信部
    if(!HIDTxHandleBusy(lastTransmissionMouse))
    {
	    // ダブルクリックチェック
	    if(mouse_w_click_status != MOUSE_DOUBLE_CLICK_STATUS_NONE)
	    {
		    if(mouse_w_click_status == MOUSE_DOUBLE_CLICK_STATUS_CLICK1)
		    {
				mouse_buffer[0] = MOUSE_DATA_LEFT_CLICK;
				mouse_input_out_flag = 5;
				
				mouse_w_click_interval_counter = MOUSE_DOUBLE_CLICK_INTERVAL;
				mouse_w_click_status = MOUSE_DOUBLE_CLICK_STATUS_INTERVAL;
			}
			else if(mouse_w_click_status == MOUSE_DOUBLE_CLICK_STATUS_INTERVAL)
			{
				if(mouse_w_click_interval_counter == 0)
				{
					mouse_w_click_status = MOUSE_DOUBLE_CLICK_STATUS_CLICK2;
				}
			}
			else if(mouse_w_click_status == MOUSE_DOUBLE_CLICK_STATUS_CLICK2)
			{
				mouse_buffer[0] = MOUSE_DATA_LEFT_CLICK;
				mouse_input_out_flag = 5;
				mouse_w_click_status = MOUSE_DOUBLE_CLICK_STATUS_NONE;
			}	 
		}

        //マウスデータの送信
		for(fi = 0; fi < MOUSE_BUFFER_SIZE; fi++)
		{
        	mouse_input[fi] = mouse_buffer[fi];
			mouse_buffer[fi] =0;
		}

		if( mouse_input_out_flag > 0 )
		{
	        //Send the 8 byte packet over USB to the host.
	        lastTransmissionMouse = HIDTxPacket(HID_EP, (BYTE*)&mouse_input, MOUSE_BUFFER_SIZE);
	        mouse_input_out_flag--;
		}
    }
    if(!HIDTxHandleBusy(lastINTransmissionKeyboard))
    {	       	//Load the HID buffer
		for(fi = 0; fi < KEYBOARD_BUFFER_SIZE; fi++)
		{
        	keyboard_input[fi] = keyboard_buffer[fi];
			keyboard_buffer[fi] =0;
		}

		if( keyboard_input_out_flag > 0 )
		{
	    	//Send the 8 byte packet over USB to the host.
			lastINTransmissionKeyboard = HIDTxPacket(HID_EP3, (BYTE*)keyboard_input, KEYBOARD_BUFFER_SIZE);
			keyboard_input_out_flag--;
		}
	}
   if(!HIDTxHandleBusy(lastTransmissionVolume))
    {
        //
//		for(fi = 0; fi < VOLUME_BUFFER_SIZE; fi++)
//		{
//        	volume_input[fi] = volume_buffer[fi];
//			volume_buffer[fi] =0;
//		}
       	volume_input[0] = volume_buffer[0];
		volume_buffer[0] = 0;

		if( volume_input_out_flag > 0)
		{
        	lastTransmissionVolume = HIDTxPacket(HID_EP2, (BYTE*)&volume_input, VOLUME_BUFFER_SIZE);
        	volume_input_out_flag--;
		}
    }
    
//---------------------------------------------------------------------
//	USBデータ通信部
    if(!HIDRxHandleBusy(USBOutHandle))				//Check if data was received from the host.
    {
        switch(ReceivedDataBuffer[0])
        {
            case 0x55:	//ソフトリセットをかける
	            if(ReceivedDataBuffer[1] == 0x53
	            && ReceivedDataBuffer[2] == 0x4F
	            && ReceivedDataBuffer[3] == 0x46
	            && ReceivedDataBuffer[4] == 0x54
	            && ReceivedDataBuffer[5] == 0x52
	            && ReceivedDataBuffer[6] == 0x45
	            && ReceivedDataBuffer[7] == 0x53
	            && ReceivedDataBuffer[8] == 0x45
	            && ReceivedDataBuffer[9] == 0x54
	            && ReceivedDataBuffer[10] == 0x00
	            && ReceivedDataBuffer[11] == 0x5A
	            && ReceivedDataBuffer[12] == 0xFF
	            && ReceivedDataBuffer[13] == 0xA5
	            && ReceivedDataBuffer[14] == 0x00)
	            {
		            soft_reset_cmd_counter++;
		            soft_reset_interval_counter = SOFT_RESET_INTERVAL;
		            if(soft_reset_cmd_counter >= SOFT_RESET_COMMAND_NUM)
		            {
						UCONbits.SUSPND = 0;		//Disable USB module
						UCON = 0x00;				//Disable USB module
						for(fi = 0; fi < 0xFF; fi++)
						{
							WREG = 0xFF;
							while(WREG)
							{
								WREG--;
								_asm
								bra	0	//Equivalent to bra $+2, which takes half as much code as 2 nop instructions
								bra	0	//Equivalent to bra $+2, which takes half as much code as 2 nop instructions
								_endasm	
							}
						}
		            	Reset();
			        }
	            }
            	break;
            case 0x56: // V=0x56 Get Firmware version
                ToSendDataBuffer[0] = 0x56;				//Echo back to the host PC the command we are fulfilling in the first byte.  In this case, the Get Pushbutton State command.
				tmp = strlen(c_version);
				if( 0 < tmp && tmp <= (64-2) )
				{
					for( fi = 0; fi < tmp; fi++ )
					{
						ToSendDataBuffer[fi+1] = c_version[fi];
					}
					// 最後にNULL文字を設定
					ToSendDataBuffer[fi+1] = 0x00;
				}
				else
				{
					//バージョン文字列異常
					ToSendDataBuffer[1] = 0x00;
				}				
                if(!HIDTxHandleBusy(USBInHandle))
                {
                    USBInHandle = HIDTxPacket(HID_EP4,(BYTE*)&ToSendDataBuffer[0],64);
                }
                break;
#if 0
            case 0x80:  // EEPROM 一括データを設定
            	ToSendDataBuffer[0] = 0x80;
				for(fi = 0;fi < SET_DATA_NUM; fi++)
				{
					for(fj = 0;fj < SET_DATA_LEN;fj++)
					{
		            	eeprom_data[fi][fj] = ReceivedDataBuffer[fi*SET_DATA_LEN+fj+1];
						uc_temp = WriteEEPROM_Agree(EEPROM_SAVE_NUM*(fi*SET_DATA_LEN+fj), eeprom_data[fi][fj], EEPROM_SAVE_NUM);
//						WriteEEPROM(fi*3+fj,eeprom_data[fi][fj]);
					}
				}
				ToSendDataBuffer[1] = 0x00;	// ans
                if(!HIDTxHandleBusy(USBInHandle))
                {
                    USBInHandle = HIDTxPacket(HID_EP4,(BYTE*)&ToSendDataBuffer[0],64);
                }
                break;
#endif
#if 1
            case 0x80:  // EEPROM 指定データを設定
            	ToSendDataBuffer[0] = 0x80;
            	if(ReceivedDataBuffer[1] < SET_DATA_NUM
            		&& (ReceivedDataBuffer[1]+ReceivedDataBuffer[2]) <= SET_DATA_NUM
            		&& ReceivedDataBuffer[2] > 0)
            	{
					for(fi = 0;fi < ReceivedDataBuffer[2]; fi++)
					{
						for(fj = 0;fj < SET_DATA_LEN;fj++)
						{
		            		eeprom_data[ReceivedDataBuffer[1]+fi][fj] = ReceivedDataBuffer[fi*SET_DATA_LEN+fj+3];
							uc_temp = WriteEEPROM_Agree(EEPROM_SAVE_NUM*((ReceivedDataBuffer[1]+fi)*SET_DATA_LEN+fj), eeprom_data[ReceivedDataBuffer[1]+fi][fj], EEPROM_SAVE_NUM);
//							WriteEEPROM(fi*3+fj,eeprom_data[fi][fj]);
						}
					}
					ToSendDataBuffer[1] = 0x00;	// OK ans
	            }
	            else
	            {
					ToSendDataBuffer[1] = 0xFF;	// NG ans
		        }
                if(!HIDTxHandleBusy(USBInHandle))
                {
                    USBInHandle = HIDTxPacket(HID_EP4,(BYTE*)&ToSendDataBuffer[0],64);
                }
                break;
#endif
            case 0x81:  //ボタンの押下状態を返信
                ToSendDataBuffer[0] = 0x81;				//Echo back to the host PC the command we are fulfilling in the first byte.  In this case, the Get Pushbutton State command.
                for(fi = 0; fi < SW_NUM; fi++)
                {
	                ToSendDataBuffer[1+fi] = sw_now_fix[fi];
	            }
				ToSendDataBuffer[1+SW_NUM] = rotate_state;
	            
                if(!HIDTxHandleBusy(USBInHandle))
                {
                    USBInHandle = HIDTxPacket(HID_EP4,(BYTE*)&ToSendDataBuffer[0],64);
                }
                break;
            case 0x37:	//現在の設定状況を返信
          		ToSendDataBuffer[0] = 0x37;  	//Echo back to the host the command we are fulfilling in the first byte.  In this case, the Read POT (analog voltage) command.
				for(fi = 0;fi < SET_DATA_NUM; fi++)
				{
					for(fj = 0;fj < SET_DATA_LEN;fj++)
					{
						ToSendDataBuffer[fi*SET_DATA_LEN+fj+1] = eeprom_data[fi][fj];
					}
				}

                if(!HIDTxHandleBusy(USBInHandle))
      		        {
           	        USBInHandle = HIDTxPacket(HID_EP4,(BYTE*)&ToSendDataBuffer[0],64);
           	    }
                break;
#if 1	//DEBUG
            case 0x40:
                ToSendDataBuffer[0] = 0x40;				//Echo back to the host PC the command we are fulfilling in the first byte.  In this case, the Get Pushbutton State command.
                ToSendDataBuffer[1] = debug_arr1[0];
                ToSendDataBuffer[2] = debug_arr1[1];
                ToSendDataBuffer[3] = debug_arr1[2];
                ToSendDataBuffer[4] = debug_arr1[3];
                ToSendDataBuffer[5] = debug_arr1[4];
                ToSendDataBuffer[6] = debug_arr1[5];
                ToSendDataBuffer[7] = debug_arr1[6];
                ToSendDataBuffer[8] = debug_arr1[7];
                ToSendDataBuffer[9] = debug_arr1[8];
                ToSendDataBuffer[10] = debug_arr1[9];
                ToSendDataBuffer[11] = debug_arr1[10];
                ToSendDataBuffer[12] = debug_arr1[11];
                ToSendDataBuffer[13] = debug_arr1[12];
                ToSendDataBuffer[14] = debug_arr1[13];
                ToSendDataBuffer[15] = debug_arr1[14];
                ToSendDataBuffer[16] = debug_arr1[15];

                if(!HIDTxHandleBusy(USBInHandle))
                {
                    USBInHandle = HIDTxPacket(HID_EP4,(BYTE*)&ToSendDataBuffer[0],64);
                }
                break;
            case 0x41:
                ToSendDataBuffer[0] = 0x41;				//Echo back to the host PC the command we are fulfilling in the first byte.  In this case, the Get Pushbutton State command.
                ToSendDataBuffer[1] = debug_arr2[0];
                ToSendDataBuffer[2] = debug_arr2[1];
                ToSendDataBuffer[3] = debug_arr2[2];
                ToSendDataBuffer[4] = debug_arr2[3];
                ToSendDataBuffer[5] = debug_arr2[4];
                ToSendDataBuffer[6] = debug_arr2[5];
                ToSendDataBuffer[7] = debug_arr2[6];
                ToSendDataBuffer[8] = debug_arr2[7];
                ToSendDataBuffer[9] = debug_arr2[8];
                ToSendDataBuffer[10] = debug_arr2[9];
                ToSendDataBuffer[11] = debug_arr2[10];
                ToSendDataBuffer[12] = debug_arr2[11];
                ToSendDataBuffer[13] = debug_arr2[12];
                ToSendDataBuffer[14] = debug_arr2[13];
                ToSendDataBuffer[15] = debug_arr2[14];
                ToSendDataBuffer[16] = debug_arr2[15];
                for(fi = 0; fi < SW_NUM; fi++)
                {
	                ToSendDataBuffer[1+fi] = sw_now_fix[fi];
	            } 

                if(!HIDTxHandleBusy(USBInHandle))
                {
                    USBInHandle = HIDTxPacket(HID_EP4,(BYTE*)&ToSendDataBuffer[0],64);
                }
                break;
#if 0
            case 0x4E:  // EEPROM デフォルト設定要求
            	ToSendDataBuffer[0] = 0x4E;
            	
            	if(ReceivedDataBuffer[1] < MODE_NUM)
            	{	
					for(fi = 0;fi < SET_DATA_NUM; fi++)
					{
						if((ReceivedDataBuffer[1] * (SET_DATA_NUM / 2)) <= fi
							&& fi < ((ReceivedDataBuffer[1] * (SET_DATA_NUM / 2)) + (SET_DATA_NUM / 2)))
						{
							for(fj = 0;fj < SET_DATA_LEN;fj++)
							{
			            		eeprom_data[fi][fj] = eeprom_default[fi][fj];
								uc_temp = WriteEEPROM_Agree(EEPROM_SAVE_NUM*(fi*SET_DATA_LEN+fj), eeprom_data[fi][fj], EEPROM_SAVE_NUM);
							}
						}
					}
					ToSendDataBuffer[1] = 0x00;	// OK ans
	            }
	            else
	            {
					ToSendDataBuffer[1] = 0xFF;	// NG ans
		        }
		        
                if(!HIDTxHandleBusy(USBInHandle))
                {
                    USBInHandle = HIDTxPacket(HID_EP4,(BYTE*)&ToSendDataBuffer[0],64);
                }
                break;
#endif
            case 0x4F:	// EEPROM RESET要求
            	ToSendDataBuffer[0] = 0x4F;
            	
            	// 0番地を0x5Aに
                WriteEEPROM_Agree(0, 0x5A, EEPROM_SAVE_NUM);
                
                if(!HIDTxHandleBusy(USBInHandle))
                {
                    USBInHandle = HIDTxPacket(HID_EP4,(BYTE*)&ToSendDataBuffer[0],64);
                }
                break;
#endif	//DEBUG
        }
         //Re-arm the OUT endpoint for the next packet
        USBOutHandle = HIDRxPacket(HID_EP4,(BYTE*)&ReceivedDataBuffer,64);
    }
}


void Switch_Input(void)
{
    BYTE fi;
    BYTE sw_now[SW_NUM] = {0};
    
    sw_now[SW_ENCORDER_A_IDX] 	= SW_ENCORDER_A;
    sw_now[SW_ENCORDER_B_IDX] 	= SW_ENCORDER_B;
    sw_now[SW_SWB_IDX] 			= SW_SWB;
    sw_now[SW_SWA_IDX] 			= SW_SWA;

	// Swのみチェック
    for( fi = SW_SATRT_IDX; fi < SW_NUM; fi++ )
    {
        if(sw_now[fi] == R_ON)
        {
            sw_press_on_cnt[fi]++;
            if( sw_press_on_cnt[fi] >= SW_ON_DEFAULT_COUNT)
            {
                sw_press_off_cnt[fi] = 0;
                sw_now_fix[fi] = N_ON;
                sw_press_on_cnt[fi] = SW_ON_DEFAULT_COUNT;
            }
        }
        else
        {
            sw_press_off_cnt[fi]++;
            if(sw_press_off_cnt[fi] >= SW_OFF_DEFAULT_COUNT)
            {
                sw_press_on_cnt[fi] = 0;
                sw_now_fix[fi] = N_OFF;
                sw_press_off_cnt[fi] = SW_OFF_DEFAULT_COUNT;
            }
        }

        // SW Push時の処理追加
        if( sw_now_fix_pre[fi] == N_OFF && sw_now_fix[fi] == N_ON )
        {	// 前回=OFF  今回=ON

        }
        else if( sw_now_fix_pre[fi] == N_ON && sw_now_fix[fi] == N_OFF )
        {	// 前回=ON  今回=OFF

        }
        // SWの場合は、状態セット
        if(fi == SW_SWB_IDX || fi == SW_SWA_IDX)
        {
			sw_output_flag[fi] = sw_now_fix[fi];
	    }


        // 今回値保存
        sw_now_fix_pre[fi] = sw_now_fix[fi];
    }
}
void Mode_Set(BYTE p_ini_flag)
{
	if(MODE_SW == R_ON)
	{
	    mode_sw_on_cnt++;
	    if( mode_sw_on_cnt >= MODE_SW_ON_DEFAULT_COUNT)
	    {
	        mode_sw_off_cnt = 0;
	        mode_sw_fix = MODE_A;
	        mode_sw_on_cnt = MODE_SW_ON_DEFAULT_COUNT;
	    }
	}
	else
	{
	    mode_sw_off_cnt++;
	    if(mode_sw_off_cnt >= MODE_SW_OFF_DEFAULT_COUNT)
	    {
	        mode_sw_on_cnt = 0;
	        mode_sw_fix = MODE_B;
	        mode_sw_off_cnt = MODE_SW_OFF_DEFAULT_COUNT;
	    }
	}
	
	if(p_ini_flag == 0)
	{
		if(mode_sw_fix_pre == MODE_B &&  mode_sw_fix == MODE_A)
		{	// 前回Bで、今回A
			led_duty_up_timer_counter = LED_CHANGE_TIME;
		}
		else if(mode_sw_fix_pre == MODE_A &&  mode_sw_fix == MODE_B)
		{	// 前回Aで、今回B
			led_duty_up_timer_counter = LED_CHANGE_TIME;
		}
	}
	
	// 今回値保存
	mode_sw_fix_pre = mode_sw_fix;
}


// ******************************************************************************************************
// ************** USB Callback Functions ****************************************************************
// ******************************************************************************************************
// The USB firmware stack will call the callback functions USBCBxxx() in response to certain USB related
// events.  For example, if the host PC is powering down, it will stop sending out Start of Frame (SOF)
// packets to your device.  In response to this, all USB devices are supposed to decrease their power
// consumption from the USB Vbus to <2.5mA each.  The USB module detects this condition (which according
// to the USB specifications is 3+ms of no bus activity/SOF packets) and then calls the USBCBSuspend()
// function.  You should modify these callback functions to take appropriate actions for each of these
// conditions.  For example, in the USBCBSuspend(), you may wish to add code that will decrease power
// consumption from Vbus to <2.5mA (such as by clock switching, turning off LEDs, putting the
// microcontroller to sleep, etc.).  Then, in the USBCBWakeFromSuspend() function, you may then wish to
// add code that undoes the power saving things done in the USBCBSuspend() function.

// The USBCBSendResume() function is special, in that the USB stack will not automatically call this
// function.  This function is meant to be called from the application firmware instead.  See the
// additional comments near the function.

/******************************************************************************
 * Function:        void USBCBSuspend(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        Call back that is invoked when a USB suspend is detected
 *
 * Note:            None
 *****************************************************************************/
void USBCBSuspend(void)
{
	//Example power saving code.  Insert appropriate code here for the desired
	//application behavior.  If the microcontroller will be put to sleep, a
	//process similar to that shown below may be used:
	
	//ConfigureIOPinsForLowPower();
	//SaveStateOfAllInterruptEnableBits();
	//DisableAllInterruptEnableBits();
	//EnableOnlyTheInterruptsWhichWillBeUsedToWakeTheMicro();	//should enable at least USBActivityIF as a wake source
	//Sleep();
	//RestoreStateOfAllPreviouslySavedInterruptEnableBits();	//Preferrably, this should be done in the USBCBWakeFromSuspend() function instead.
	//RestoreIOPinsToNormal();									//Preferrably, this should be done in the USBCBWakeFromSuspend() function instead.

	//IMPORTANT NOTE: Do not clear the USBActivityIF (ACTVIF) bit here.  This bit is 
	//cleared inside the usb_device.c file.  Clearing USBActivityIF here will cause 
	//things to not work as intended.	
	

    #if defined(__C30__)
    #if 0
        U1EIR = 0xFFFF;
        U1IR = 0xFFFF;
        U1OTGIR = 0xFFFF;
        IFS5bits.USB1IF = 0;
        IEC5bits.USB1IE = 1;
        U1OTGIEbits.ACTVIE = 1;
        U1OTGIRbits.ACTVIF = 1;
        Sleep();
    #endif
    #endif
}


/******************************************************************************
 * Function:        void _USB1Interrupt(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        This function is called when the USB interrupt bit is set
 *					In this example the interrupt is only used when the device
 *					goes to sleep when it receives a USB suspend command
 *
 * Note:            None
 *****************************************************************************/
#if 0
void __attribute__ ((interrupt)) _USB1Interrupt(void)
{
    #if !defined(self_powered)
        if(U1OTGIRbits.ACTVIF)
        {       
            IEC5bits.USB1IE = 0;
            U1OTGIEbits.ACTVIE = 0;
            IFS5bits.USB1IF = 0;
        
            //USBClearInterruptFlag(USBActivityIFReg,USBActivityIFBitNum);
            USBClearInterruptFlag(USBIdleIFReg,USBIdleIFBitNum);
            //USBSuspendControl = 0;
        }
    #endif
}
#endif

/******************************************************************************
 * Function:        void USBCBWakeFromSuspend(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        The host may put USB peripheral devices in low power
 *					suspend mode (by "sending" 3+ms of idle).  Once in suspend
 *					mode, the host may wake the device back up by sending non-
 *					idle state signalling.
 *					
 *					This call back is invoked when a wakeup from USB suspend 
 *					is detected.
 *
 * Note:            None
 *****************************************************************************/
void USBCBWakeFromSuspend(void)
{
	// If clock switching or other power savings measures were taken when
	// executing the USBCBSuspend() function, now would be a good time to
	// switch back to normal full power run mode conditions.  The host allows
	// a few milliseconds of wakeup time, after which the device must be 
	// fully back to normal, and capable of receiving and processing USB
	// packets.  In order to do this, the USB module must receive proper
	// clocking (IE: 48MHz clock must be available to SIE for full speed USB
	// operation).
}

/********************************************************************
 * Function:        void USBCB_SOF_Handler(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        The USB host sends out a SOF packet to full-speed
 *                  devices every 1 ms. This interrupt may be useful
 *                  for isochronous pipes. End designers should
 *                  implement callback routine as necessary.
 *
 * Note:            None
 *******************************************************************/
void USBCB_SOF_Handler(void)
{
    // No need to clear UIRbits.SOFIF to 0 here.
    // Callback caller is already doing that.
}

/*******************************************************************
 * Function:        void USBCBErrorHandler(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        The purpose of this callback is mainly for
 *                  debugging during development. Check UEIR to see
 *                  which error causes the interrupt.
 *
 * Note:            None
 *******************************************************************/
void USBCBErrorHandler(void)
{
    // No need to clear UEIR to 0 here.
    // Callback caller is already doing that.

	// Typically, user firmware does not need to do anything special
	// if a USB error occurs.  For example, if the host sends an OUT
	// packet to your device, but the packet gets corrupted (ex:
	// because of a bad connection, or the user unplugs the
	// USB cable during the transmission) this will typically set
	// one or more USB error interrupt flags.  Nothing specific
	// needs to be done however, since the SIE will automatically
	// send a "NAK" packet to the host.  In response to this, the
	// host will normally retry to send the packet again, and no
	// data loss occurs.  The system will typically recover
	// automatically, without the need for application firmware
	// intervention.
	
	// Nevertheless, this callback function is provided, such as
	// for debugging purposes.
}


/*******************************************************************
 * Function:        void USBCBCheckOtherReq(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        When SETUP packets arrive from the host, some
 * 					firmware must process the request and respond
 *					appropriately to fulfill the request.  Some of
 *					the SETUP packets will be for standard
 *					USB "chapter 9" (as in, fulfilling chapter 9 of
 *					the official USB specifications) requests, while
 *					others may be specific to the USB device class
 *					that is being implemented.  For example, a HID
 *					class device needs to be able to respond to
 *					"GET REPORT" type of requests.  This
 *					is not a standard USB chapter 9 request, and 
 *					therefore not handled by usb_device.c.  Instead
 *					this request should be handled by class specific 
 *					firmware, such as that contained in usb_function_hid.c.
 *
 * Note:            None
 *******************************************************************/
void USBCBCheckOtherReq(void)
{
    USBCheckHIDRequest();
}//end


/*******************************************************************
 * Function:        void USBCBStdSetDscHandler(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        The USBCBStdSetDscHandler() callback function is
 *					called when a SETUP, bRequest: SET_DESCRIPTOR request
 *					arrives.  Typically SET_DESCRIPTOR requests are
 *					not used in most applications, and it is
 *					optional to support this type of request.
 *
 * Note:            None
 *******************************************************************/
void USBCBStdSetDscHandler(void)
{
    // Must claim session ownership if supporting this request
}//end


/*******************************************************************
 * Function:        void USBCBInitEP(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        This function is called when the device becomes
 *                  initialized, which occurs after the host sends a
 * 					SET_CONFIGURATION (wValue not = 0) request.  This 
 *					callback function should initialize the endpoints 
 *					for the device's usage according to the current 
 *					configuration.
 *
 * Note:            None
 *******************************************************************/
void USBCBInitEP(void)
{
    //enable the HID endpoint
    USBEnableEndpoint(HID_EP,USB_OUT_ENABLED|USB_IN_ENABLED|USB_HANDSHAKE_ENABLED|USB_DISALLOW_SETUP);
    USBEnableEndpoint(HID_EP2,USB_OUT_ENABLED|USB_IN_ENABLED|USB_HANDSHAKE_ENABLED|USB_DISALLOW_SETUP);
    USBEnableEndpoint(HID_EP3,USB_OUT_ENABLED|USB_IN_ENABLED|USB_HANDSHAKE_ENABLED|USB_DISALLOW_SETUP);
    USBEnableEndpoint(HID_EP4,USB_OUT_ENABLED|USB_IN_ENABLED|USB_HANDSHAKE_ENABLED|USB_DISALLOW_SETUP);
}

/********************************************************************
 * Function:        void USBCBSendResume(void)
 *
 * PreCondition:    None
 *
 * Input:           None
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        The USB specifications allow some types of USB
 * 					peripheral devices to wake up a host PC (such
 *					as if it is in a low power suspend to RAM state).
 *					This can be a very useful feature in some
 *					USB applications, such as an Infrared remote
 *					control	receiver.  If a user presses the "power"
 *					button on a remote control, it is nice that the
 *					IR receiver can detect this signalling, and then
 *					send a USB "command" to the PC to wake up.
 *					
 *					The USBCBSendResume() "callback" function is used
 *					to send this special USB signalling which wakes 
 *					up the PC.  This function may be called by
 *					application firmware to wake up the PC.  This
 *					function should only be called when:
 *					
 *					1.  The USB driver used on the host PC supports
 *						the remote wakeup capability.
 *					2.  The USB configuration descriptor indicates
 *						the device is remote wakeup capable in the
 *						bmAttributes field.
 *					3.  The USB host PC is currently sleeping,
 *						and has previously sent your device a SET 
 *						FEATURE setup packet which "armed" the
 *						remote wakeup capability.   
 *
 *					This callback should send a RESUME signal that
 *                  has the period of 1-15ms.
 *
 * Note:            Interrupt vs. Polling
 *                  -Primary clock
 *                  -Secondary clock ***** MAKE NOTES ABOUT THIS *******
 *                   > Can switch to primary first by calling USBCBWakeFromSuspend()
 
 *                  The modifiable section in this routine should be changed
 *                  to meet the application needs. Current implementation
 *                  temporary blocks other functions from executing for a
 *                  period of 1-13 ms depending on the core frequency.
 *
 *                  According to USB 2.0 specification section 7.1.7.7,
 *                  "The remote wakeup device must hold the resume signaling
 *                  for at lest 1 ms but for no more than 15 ms."
 *                  The idea here is to use a delay counter loop, using a
 *                  common value that would work over a wide range of core
 *                  frequencies.
 *                  That value selected is 1800. See table below:
 *                  ==========================================================
 *                  Core Freq(MHz)      MIP         RESUME Signal Period (ms)
 *                  ==========================================================
 *                      48              12          1.05
 *                       4              1           12.6
 *                  ==========================================================
 *                  * These timing could be incorrect when using code
 *                    optimization or extended instruction mode,
 *                    or when having other interrupts enabled.
 *                    Make sure to verify using the MPLAB SIM's Stopwatch
 *                    and verify the actual signal on an oscilloscope.
 *******************************************************************/
void USBCBSendResume(void)
{
    static WORD delay_count;
    
    USBResumeControl = 1;                // Start RESUME signaling
    
    delay_count = 1800U;                // Set RESUME line for 1-13 ms
    do
    {
        delay_count--;
    }while(delay_count);
    USBResumeControl = 0;
}


/*******************************************************************
 * Function:        BOOL USER_USB_CALLBACK_EVENT_HANDLER(
 *                        USB_EVENT event, void *pdata, WORD size)
 *
 * PreCondition:    None
 *
 * Input:           USB_EVENT event - the type of event
 *                  void *pdata - pointer to the event data
 *                  WORD size - size of the event data
 *
 * Output:          None
 *
 * Side Effects:    None
 *
 * Overview:        This function is called from the USB stack to
 *                  notify a user application that a USB event
 *                  occured.  This callback is in interrupt context
 *                  when the USB_INTERRUPT option is selected.
 *
 * Note:            None
 *******************************************************************/
BOOL USER_USB_CALLBACK_EVENT_HANDLER(USB_EVENT event, void *pdata, WORD size)
{
    switch(event)
    {
        case EVENT_CONFIGURED: 
            USBCBInitEP();
            break;
        case EVENT_SET_DESCRIPTOR:
            USBCBStdSetDscHandler();
            break;
        case EVENT_EP0_REQUEST:
            USBCBCheckOtherReq();
            break;
        case EVENT_SOF:
            USBCB_SOF_Handler();
            break;
        case EVENT_SUSPEND:
            USBCBSuspend();
            break;
        case EVENT_RESUME:
            USBCBWakeFromSuspend();
            break;
        case EVENT_BUS_ERROR:
            USBCBErrorHandler();
            break;
        case EVENT_TRANSFER:
            Nop();
            break;
        default:
            break;
    }      
    return TRUE; 
}

/** EOF main.c *************************************************/
#endif
