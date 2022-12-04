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
internal sealed class CeriumXHostBuilder : ICeriumXHostBuilder, IServiceProvider
{
    private readonly IHostBuilder _hostBuilder;
    private readonly List<Action<ICeriumXHost>> _cfgHostInstance = new();


    /// <summary>
    /// CeriumX Host Builder
    /// </summary>
    /// <param name="args">命令行参数</param>
    public CeriumXHostBuilder(string[] args)
    {
        _hostBuilder = Host.CreateDefaultBuilder(args)
                           .ConfigureHostConfiguration(config =>
                           {
                               //config.SetBasePath(Directory.GetCurrentDirectory());
                               config.AddJsonFile("hostSettings.json", optional: true, reloadOnChange: true);
                           })
                           .ConfigureServices((context, services) =>
                           {
                               services.AddHostedService<CeriumXHostingHostedService>();
                           })
                           .ConfigureServices((services) =>
                           {
                               services.AddSingleton<ICeriumXHostLifetime, CeriumXHostLifetime>();
                           })
                           .ConfigureLogging((context, logging) =>
                           {
                               // do something.
                               //logging.ClearProviders();
                               //logging.AddConsole();
                           });
    }


    #region 接口实现[ICeriumXHostBuilder]

    /// <summary>
    /// 用于数据交换或属性信息等的字典
    /// </summary>
    public IDictionary<object, object> Properties => _hostBuilder.Properties;

    /// <summary>
    /// 主机配置
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public ICeriumXHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate)
    {
        _hostBuilder.ConfigureHostConfiguration(configureDelegate);
        return this;
    }

    /// <summary>
    /// 应用程序配置
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
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
    /// 容器服务
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
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
    /// 生成 CeriumX Host
    /// </summary>
    /// <returns>An initialized <see cref="ICeriumXHost"/>.</returns>
    public ICeriumXHost Build()
    {
        IHost host = _hostBuilder.Build();
        ICeriumXHost app = new CeriumXHost(host);

        foreach (Action<ICeriumXHost> item in _cfgHostInstance)
        {
            item?.Invoke(app);
        }

        return app;
    }


    /// <summary>
    /// CeriumX Host 实例
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public ICeriumXHostBuilder ConfigureCeriumXHostInstance(Action<ICeriumXHost> configureDelegate)
    {
        _cfgHostInstance.Add(configureDelegate ?? throw new ArgumentNullException(nameof(configureDelegate)));
        return this;
    }

    /// <summary>
    /// 在建造者创建之前
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    public ICeriumXHostBuilder ConfigureBeforeBuilder(Action<IServiceProvider> configureDelegate)
    {
        configureDelegate?.Invoke(this);
        return this;
    }

    #endregion

    #region 接口实现[IServiceProvider]

    /// <summary>
    /// 获取指定类型的服务对象
    /// </summary>
    /// <param name="serviceType">要获得的服务类型</param>
    /// <returns>所产生的服务</returns>
    public object? GetService(Type serviceType)
    {
        if (serviceType == typeof(IHostBuilder))
        {
            return _hostBuilder;
        }

        return default;
    }

    #endregion

}