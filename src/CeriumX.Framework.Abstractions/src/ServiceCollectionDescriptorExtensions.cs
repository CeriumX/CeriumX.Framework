//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：ServiceCollectionDescriptorExtensions.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 01:21:44
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
/// 服务集合描述器扩展
/// </summary>
public static class ServiceCollectionDescriptorExtensions
{
    /// <summary>
    /// 尝试再尝试添加一个单例服务到服务容器
    /// </summary>
    /// <typeparam name="TService">服务泛型</typeparam>
    /// <typeparam name="TImplementation">实现泛型</typeparam>
    /// <param name="collection"><see cref="IServiceCollection"/></param>
    /// <exception cref="ArgumentNullException">当一个空的引用被传递到一个不接受它作为有效参数的方法时，会抛出一个异常。</exception>
    public static void TryTryAddSingleton<TService, TImplementation>(this IServiceCollection collection)
        where TService : class
        where TImplementation : class, TService
    {
        if (collection is null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        collection.TryTryAddSingleton(typeof(TService), typeof(TImplementation));
    }

    /// <summary>
    /// 尝试再尝试添加一个单例服务到服务容器
    /// </summary>
    /// <param name="collection"><see cref="IServiceCollection"/></param>
    /// <param name="service">服务</param>
    /// <param name="implementationType">实现</param>
    /// <exception cref="ArgumentNullException">当一个空的引用被传递到一个不接受它作为有效参数的方法时，会抛出一个异常。</exception>
    public static void TryTryAddSingleton(this IServiceCollection collection, Type service, Type implementationType)
    {
        if (collection is null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        if (service is null)
        {
            throw new ArgumentNullException(nameof(service));
        }

        if (implementationType is null)
        {
            throw new ArgumentNullException(nameof(implementationType));
        }

        int count = collection.Count;
        for (int i = 0; i < count; i++)
        {
            if (collection[i].ServiceType == service && collection[i].ImplementationType == implementationType)
            {
                // Already added
                return;
            }
        }

        collection.AddSingleton(service, implementationType);
    }
}