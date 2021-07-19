//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：AppHostBuilderExtensions.cs
// 项目名称：核心 - 抽象（CeriumX.Framework.Core.Abstractions）
// 创建时间：2021-07-13 15:19:31
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CeriumX.Framework.Core.Abstractions
{
    /// <summary>
    /// Extension methods for <see cref = "IAppHostBuilder" />.
    /// </summary>
    public static class AppHostBuilderExtensions
    {
        /// <summary>
        /// Color see see.
        /// </summary>
        /// <param name="hostBuilder">The <see cref="IAppHostBuilder" /> to configure.</param>
        /// <returns>The same instance of the <see cref="IAppHostBuilder"/> for chaining.</returns>
        public static IAppHostBuilder UseAppHostSingleInstance(this IAppHostBuilder hostBuilder)
        {
            return hostBuilder.ConfigureAppHostInstance(appHost => { AppHostInstance.SetAppHostInstance(appHost); });
        }

        /// <summary>
        /// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
        /// the results will be additive. The results will be available at <see cref="AppHostBuilderContext.Configuration"/> for
        /// subsequent operations, as well as in <see cref="IAppHost.Services"/>.
        /// </summary>
        /// <param name="hostBuilder">The <see cref="IAppHostBuilder" /> to configure.</param>
        /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
        /// to construct the <see cref="IConfiguration"/> for the host.</param>
        /// <returns>The same instance of the <see cref="IAppHostBuilder"/> for chaining.</returns>
        public static IAppHostBuilder ConfigureAppConfiguration(this IAppHostBuilder hostBuilder, Action<IConfigurationBuilder> configureDelegate)
        {
            return hostBuilder.ConfigureAppConfiguration((context, builder) => configureDelegate(builder));
        }

        /// <summary>
        /// Adds services to the container. This can be called multiple times and the results will be additive.
        /// </summary>
        /// <param name="hostBuilder">The <see cref="IAppHostBuilder" /> to configure.</param>
        /// <param name="configureDelegate">The delegate for configuring the <see cref="IServiceCollection"/>.</param>
        /// <returns>The same instance of the <see cref="IAppHostBuilder"/> for chaining.</returns>
        public static IAppHostBuilder ConfigureServices(this IAppHostBuilder hostBuilder, Action<IServiceCollection> configureDelegate)
        {
            return hostBuilder.ConfigureServices((context, collection) => configureDelegate(collection));
        }
    }
}
