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
    /// 用于数据交换或属性信息等的字典
    /// </summary>
    IDictionary<object, object> Properties { get; }

    /// <summary>
    /// 主机配置
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureHostConfiguration(Action<IConfigurationBuilder> configureDelegate);

    /// <summary>
    /// 应用程序配置
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureAppConfiguration(Action<CeriumXHostBuilderContext, IConfigurationBuilder> configureDelegate);

    /// <summary>
    /// 容器服务
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureServices(Action<CeriumXHostBuilderContext, IServiceCollection> configureDelegate);

    /// <summary>
    /// 生成 CeriumX Host
    /// </summary>
    /// <returns>An initialized <see cref="ICeriumXHost"/>.</returns>
    ICeriumXHost Build();


    /// <summary>
    /// CeriumX Host 实例
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureCeriumXHostInstance(Action<ICeriumXHost> configureDelegate);

    /// <summary>
    /// 在建造者创建之前
    /// </summary>
    /// <param name="configureDelegate">配置委托</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    ICeriumXHostBuilder ConfigureBeforeBuilder(Action<IServiceProvider> configureDelegate);
}