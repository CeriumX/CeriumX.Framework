//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：HostBuilderExtensions.cs
// 项目名称：核心 - Web扩展（CeriumX.Framework.Core.WebExtensions）
// 创建时间：2021-07-18 16:20:14
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CeriumX.Framework.Core.WebExtensions
{
    /// <summary>
    /// Extension methods for <see cref = "IHostBuilder" />.
    /// </summary>
    public static class HostBuilderExtensions
    {
        /// <summary>
        /// 在混合开发框架中集成ASP.NET Core相关功能的Web扩展配置
        /// <para>Web extension configuration for integrating ASP.NET Core related features in a hybrid development framework.</para>
        /// </summary>
        /// <param name="hostBuilder">The <see cref="IHostBuilder"/> to WebExtensions.</param>
        /// <returns>The same instance of the <see cref="IHostBuilder"/> for chaining.</returns>
        public static IHostBuilder ConfigureWebExtensions(this IHostBuilder hostBuilder)
        {
            return hostBuilder
                   .ConfigureServices((hostContext, services) =>
                   {
                       services.AddHostedService<WebExtensionsHostedService>();
                   })
                   .ConfigureAppConfiguration((hostContext, configBuilder) =>
                   {
                       // do something.
                   })
                   .ConfigureHostConfiguration(configHost =>
                   {
                       // do something.
                   })
                   .ConfigureLogging((hostContext, logBuilder) =>
                   {
                       // do something.
                   })
                   .ConfigureWebHostDefaults(webBuilder =>
                   {
                       webBuilder.UseUrls("http://*:5257")
                                 .UseStartup<Startup>();
                   });
        }
    }
}
