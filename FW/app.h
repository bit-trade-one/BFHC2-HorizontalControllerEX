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



#define SET_DATA_NUM				8			// 設定データ数
#define SET_DATA_LEN				6			// 設定データ長

#define SET_TYPE_VAL_MIN			0			// 設定タイプ最小値
#define SET_TYPE_VAL_MAX			10			// 設定タイプ最大値
#define SET_TYPE_NONE				0			// 設定タイプ　なし
#define SET_TYPE_MOUSE_LCLICK		1			// 設定タイプ　マウス　左クリック
#define SET_TYPE_MOUSE_RCLICK		2			// 設定タイプ　マウス　右クリック
#define SET_TYPE_MOUSE_WHCLICK		3			// 設定タイプ　マウス　ホイールクリック
#define SET_TYPE_MOUSE_DCLICK		4			// 設定タイプ　マウス　Wクリック
#define SET_TYPE_MOUSE_MOVE			5			// 設定タイプ　マウス　上下左右移動
#define SET_TYPE_MOUSE_WHSCROLL		6			// 設定タイプ　マウス　ホイールスクロール
#define SET_TYPE_KEYBOARD_KEY		7			// 設定タイプ　キーボード　キー
#define SET_TYPE_VOLUME_UP			8			// 設定タイプ　ボリューム　アップ
#define SET_TYPE_VOLUME_DOWN		9			// 設定タイプ　ボリューム　ダウン
#define SET_TYPE_VOLUME_MUTE		10			// 設定タイプ　ボリューム　ミュート

#define DEVICE_DATA_SET_TYPE_IDX	0			// デバイス設定データ 設定タイプ格納位置
#define DEVICE_DATA_CLICK_IDX		1			// デバイス設定データ　マウスデータ　クリックデータ格納位置
#define DEVICE_DATA_X_MOVE_IDX		2			// デバイス設定データ　マウスデータ　X移動量格納位置
#define DEVICE_DATA_Y_MOVE_IDX		3			// デバイス設定データ　マウスデータ　Y移動量格納位置
#define DEVICE_DATA_WHEEL_IDX		4			// デバイス設定データ　マウスデータ　ホイールスクロール量格納位置
#define DEVICE_DATA_MODIFIER_IDX	1			// デバイス設定データ　キーボードデータ　モディファイデータ格納位置
#define DEVICE_DATA_KEY1_IDX		2			// デバイス設定データ　キーボードデータ　キーデータ1格納位置
#define DEVICE_DATA_KEY2_IDX		3			// デバイス設定データ　キーボードデータ　キーデータ2格納位置
#define DEVICE_DATA_KEY3_IDX		4			// デバイス設定データ　キーボードデータ　キーデータ3格納位置
#define DEVICE_DATA_VOLUME_IDX		1			// デバイス設定データ　ボリュームデータ　データ格納位置


#define	EEPROM_DATA_TYPE		0	//	0:設定タイプ
#define	EEPROM_DATA_MODE		0	//	0:モード
#define	EEPROM_DATA_VALUE		1	//	1:値
#define	EEPROM_DATA_MODIFIER	2	//	2:Modifier（キーボード用）
#define EEPROM_DATA_SENSE		5	//	ロータリエンコーダの感度調整

#define MASTER_MOUSE_SPEED		50	//	Mouseの移動速度の調整値
#define MASTER_WHEEL_SPEED		1000


#define MOUSE_DATA_LEFT_CLICK		0x01		// マウスデータ　左クリック
#define MOUSE_DATA_RIGHT_CLICK		0x02		// マウスデータ　右クリック
#define MOUSE_DATA_WHEEL_CLICK		0x04		// マウスデータ　ホイールクリック
#define MOUSE_DOUBLE_CLICK_INTERVAL	100			// マウスダブルクリックのクリック間隔

#define VOLUME_DATA_UP				0x01		// ボリュームデータ　アップ
#define VOLUME_DATA_DOWN			0x02		// ボリュームデータ　ダウン
#define VOLUME_DATA_MUTE			0x04		// ボリュームデータ　ミュート

#define MASTER_INPUT_SENSE		100	//エンコーダの感度調整


#endif	/* APP_H */

