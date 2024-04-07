//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2024 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：ServiceProviderKeyedServiceExtensions.cs
// 项目名称：通用混合开发框架
// 创建时间：2024-04-07 16:36:49
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
/// CeriumX's container service extension method for getting services from <see cref="IServiceProvider" />.
/// </summary>
public static class ServiceProviderKeyedServiceExtensions
{
    /// <summary>
    /// Get service of type <typeparamref name="TService"/> from the <see cref="IServiceProvider"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service object to get.</typeparam>
    /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the service object from.</param>
    /// <param name="serviceKey">An object that specifies the key of service object to get.</param>
    /// <returns>A service object of type <typeparamref name="TService"/> or null if there is no such service.</returns>
    public static TService? GottenKeyedService<TService>(this IServiceProvider provider, object? serviceKey)
        => provider.GetKeyedService<TService>(serviceKey);

    /// <summary>
    /// Get service of type <paramref name="serviceType"/> from the <see cref="IServiceProvider"/>.
    /// </summary>
    /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the service object from.</param>
    /// <param name="serviceType">An object that specifies the type of service object to get.</param>
    /// <param name="serviceKey">An object that specifies the key of service object to get.</param>
    /// <returns>A service object of type <paramref name="serviceType"/>.</returns>
    /// <exception cref="System.InvalidOperationException">There is no service of type <paramref name="serviceType"/>.</exception>
    public static object GottenRequiredKeyedService(this IServiceProvider provider, Type serviceType, object? serviceKey)
        => provider.GetRequiredKeyedService(serviceType, serviceKey);

    /// <summary>
    /// Get service of type <typeparamref name="TService"/> from the <see cref="IServiceProvider"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service object to get.</typeparam>
    /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the service object from.</param>
    /// <param name="serviceKey">An object that specifies the key of service object to get.</param>
    /// <returns>A service object of type <typeparamref name="TService"/>.</returns>
    /// <exception cref="System.InvalidOperationException">There is no service of type <typeparamref name="TService"/>.</exception>
    public static TService GottenRequiredKeyedService<TService>(this IServiceProvider provider, object? serviceKey) where TService : notnull
        => provider.GetRequiredKeyedService<TService>(serviceKey);

    /// <summary>
    /// Get an enumeration of services of type <typeparamref name="TService"/> from the <see cref="IServiceProvider"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service object to get.</typeparam>
    /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the services from.</param>
    /// <param name="serviceKey">An object that specifies the key of service object to get.</param>
    /// <returns>An enumeration of services of type <typeparamref name="TService"/>.</returns>
    public static IEnumerable<TService> GottenKeyedServices<TService>(this IServiceProvider provider, object? serviceKey)
        => provider.GetKeyedServices<TService>(serviceKey);
}