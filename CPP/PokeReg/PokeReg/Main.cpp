#include "stdafx.h"
#include "PokeReg.h"
#include "PokeRegHelper.h"
#include "ConfigHelper.h"

int _tmain(int argc, _TCHAR* argv[])
{
#ifdef _DEBUG
	MessageBox(NULL,L"Attach",L"Attach",MB_OK);
#endif
	PokeReg::ConfigHelper* config = new PokeReg::ConfigHelper(argc, argv);
	if(config->IsInHelpMode())
	{
		PauseAndReturn(config, SUCCESS);
	}
	const std::wstring &wsFileName = config->GetInputFileName();
	LOGINFO(config, _T("FileName: %s."), wsFileName.c_str());
	int iTotalLines = 0;
	std::vector<PokeReg::CPokeRegKey> regList;
	if(PokeReg::PokeRegHelper::PopulateVectorFromFile(config, wsFileName, regList, iTotalLines))
	{
		LOGEROR(config, _T("Unable to populate array from file."));
		config->DisplayUsage();
		PauseAndReturn(config, -1);
	}
	LOGINFO(config, _T("Total %d valid entries"), regList.size());
	bool bIsWow64Machine;
	ReturnCodes rcWowCheckResult = PokeReg::ConfigHelper::IsWow64(bIsWow64Machine);
	if(SUCCESS != rcWowCheckResult)
	{
		LOGEROR(config, _T("Unable to determine if running as Wow64 process; Error: %d."), GetLastError());
		bIsWow64Machine = false;
	}
	int iTotal = 0, iProtected = 0, iNotProtected = 0, iNotPresent = 0;
	for(std::vector<PokeReg::CPokeRegKey>::iterator itr = regList.begin(); itr < regList.end(); itr++)
	{
		bool bIsKeyPresent = false;
		iTotal++;
		LOGINFO(config, _T("Poking registry key: %s."), itr->ToString());
		if(itr->TestProtection(config, bIsWow64Machine, bIsKeyPresent))
		{
			iProtected++;
			LOGINFO(config, _T("Protection is available."));
		}
		else if(bIsKeyPresent)
		{
			iNotProtected++;
			LOGEROR(config, _T("Protection is not available."));
		}
		else
		{
			iNotPresent++;
			LOGEROR(config, _T("Key is not available."));
		}
	}
	LOG(_T("iTotalLines = %d\niTotal = %d\niProtected = %d\niNotProtected = %d\niNotPresent = %d."), iTotalLines, iTotal, iProtected, iNotProtected, iNotPresent);
	PauseAndReturn(config, SUCCESS);
}