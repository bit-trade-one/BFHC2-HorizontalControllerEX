/*******************************************************************************
 CAN WiFi

  Company:


  File Name:
    app.h

  Summary:
    Application specific header file.

  Description:
    Application specific header file.
 *******************************************************************************/

#ifndef APP_H
#define	APP_H

#include <p18f14k50.h>
#include "./USB/usb.h"
#include "HardwareProfile.h"
#include "./USB/usb_function_hid.h"



#define SET_DATA_NUM				8			// �ݒ�f�[�^��
#define SET_DATA_LEN				6			// �ݒ�f�[�^��

#define SET_TYPE_VAL_MIN			0			// �ݒ�^�C�v�ŏ��l
#define SET_TYPE_VAL_MAX			10			// �ݒ�^�C�v�ő�l
#define SET_TYPE_NONE				0			// �ݒ�^�C�v�@�Ȃ�
#define SET_TYPE_MOUSE_LCLICK		1			// �ݒ�^�C�v�@�}�E�X�@���N���b�N
#define SET_TYPE_MOUSE_RCLICK		2			// �ݒ�^�C�v�@�}�E�X�@�E�N���b�N
#define SET_TYPE_MOUSE_WHCLICK		3			// �ݒ�^�C�v�@�}�E�X�@�z�C�[���N���b�N
#define SET_TYPE_MOUSE_DCLICK		4			// �ݒ�^�C�v�@�}�E�X�@W�N���b�N
#define SET_TYPE_MOUSE_MOVE			5			// �ݒ�^�C�v�@�}�E�X�@�㉺���E�ړ�
#define SET_TYPE_MOUSE_WHSCROLL		6			// �ݒ�^�C�v�@�}�E�X�@�z�C�[���X�N���[��
#define SET_TYPE_KEYBOARD_KEY		7			// �ݒ�^�C�v�@�L�[�{�[�h�@�L�[
#define SET_TYPE_VOLUME_UP			8			// �ݒ�^�C�v�@�{�����[���@�A�b�v
#define SET_TYPE_VOLUME_DOWN		9			// �ݒ�^�C�v�@�{�����[���@�_�E��
#define SET_TYPE_VOLUME_MUTE		10			// �ݒ�^�C�v�@�{�����[���@�~���[�g

#define DEVICE_DATA_SET_TYPE_IDX	0			// �f�o�C�X�ݒ�f�[�^ �ݒ�^�C�v�i�[�ʒu
#define DEVICE_DATA_CLICK_IDX		1			// �f�o�C�X�ݒ�f�[�^�@�}�E�X�f�[�^�@�N���b�N�f�[�^�i�[�ʒu
#define DEVICE_DATA_X_MOVE_IDX		2			// �f�o�C�X�ݒ�f�[�^�@�}�E�X�f�[�^�@X�ړ��ʊi�[�ʒu
#define DEVICE_DATA_Y_MOVE_IDX		3			// �f�o�C�X�ݒ�f�[�^�@�}�E�X�f�[�^�@Y�ړ��ʊi�[�ʒu
#define DEVICE_DATA_WHEEL_IDX		4			// �f�o�C�X�ݒ�f�[�^�@�}�E�X�f�[�^�@�z�C�[���X�N���[���ʊi�[�ʒu
#define DEVICE_DATA_MODIFIER_IDX	1			// �f�o�C�X�ݒ�f�[�^�@�L�[�{�[�h�f�[�^�@���f�B�t�@�C�f�[�^�i�[�ʒu
#define DEVICE_DATA_KEY1_IDX		2			// �f�o�C�X�ݒ�f�[�^�@�L�[�{�[�h�f�[�^�@�L�[�f�[�^1�i�[�ʒu
#define DEVICE_DATA_KEY2_IDX		3			// �f�o�C�X�ݒ�f�[�^�@�L�[�{�[�h�f�[�^�@�L�[�f�[�^2�i�[�ʒu
#define DEVICE_DATA_KEY3_IDX		4			// �f�o�C�X�ݒ�f�[�^�@�L�[�{�[�h�f�[�^�@�L�[�f�[�^3�i�[�ʒu
#define DEVICE_DATA_VOLUME_IDX		1			// �f�o�C�X�ݒ�f�[�^�@�{�����[���f�[�^�@�f�[�^�i�[�ʒu


#define	EEPROM_DATA_TYPE		0	//	0:�ݒ�^�C�v
#define	EEPROM_DATA_MODE		0	//	0:���[�h
#define	EEPROM_DATA_VALUE		1	//	1:�l
#define	EEPROM_DATA_MODIFIER	2	//	2:Modifier�i�L�[�{�[�h�p�j
#define EEPROM_DATA_SENSE		5	//	���[�^���G���R�[�_�̊��x����

#define MASTER_MOUSE_SPEED		50	//	Mouse�̈ړ����x�̒����l
#define MASTER_WHEEL_SPEED		1000


#define MOUSE_DATA_LEFT_CLICK		0x01		// �}�E�X�f�[�^�@���N���b�N
#define MOUSE_DATA_RIGHT_CLICK		0x02		// �}�E�X�f�[�^�@�E�N���b�N
#define MOUSE_DATA_WHEEL_CLICK		0x04		// �}�E�X�f�[�^�@�z�C�[���N���b�N
#define MOUSE_DOUBLE_CLICK_INTERVAL	100			// �}�E�X�_�u���N���b�N�̃N���b�N�Ԋu

#define VOLUME_DATA_UP				0x01		// �{�����[���f�[�^�@�A�b�v
#define VOLUME_DATA_DOWN			0x02		// �{�����[���f�[�^�@�_�E��
#define VOLUME_DATA_MUTE			0x04		// �{�����[���f�[�^�@�~���[�g

#define MASTER_INPUT_SENSE		100	//�G���R�[�_�̊��x����


#endif	/* APP_H */

