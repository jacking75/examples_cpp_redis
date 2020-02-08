#pragma once

#include <winsock2.h>
#include <Ws2tcpip.h>
#include <mswsock.h>

const UINT32 MAX_SOCK_RECVBUF = 256;	// ���� ������ ũ��
const UINT32 MAX_SOCK_SENDBUF = 4096;	// ���� ������ ũ��
const UINT64 RE_USE_SESSION_WAIT_TIMESEC = 3;


enum class IOOperation
{
	ACCEPT,
	RECV,
	SEND
};

//WSAOVERLAPPED����ü�� Ȯ�� ���Ѽ� �ʿ��� ������ �� �־���.
struct stOverlappedEx
{
	WSAOVERLAPPED m_wsaOverlapped;		//Overlapped I/O����ü
	WSABUF		m_wsaBuf;				//Overlapped I/O�۾� ����
	IOOperation m_eOperation;			//�۾� ���� ����
	UINT32 SessionIndex = 0;
};

