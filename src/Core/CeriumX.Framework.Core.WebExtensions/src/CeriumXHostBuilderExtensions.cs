//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2024 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：CeriumXHostBuilderExtensions.cs
// 项目名称：通用混合开发框架
// 创建时间：2024-04-09 16:44:41
// 创建人员：宋杰军
// 电子邮件：cockroach888@outlook.com
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
namespace CeriumX.Framework.Core.WebExtensions;

/// <summary>
/// CeriumX Universal Hybrid Development Framework Web Extensions Integration.
/// Provides extension methods for the <see cref="ICeriumXHostBuilder"/> from the hosting package.
/// </summary>
public static class CeriumXHostBuilderExtensions
{
    /// <summary>
    /// Configuring WebExtensions.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ICeriumXHostBuilder"/> to configure.</param>
    /// <returns></returns>
    public static ICeriumXHostBuilder ConfigureWebExtensions(this ICeriumXHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureServices(services =>
        {
            services.AddHostedService<WebExtensionsHostedService>();
        });
    }

    /// <summary>
    /// Use WebExtensions.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ICeriumXHostBuilder"/> to configure.</param>
    /// <returns>实现链式编程的同一个IAppHostBuilder实例</returns>
    public static ICeriumXHostBuilder UseWebExtensions(this ICeriumXHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureBeforeBuilder(configBuilder =>
        {
            IHostBuilder? builder = configBuilder.GetService<IHostBuilder>();

            builder?.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
        });
    }
}