//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：CeriumXHost.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-12-04 11:38:33
// 创建人员：宋杰军
// 电子邮件：cockroach888@outlook.com
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
namespace CeriumX.Framework.Core;

/// <summary>
/// Provides convenience methods for creating instances of <see cref="ICeriumXHostBuilder"/> with pre-configured defaults.
/// </summary>
public static class CeriumXHost
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CeriumXHostBuilder"/> class with pre-configured defaults.
    /// </summary>
    /// <remarks>
    ///   The following defaults are applied to the returned <see cref="CeriumXHostBuilder"/>:
    ///   <list type="bullet">
    ///     <item><description>set the <see cref="IHostEnvironment.ContentRootPath"/> to the result of <see cref="Directory.GetCurrentDirectory()"/></description></item>
    ///     <item><description>load host <see cref="IConfiguration"/> from "DOTNET_" prefixed environment variables</description></item>
    ///     <item><description>load app <see cref="IConfiguration"/> from 'appsettings.json' and 'appsettings.[<see cref="IHostEnvironment.EnvironmentName"/>].json'</description></item>
    ///     <item><description>load app <see cref="IConfiguration"/> from User Secrets when <see cref="IHostEnvironment.EnvironmentName"/> is 'Development' using the entry assembly</description></item>
    ///     <item><description>load app <see cref="IConfiguration"/> from environment variables</description></item>
    ///     <item><description>configure the <see cref="ILoggerFactory"/> to log to the console, debug, and event source output</description></item>
    ///     <item><description>enables scope validation on the dependency injection container when <see cref="IHostEnvironment.EnvironmentName"/> is 'Development'</description></item>
    ///   </list>
    /// </remarks>
    /// <returns>The initialized <see cref="ICeriumXHostBuilder"/>.</returns>
    public static ICeriumXHostBuilder CreateDefaultBuilder() => CreateDefaultBuilder(args: null);

    /// <summary>
    /// Initializes a new instance of the <see cref="CeriumXHostBuilder"/> class with pre-configured defaults.
    /// </summary>
    /// <remarks>
    ///   The following defaults are applied to the returned <see cref="CeriumXHostBuilder"/>:
    ///   <list type="bullet">
    ///     <item><description>set the <see cref="IHostEnvironment.ContentRootPath"/> to the result of <see cref="Directory.GetCurrentDirectory()"/></description></item>
    ///     <item><description>load host <see cref="IConfiguration"/> from "DOTNET_" prefixed environment variables</description></item>
    ///     <item><description>load host <see cref="IConfiguration"/> from supplied command line args</description></item>
    ///     <item><description>load app <see cref="IConfiguration"/> from 'appsettings.json' and 'appsettings.[<see cref="IHostEnvironment.EnvironmentName"/>].json'</description></item>
    ///     <item><description>load app <see cref="IConfiguration"/> from User Secrets when <see cref="IHostEnvironment.EnvironmentName"/> is 'Development' using the entry assembly</description></item>
    ///     <item><description>load app <see cref="IConfiguration"/> from environment variables</description></item>
    ///     <item><description>load app <see cref="IConfiguration"/> from supplied command line args</description></item>
    ///     <item><description>configure the <see cref="ILoggerFactory"/> to log to the console, debug, and event source output</description></item>
    ///     <item><description>enables scope validation on the dependency injection container when <see cref="IHostEnvironment.EnvironmentName"/> is 'Development'</description></item>
    ///   </list>
    /// </remarks>
    /// <param name="args">The command line args.</param>
    /// <returns>The initialized <see cref="ICeriumXHostBuilder"/>.</returns>
    public static ICeriumXHostBuilder CreateDefaultBuilder(string[]? args) => new CeriumXHostBuilder(args);
}