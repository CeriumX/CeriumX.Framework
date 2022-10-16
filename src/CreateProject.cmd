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
@echo\&echo  ---------- ʾ������ @ samples 0 ----------





@echo.
@echo.
@echo.
@echo\&echo  ---------- �������� @ Bootstrapper 1 ----------

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Bootstrapper -o CeriumX.Framework.Bootstrapper/src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add --in-root CeriumX.Framework.Bootstrapper/src





@echo.
@echo.
@echo.
@echo\&echo  ---------- ��ܳ���� �� Abstractions 1 ----------

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Abstractions -o CeriumX.Framework.Abstractions/src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add --in-root CeriumX.Framework.Abstractions/src



@echo.
@echo.
@echo.
@echo\&echo  ---------- ��ܺ��Ĳ� �� Core 5 ----------

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
@echo\&echo  ---------- ��ܷ���� �� Services 2 ----------

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Services.Abstractions -o Services\CeriumX.Framework.Services.Abstractions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Services Services\CeriumX.Framework.Services.Abstractions\src

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Services -o Services\CeriumX.Framework.Services\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Services Services\CeriumX.Framework.Services\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- ���ģ�黯 �� Modularity 2 ----------

@echo\&echo  ������Ŀ CeriumX.Framework.Modularity.Abstractions ����ӵ����������
dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Modularity.Abstractions -o Modularity\CeriumX.Framework.Modularity.Abstractions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Modularity Modularity\CeriumX.Framework.Modularity.Abstractions\src

@echo\&echo  ������Ŀ CeriumX.Framework.Modularity ����ӵ����������
dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.Modularity -o Modularity\CeriumX.Framework.Modularity\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s Modularity Modularity\CeriumX.Framework.Modularity\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- ��������ͼ �� CompositeUI 2 ----------

@echo\&echo  ������Ŀ CeriumX.Framework.CompositeUI.Abstractions ����ӵ����������
dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.CompositeUI.Abstractions -o CompositeUI\CeriumX.Framework.CompositeUI.Abstractions\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s CompositeUI CompositeUI\CeriumX.Framework.CompositeUI.Abstractions\src

@echo\&echo  ������Ŀ CeriumX.Framework.CompositeUI ����ӵ����������
dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.CompositeUI -o CompositeUI\CeriumX.Framework.CompositeUI\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s CompositeUI CompositeUI\CeriumX.Framework.CompositeUI\src



@echo.
@echo.
@echo.
@echo\&echo  ---------- ������洰�� �� SurfaceX 2 ----------

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.SurfaceX.WPFSurface -o SurfaceX\CeriumX.Framework.SurfaceX.WPFSurface\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s SurfaceX SurfaceX\CeriumX.Framework.SurfaceX.WPFSurface\src

dotnet new classlib -lang "C#" -f net6.0 -n CeriumX.Framework.SurfaceX.WinFormSurface -o SurfaceX\CeriumX.Framework.SurfaceX.WinFormSurface\src
dotnet sln CRS2TBBT4CeriumX.Framework.sln add -s SurfaceX SurfaceX\CeriumX.Framework.SurfaceX.WinFormSurface\src





::@echo\&echo ������Ŀ�Զ����������ѽ�����600 ����Զ��˳����Զ���������
::timeout /t 600

@echo.
@echo.
@echo.
@echo.
@echo.
@echo\&echo ������Ŀ�Զ�������ϣ��밴������˳���
pause>nul 
exit
