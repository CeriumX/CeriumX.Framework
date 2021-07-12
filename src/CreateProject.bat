@echo off
@title �Զ����������������������Ŀ

set basedir="%~dp0"
set basedir
cd /d %basedir%



@echo.
@echo.
@echo.
@echo\&echo  ---------- ������� ----------
dotnet new sln -n CRS2TBBT4CeriumX.Framework



@echo.
@echo.
@echo.
@echo\&echo  ---------- �������� & Bootloader 1 ----------
dotnet new classlib -lang "C#" -f net5.0 -n CeriumX.Framework.Bootloader -o CeriumX.Framework.Bootloader\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add --in-root CeriumX.Framework.Bootloader\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- ���� & Core 5 ----------
dotnet new classlib -lang C# -f net5.0 -n CeriumX.Framework.Core.Abstractions -o Core\CeriumX.Framework.Core.Abstractions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core.Abstractions\src

dotnet new classlib -lang C# -f net5.0 -n CeriumX.Framework.Core -o Core\CeriumX.Framework.Core\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core\src

dotnet new classlib -lang C# -f net5.0 -n CeriumX.Framework.Core.WebExtensions -o Core\CeriumX.Framework.Core.WebExtensions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core.WebExtensions\src

dotnet new classlib -lang C# -f net5.0 -n CeriumX.Framework.Core.WPFExtensions -o Core\CeriumX.Framework.Core.WPFExtensions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core.WPFExtensions\src

dotnet new classlib -lang C# -f net5.0 -n CeriumX.Framework.Core.WinFormExtensions -o Core\CeriumX.Framework.Core.WinFormExtensions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core.WinFormExtensions\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- ģ�黯 & Modularity 2 ----------
@echo\&echo  ������Ŀ CeriumX.Framework.Modularity.Abstractions ����ӵ����������
dotnet new classlib -lang C# -f net5.0 -n CeriumX.Framework.Modularity.Abstractions -o Modularity\CeriumX.Framework.Modularity.Abstractions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Modularity Modularity\CeriumX.Framework.Modularity.Abstractions\src

@echo\&echo  ������Ŀ CeriumX.Framework.Modularity ����ӵ����������
dotnet new classlib -lang C# -f net5.0 -n CeriumX.Framework.Modularity -o Modularity\CeriumX.Framework.Modularity\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Modularity Modularity\CeriumX.Framework.Modularity\src





::@echo\&echo ������Ŀ�Զ����������ѽ�����600 ����Զ��˳����Զ���������
::timeout /t 600

@echo.
@echo.
@echo.
@echo.
@echo.
@echo\&echo �Զ�����������Ŀ��ϣ��밴������˳���
pause>nul 
exit