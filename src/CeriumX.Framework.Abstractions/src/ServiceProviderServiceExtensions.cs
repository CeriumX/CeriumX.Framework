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
/// CeriumX's container service extension method for getting services from <see cref="IServiceProvider" />.
/// </summary>
public static partial class ServiceProviderServiceExtensions
{
    /// <summary>
    /// Get service of type <typeparamref name="TService"/> from the <see cref="IServiceProvider"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service object to get.</typeparam>
    /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the service object from.</param>
    /// <returns>A service object of type <typeparamref name="TService"/> or null if there is no such service.</returns>
    public static TService? GottenService<TService>(this IServiceProvider provider) where TService : class
        => provider.GetService<TService>();

    /// <summary>
    /// Get service of type <paramref name="serviceType"/> from the <see cref="IServiceProvider"/>.
    /// </summary>
    /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the service object from.</param>
    /// <param name="serviceType">An object that specifies the type of service object to get.</param>
    /// <returns>A service object of type <paramref name="serviceType"/>.</returns>
    /// <exception cref="System.InvalidOperationException">There is no service of type <paramref name="serviceType"/>.</exception>
    public static object GottenRequiredService(this IServiceProvider provider, Type serviceType)
        => provider.GetRequiredService(serviceType);

    /// <summary>
    /// Get service of type <typeparamref name="TService"/> from the <see cref="IServiceProvider"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service object to get.</typeparam>
    /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the service object from.</param>
    /// <returns>A service object of type <typeparamref name="TService"/>.</returns>
    /// <exception cref="System.InvalidOperationException">There is no service of type <typeparamref name="TService"/>.</exception>
    public static TService GottenRequiredService<TService>(this IServiceProvider provider) where TService : notnull
        => provider.GetRequiredService<TService>();

    /// <summary>
    /// Get an enumeration of services of type <typeparamref name="TService"/> from the <see cref="IServiceProvider"/>.
    /// </summary>
    /// <typeparam name="TService">The type of service object to get.</typeparam>
    /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the services from.</param>
    /// <returns>An enumeration of services of type <typeparamref name="TService"/>.</returns>
    public static IEnumerable<TService> GottenServices<TService>(this IServiceProvider provider)
        => provider.GetServices<TService>();



    /// <summary>
    /// Creates a new <see cref="IServiceScope"/> that can be used to resolve scoped services.
    /// </summary>
    /// <param name="provider">The <see cref="IServiceProvider"/> to create the scope from.</param>
    /// <returns>A <see cref="IServiceScope"/> that can be used to resolve scoped services.</returns>
    public static IServiceScope CreationScope(this IServiceProvider provider)
        => provider.CreateScope();

    /// <summary>
    /// Creates a new <see cref="AsyncServiceScope"/> that can be used to resolve scoped services.
    /// </summary>
    /// <param name="provider">The <see cref="IServiceProvider"/> to create the scope from.</param>
    /// <returns>An <see cref="AsyncServiceScope"/> that can be used to resolve scoped services.</returns>
    public static AsyncServiceScope CreationAsyncScope(this IServiceProvider provider)
        => provider.CreateAsyncScope();

    /// <summary>
    /// Creates a new <see cref="AsyncServiceScope"/> that can be used to resolve scoped services.
    /// </summary>
    /// <param name="serviceScopeFactory">The <see cref="IServiceScopeFactory"/> to create the scope from.</param>
    /// <returns>An <see cref="AsyncServiceScope"/> that can be used to resolve scoped services.</returns>
    public static AsyncServiceScope CreationAsyncScope(this IServiceScopeFactory serviceScopeFactory)
        => serviceScopeFactory.CreateAsyncScope();
}