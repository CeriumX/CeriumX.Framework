//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：CeriumXHostBuilder.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-12-04 11:38:57
// 创建人员：宋杰军
// 电子邮件：cockroach888@outlook.com
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
namespace CeriumX.Framework.Core.Internal;

/// <summary>
/// CeriumX Host Builder
/// </summary>
/// <param name="args">命令行参数</param>
internal sealed class CeriumXHostBuilder(string[]? args) : ICeriumXHostBuilder, IServiceProvider
{
    private readonly List<Action<ICeriumXHost>> _hostInstanceDelegate = [];
    private readonly IHostBuilder _hostBuilder = Host.CreateDefaultBuilder(args)
                           .ConfigureServices((context, services) =>
                           {
                               services.AddHostedService<CeriumXHostingHostedService>();
                           })
                           .ConfigureServices((services) =>
                           {
                               services.AddSingleton<ICeriumXHostLifetime, CeriumXHostLifetime>();
                           });


    #region 接口实现[ICeriumXHostBuilder]

    /// <summary>
    /// A central location for sharing state between components during the host building process.
    /// </summary>
    public IDictionary<object, object> Properties => _hostBuilder.Properties;

    /// <summary>
    /// Set up the configuration for the builder itself. This will be used to initialize the <see cref="IHostEnvironment"/>
    /// for use later in the build process. This can be called multiple times and the results will be additive.
    /// </summary>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
    /// to construct the <see cref="IConfiguration"/> for the host.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public ICeriumXHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate)
    {
        _hostBuilder.ConfigureHostConfiguration(configureDelegate);
        return this;
    }

    /// <summary>
    /// Sets up the configuration for the remainder of the build process and application. This can be called multiple times and
    /// the results will be additive. The results will be available at <see cref="CeriumXHostBuilderContext.Configuration"/> for
    /// subsequent operations, as well as in <see cref="IHost.Services"/>.
    /// </summary>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IConfigurationBuilder"/> that will be used
    /// to construct the <see cref="IConfiguration"/> for the application.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public ICeriumXHostBuilder ConfigureAppConfiguration(Action<CeriumXHostBuilderContext, IConfigurationBuilder> configureDelegate)
    {
        _hostBuilder.ConfigureAppConfiguration((context, configurationBuilder) =>
        {
            configureDelegate?.Invoke(new CeriumXHostBuilderContext(context), configurationBuilder);
        });

        return this;
    }

    /// <summary>
    /// Adds services to the container. This can be called multiple times and the results will be additive.
    /// </summary>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IServiceCollection"/> that will be used
    /// to construct the <see cref="IServiceProvider"/>.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public ICeriumXHostBuilder ConfigureServices(Action<CeriumXHostBuilderContext, IServiceCollection> configureDelegate)
    {
        _hostBuilder.ConfigureServices((context, services) =>
        {
            configureDelegate?.Invoke(new CeriumXHostBuilderContext(context), services);
        });

        return this;
    }

    /// <summary>
    /// Run the given actions to initialize the host. This can only be called once.
    /// </summary>
    /// <returns>An initialized <see cref="ICeriumXHost"/>.</returns>
    public ICeriumXHost Build()
    {
        IHost host = _hostBuilder.Build();
        ICeriumXHost app = new CeriumXHost(host);

        foreach (Action<ICeriumXHost> item in _hostInstanceDelegate)
        {
            item?.Invoke(app);
        }

        return app;
    }



    /// <summary>
    /// 配置 CeriumX Host 实例化委托，用于框架之外的全局范围使用。
    /// </summary>
    /// <param name="configureDelegate">通过此配置委托，可以获得创建后的 CeriumX Host 实例化对象。</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public ICeriumXHostBuilder ConfigureCeriumXHostInstance(Action<ICeriumXHost> configureDelegate)
    {
        _hostInstanceDelegate.Add(configureDelegate ?? throw new ArgumentNullException(nameof(configureDelegate)));
        return this;
    }

    /// <summary>
    /// 在 CeriumX Host 实例化之前，往依赖服务容器中注入服务。
    /// </summary>
    /// <param name="configureDelegate">The delegate for configuring the <see cref="IServiceProvider"/> that will be used
    /// to construct the <see cref="IServiceCollection"/>.</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public ICeriumXHostBuilder ConfigureBeforeBuilder(Action<IServiceProvider> configureDelegate)
    {
        configureDelegate?.Invoke(this);
        return this;
    }

    #endregion


    #region 接口实现[IServiceProvider]

    /// <summary>
    /// Gets the service object of the specified type.
    /// </summary>
    /// <param name="serviceType">An object that specifies the type of service object to get.</param>
    /// <returns>A service object of type serviceType. -or- null if there is no service object of type serviceType.</returns>
    public object? GetService(Type serviceType)
    {
        return serviceType == typeof(IHostBuilder) ? _hostBuilder : default;
    }

    #endregion

}