#pragma once

#define WIN32_LEAN_AND_MEAN
#include <windows.h>

#include "ErrorCode.h"

enum class RedisTaskID : UINT16
{
	INVALID = 0,

	REQUEST_LOGIN = 1001,
	RESPONSE_LOGIN = 1002,
};



struct RedisTask
{
	UINT32 UserIndex = 0;
	RedisTaskID TaskID = RedisTaskID::INVALID;
	UINT16 DataSize = 0;
	char* pData = nullptr;	

	void Release()
	{
		if (pData != nullptr)
		{
			delete[] pData;
		}
	}
};




#pragma pack(push,1)

struct RedisLoginReq
{
	char UserID[MAX_USER_ID_LEN + 1];
	char UserPW[MAX_USER_PW_LEN + 1];
};

struct RedisLoginRes
{
	UINT16 Result = (UINT16)ERROR_CODE::NONE;
};

#pragma pack(pop) //���� ������ ��ŷ������ �����