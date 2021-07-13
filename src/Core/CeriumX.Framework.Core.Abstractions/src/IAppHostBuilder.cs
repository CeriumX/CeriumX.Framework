//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：IAppHostBuilder.cs
// 项目名称：核心 - 抽象（CeriumX.Framework.Core.Abstractions）
// 创建时间：2021-07-13 15:08:55
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
using System.Collections.Generic;

namespace CeriumX.Framework.Core.Abstractions
{
    /// <summary>
    /// A program initialization abstraction.
    /// </summary>
    public interface IAppHostBuilder
    {
        /// <summary>
        /// A central location for sharing state between components during the app building process.
        /// </summary>
        IDictionary<object, object> Properties { get; }

        /// <summary>
        /// Set up the configuration for the builder itself. This will be used to initialize the Nothing
        /// for use later in the build process. This can be called multiple times and the results will be additive.
        /// </summary>
        /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
        /// to construct the <see cref="IConfiguration"/> for the app.</param>
        /// <returns>The same instance of the <see cref="IAppHostBuilder"/> for chaining.</returns>
        IAppHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate);

        /// <summary>
        /// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
        /// the results will be additive. The results will be available at <see cref="AppHostBuilderContext.Configuration"/> for
        /// subsequent operations, as well as in <see cref="IAppHost.Services"/>.
        /// </summary>
        /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
        /// to construct the <see cref="IConfiguration"/> for the application.</param>
        /// <returns>The same instance of the <see cref="IAppHostBuilder"/> for chaining.</returns>
        IAppHostBuilder ConfigureAppConfiguration(Action<AppHostBuilderContext, IConfigurationBuilder> configureDelegate);

        /// <summary>
        /// Adds services to the container. This can be called multiple times and the results will be additive.
        /// </summary>
        /// <param name="configureDelegate">The delegate for configuring the <see cref="IServiceCollection"/> that will be used
        /// to construct the <see cref="IServiceProvider"/>.</param>
        /// <returns>The same instance of the <see cref="IAppHostBuilder"/> for chaining.</returns>
        IAppHostBuilder ConfigureServices(Action<AppHostBuilderContext, IServiceCollection> configureDelegate);

        /// <summary>
        /// Run the given actions to initialize the app. This can only be called once.
        /// </summary>
        /// <returns>An initialized <see cref="IAppHost"/>.</returns>
        IAppHost Build();


        /// <summary>
        /// Callback Delegation after IAppHost Instance Creation.
        /// </summary>
        /// <param name="configureDelegate">Callback Delegation after IAppHost Instance Creation.</param>
        IAppHostBuilder ConfigureAppHostInstance(Action<IAppHost> configureDelegate);
    }
}
