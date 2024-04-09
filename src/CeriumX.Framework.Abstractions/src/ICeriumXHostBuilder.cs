//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：ICeriumXHostBuilder.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 00:50:31
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
/// CeriumX Host Builder Interface
/// </summary>
public interface ICeriumXHostBuilder
{
    /// <summary>
    /// A central location for sharing state between components during the host building process.
    /// </summary>
    IDictionary<object, object> Properties { get; }

    /// <summary>
    /// Set up the configuration for the builder itself. This will be used to initialize the <see cref="IHostEnvironment"/>
    /// for use later in the build process. This can be called multiple times and the results will be additive.
    /// </summary>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
    /// to construct the <see cref="IConfiguration"/> for the host.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate);

    /// <summary>
    /// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
    /// the results will be additive. The results will be available at <see cref="CeriumXHostBuilderContext.Configuration"/> for
    /// subsequent operations, as well as in <see cref="IHost.Services"/>.
    /// </summary>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
    /// to construct the <see cref="IConfiguration"/> for the application.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureAppConfiguration(Action<CeriumXHostBuilderContext, IConfigurationBuilder> configureDelegate);

    /// <summary>
    /// Adds services to the container. This can be called multiple times and the results will be additive.
    /// </summary>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IServiceCollection"/> that will be used
    /// to construct the <see cref="IServiceProvider"/>.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureServices(Action<CeriumXHostBuilderContext, IServiceCollection> configureDelegate);

    /// <summary>
    /// Run the given actions to initialize the host. This can only be called once.
    /// </summary>
    /// <returns>An initialized <see cref="ICeriumXHost"/>.</returns>
    ICeriumXHost Build();



    /// <summary>
    /// 配置 CeriumX Host 实例化委托，用于框架之外的全局范围使用。
    /// </summary>
    /// <param name="configureDelegate">通过此配置委托，可以获得创建后的 CeriumX Host 实例化对象。</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureCeriumXHostInstance(Action<ICeriumXHost> configureDelegate);

    /// <summary>
    /// 在 CeriumX Host 实例化之前，往依赖服务容器中注入服务。
    /// </summary>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IServiceProvider"/> that will be used
    /// to construct the <see cref="IServiceCollection"/>.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureBeforeBuilder(Action<IServiceProvider> configureDelegate);
}