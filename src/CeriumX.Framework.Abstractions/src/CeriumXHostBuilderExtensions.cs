﻿//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：CeriumXHostBuilderExtensions.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 01:15:59
// 创建人员：宋杰军
// 电子邮件：cockroach888@outlook.com
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
namespace CeriumX.Framework.Abstractions;

/// <summary>
/// CeriumX Host Builder 扩展
/// </summary>
public static class CeriumXHostBuilderExtensions
{
    /// <summary>
    /// 使用 ICeriumX Host 单例
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ICeriumXHostBuilder"/> to configure.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public static ICeriumXHostBuilder UseCeriumXHostSingleInstance(this ICeriumXHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureCeriumXHostInstance(CeriumXHostInstance.SetInstance);
    }

    /// <summary>
    /// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
    /// the results will be additive. The results will be available at <see cref="CeriumXHostBuilderContext.Configuration"/> for
    /// subsequent operations, as well as in <see cref="ICeriumXHostContext.Services"/>.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ICeriumXHostBuilder" /> to configure.</param>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
    /// to construct the <see cref="IConfiguration"/> for the host.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public static ICeriumXHostBuilder ConfigureAppConfiguration(this ICeriumXHostBuilder hostBuilder, Action<IConfigurationBuilder> configureDelegate)
    {
        return hostBuilder.ConfigureAppConfiguration((context, builder) => configureDelegate(builder));
    }

    /// <summary>
    /// Adds services to the container. This can be called multiple times and the results will be additive.
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ICeriumXHostBuilder" /> to configure.</param>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IServiceCollection"/>.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public static ICeriumXHostBuilder ConfigureServices(this ICeriumXHostBuilder hostBuilder, Action<IServiceCollection> configureDelegate)
    {
        return hostBuilder.ConfigureServices((context, collection) => configureDelegate(collection));
    }
}