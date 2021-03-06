#pragma once

#include "stdafx.h"
#include "ConfigHelper.h"

namespace PokeReg
{
	enum RegRoot {
		HKCU = 0,
		HKCR,
		HKLM,
		HKCUS,
		HKLMS,
		HKCCS,
		Last_Do_Not_Use
	};

	static wchar_t* wszRegRoots[] = {
		L"HKCU",
		L"HKEY_Current_User",
		L"HKCR",
		L"HKEY_Classes_Root",
		L"HKLM",
		L"HKEY_Local_Machine",
		L"HKCUS",
		L"HKCUS",
		L"HKLMS",
		L"HKLMS",
		L"HKCCS",
		L"HKCCS"
	};

	class CPokeRegKey
	{
	private:
		RegRoot m_rrRoot;
		std::wstring m_wsPath, m_wsStringRepresentation;

		bool Test(ConfigHelper*, HKEY hParent, std::wstring& wsPath, bool& bIsKeyPresent);

	public:
		CPokeRegKey(std::wstring& line)
		{
		}

		CPokeRegKey(RegRoot root, std::wstring& path):m_rrRoot(root), m_wsPath(path)
		{
			m_wsStringRepresentation.clear();
		}

		~CPokeRegKey(void)
		{
			m_wsPath.clear();
			m_wsStringRepresentation.clear();
		}

		const wchar_t* ToString()
		{
			if(m_wsStringRepresentation.empty())
			{
				m_wsStringRepresentation = wszRegRoots[m_rrRoot];
				m_wsStringRepresentation.append(L"\\");
				m_wsStringRepresentation.append(m_wsPath);
			}
			return m_wsStringRepresentation.c_str();
		}

		bool TestProtection(ConfigHelper* config, bool bTestWowNode, bool& bIsKeyPresent);
	};
}