@echo off
@title 自动创建解决方案及各隶属项目

set basedir="%~dp0"
set basedir
cd /d %basedir%



@echo.
@echo.
@echo.
@echo\&echo  ---------- 解决方案 ----------
dotnet new sln -n CRS2TBBT4CeriumX.Framework



@echo.
@echo.
@echo.
@echo\&echo  ---------- 引导程序 & Bootloader 1 ----------
dotnet new classlib -lang "C#" -f net5.0 -n CeriumX.Framework.Bootloader -o CeriumX.Framework.Bootloader\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add --in-root CeriumX.Framework.Bootloader\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- 核心 & Core 5 ----------
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
@echo\&echo  ---------- 模块化 & Modularity 2 ----------
@echo\&echo  创建项目 CeriumX.Framework.Modularity.Abstractions 并添加到解决方案。
dotnet new classlib -lang C# -f net5.0 -n CeriumX.Framework.Modularity.Abstractions -o Modularity\CeriumX.Framework.Modularity.Abstractions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Modularity Modularity\CeriumX.Framework.Modularity.Abstractions\src

@echo\&echo  创建项目 CeriumX.Framework.Modularity 并添加到解决方案。
dotnet new classlib -lang C# -f net5.0 -n CeriumX.Framework.Modularity -o Modularity\CeriumX.Framework.Modularity\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Modularity Modularity\CeriumX.Framework.Modularity\src





::@echo\&echo 所有项目自动创建工作已结束，600 秒后将自动退出本自动创建程序。
::timeout /t 600

@echo.
@echo.
@echo.
@echo.
@echo.
@echo\&echo 自动创建所有项目完毕，请按任意键退出。
pause>nul 
exit