//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：ServiceProviderServiceExtensions.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 01:23:24
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
/// 容器服务提供者扩展类
/// </summary>
public static class ServiceProviderServiceExtensions
{
    /// <summary>
    /// 获取指定服务的实例
    /// </summary>
    /// <typeparam name="TService">服务泛型</typeparam>
    /// <param name="provider">服务提供者 <see cref="IServiceProvider"/></param>
    /// <returns>服务实例</returns>
    public static TService? GetInstance<TService>(this IServiceProvider provider) where TService : class
        => provider.GetService<TService>();

    /// <summary>
    /// 获取具有指定编号服务的实例
    /// </summary>
    /// <typeparam name="TService">服务泛型</typeparam>
    /// <param name="provider">服务提供者 <see cref="IServiceProvider"/></param>
    /// <param name="uniqueId">唯一编号</param>
    /// <returns>服务实例</returns>
    public static TService? GetInstance<TService>(this IServiceProvider provider, string uniqueId)
        where TService : class
    {
        var implementations = provider.GetServices<TService>();

        if (implementations.Any() is false)
        {
            throw new InvalidOperationException($"No service for type '{nameof(TService)}' has been registered.");
        }

        foreach (var item in implementations)
        {
            if (item is IUniqueOfMultipleImplementations result && result.UniqueId == uniqueId)
            {
                return item;
            }
        }

        throw new InvalidOperationException($"No service for type '{nameof(TService)}' has been registered.");
    }

    /// <summary>
    /// 获取指定泛型服务与实现的实例
    /// </summary>
    /// <typeparam name="TService">服务泛型</typeparam>
    /// <typeparam name="TImplementation">服务实现泛型</typeparam>
    /// <param name="provider">服务提供者 <see cref="IServiceProvider"/></param>
    /// <returns>服务实例</returns>
    public static TService? GetInstance<TService, TImplementation>(this IServiceProvider provider)
        where TService : class
        where TImplementation : class, TService
    {
        var implementations = provider.GetServices<TService>();

        if (implementations.Any() is false)
        {
            throw new InvalidOperationException($"No service for type '{nameof(TService)}' has been registered.");
        }

        return implementations.FirstOrDefault(t => t.GetType() == typeof(TImplementation));
    }
}