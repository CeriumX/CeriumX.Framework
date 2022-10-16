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
@echo\&echo  ---------- 示例程序 @ samples 0 ----------





@echo.
@echo.
@echo.
@echo\&echo  ---------- 引导程序 @ Bootstrapper 1 ----------

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Bootstrapper -o CeriumX.Framework.Bootstrapper/src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add --in-root CeriumX.Framework.Bootstrapper/src





@echo.
@echo.
@echo.
@echo\&echo  ---------- 框架抽象层 ﹫ Abstractions 1 ----------

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Abstractions -o CeriumX.Framework.Abstractions/src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add --in-root CeriumX.Framework.Abstractions/src



@echo.
@echo.
@echo.
@echo\&echo  ---------- 框架核心层 ﹫ Core 5 ----------

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Core -o Core\CeriumX.Framework.Core\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core\src

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Core.WebExtensions -o Core\CeriumX.Framework.Core.WebExtensions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core.WebExtensions\src

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Core.WPFExtensions -o Core\CeriumX.Framework.Core.WPFExtensions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core.WPFExtensions\src

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Core.WinFormExtensions -o Core\CeriumX.Framework.Core.WinFormExtensions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core.WinFormExtensions\src

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Core.SplashScreenExtensions -o Core\CeriumX.Framework.Core.SplashScreenExtensions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Core Core\CeriumX.Framework.Core.SplashScreenExtensions\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- 框架服务层 ﹫ Services 2 ----------

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Services.Abstractions -o Services\CeriumX.Framework.Services.Abstractions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Services Services\CeriumX.Framework.Services.Abstractions\src

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Services -o Services\CeriumX.Framework.Services\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Services Services\CeriumX.Framework.Services\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- 框架模块化 ﹫ Modularity 2 ----------

@echo\&echo  创建项目 CeriumX.Framework.Modularity.Abstractions 并添加到解决方案。
dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Modularity.Abstractions -o Modularity\CeriumX.Framework.Modularity.Abstractions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Modularity Modularity\CeriumX.Framework.Modularity.Abstractions\src

@echo\&echo  创建项目 CeriumX.Framework.Modularity 并添加到解决方案。
dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Modularity -o Modularity\CeriumX.Framework.Modularity\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Modularity Modularity\CeriumX.Framework.Modularity\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- 框架组合视图 ﹫ CompositeUI 2 ----------

@echo\&echo  创建项目 CeriumX.Framework.CompositeUI.Abstractions 并添加到解决方案。
dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.CompositeUI.Abstractions -o CompositeUI\CeriumX.Framework.CompositeUI.Abstractions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s CompositeUI CompositeUI\CeriumX.Framework.CompositeUI.Abstractions\src

@echo\&echo  创建项目 CeriumX.Framework.CompositeUI 并添加到解决方案。
dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.CompositeUI -o CompositeUI\CeriumX.Framework.CompositeUI\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s CompositeUI CompositeUI\CeriumX.Framework.CompositeUI\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- 框架桌面窗体 ﹫ SurfaceX 2 ----------

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.SurfaceX.WPFSurface -o SurfaceX\CeriumX.Framework.SurfaceX.WPFSurface\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s SurfaceX SurfaceX\CeriumX.Framework.SurfaceX.WPFSurface\src

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.SurfaceX.WinFormSurface -o SurfaceX\CeriumX.Framework.SurfaceX.WinFormSurface\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s SurfaceX SurfaceX\CeriumX.Framework.SurfaceX.WinFormSurface\src





::@echo\&echo 所有项目自动创建工作已结束，600 秒后将自动退出本自动创建程序。
::timeout /t 600

@echo.
@echo.
@echo.
@echo.
@echo.
@echo\&echo 所有项目自动创建完毕，请按任意键退出。
pause>nul 
exit
