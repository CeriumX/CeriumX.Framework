//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2024 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：ServiceCollectionDescriptorExtensions.cs
// 项目名称：通用混合开发框架
// 创建时间：2024-04-08 15:11:53
// 创建人员：宋杰军
// 电子邮件：cockroach888@outlook.com
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Diagnostics.CodeAnalysis;

namespace CeriumX.Framework.Abstractions;

/// <summary>
/// CeriumX's container service extension method for adding and removing services to an <see cref="IServiceCollection" />.
/// </summary>
public static partial class ServiceCollectionDescriptorExtensions
{
    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedTransient(
        this IServiceCollection collection,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type service,
        object? serviceKey)
        => collection.TryAddKeyedTransient(service, serviceKey);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// with the <paramref name="implementationType"/> implementation
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="serviceKey">The service key.</param>
    /// <param name="implementationType">The implementation type of the service.</param>
    public static void TriedAddKeyedTransient(
        this IServiceCollection collection,
        Type service,
        object? serviceKey,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
        => collection.TryAddKeyedTransient(service, serviceKey, implementationType);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="serviceKey">The service key.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddKeyedTransient(
        this IServiceCollection collection,
        Type service,
        object? serviceKey,
        Func<IServiceProvider, object?, object> implementationFactory)
        => collection.TryAddKeyedTransient(service, serviceKey, implementationFactory);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedTransient<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this IServiceCollection collection, object? serviceKey)
        where TService : class
        => collection.TryAddKeyedTransient<TService>(serviceKey);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// implementation type specified in <typeparamref name="TImplementation"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedTransient<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection collection, object? serviceKey)
        where TService : class
        where TImplementation : class, TService
        => collection.TryAddKeyedTransient<TService, TImplementation>(serviceKey);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="serviceKey">The service key.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddKeyedTransient<TService>(
        this IServiceCollection collection,
        object? serviceKey,
        Func<IServiceProvider, object?, TService> implementationFactory)
        where TService : class
        => collection.TryAddKeyedTransient(serviceKey, implementationFactory);



    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedScoped(
        this IServiceCollection collection,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type service,
        object? serviceKey)
        => collection.TryAddKeyedScoped(service, serviceKey);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// with the <paramref name="implementationType"/> implementation
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="serviceKey">The service key.</param>
    /// <param name="implementationType">The implementation type of the service.</param>
    public static void TriedAddKeyedScoped(
        this IServiceCollection collection,
        Type service,
        object? serviceKey,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
        => collection.TryAddKeyedScoped(service, serviceKey, implementationType);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="serviceKey">The service key.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddKeyedScoped(
        this IServiceCollection collection,
        Type service,
        object? serviceKey,
        Func<IServiceProvider, object?, object> implementationFactory)
        => collection.TryAddKeyedScoped(service, serviceKey, implementationFactory);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedScoped<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this IServiceCollection collection, object? serviceKey)
        where TService : class
        => collection.TryAddKeyedScoped<TService>(serviceKey);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// implementation type specified in <typeparamref name="TImplementation"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedScoped<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection collection, object? serviceKey)
        where TService : class
        where TImplementation : class, TService
        => collection.TryAddKeyedScoped<TService, TImplementation>(serviceKey);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedScoped<TService>(
        this IServiceCollection collection,
        object? serviceKey,
        Func<IServiceProvider, object?, TService> implementationFactory)
        where TService : class
        => collection.TryAddKeyedScoped(serviceKey, implementationFactory);



    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedSingleton(
        this IServiceCollection collection,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type service,
        object? serviceKey)
        => collection.TryAddKeyedSingleton(service, serviceKey);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// with the <paramref name="implementationType"/> implementation
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="serviceKey">The service key.</param>
    /// <param name="implementationType">The implementation type of the service.</param>
    public static void TriedAddKeyedSingleton(
        this IServiceCollection collection,
        Type service,
        object? serviceKey,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
        => collection.TryAddKeyedSingleton(service, serviceKey, implementationType);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="serviceKey">The service key.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddKeyedSingleton(
        this IServiceCollection collection,
        Type service,
        object? serviceKey,
        Func<IServiceProvider, object?, object> implementationFactory)
        => collection.TryAddKeyedSingleton(service, serviceKey, implementationFactory);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedSingleton<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this IServiceCollection collection, object? serviceKey)
        where TService : class
        => collection.TryAddKeyedSingleton<TService>(serviceKey);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// implementation type specified in <typeparamref name="TImplementation"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="serviceKey">The service key.</param>
    public static void TriedAddKeyedSingleton<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection collection, object? serviceKey)
        where TService : class
        where TImplementation : class, TService
        => collection.TryAddKeyedSingleton<TService, TImplementation>(serviceKey);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// with an instance specified in <paramref name="instance"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="serviceKey">The service key.</param>
    /// <param name="instance">The instance of the service to add.</param>
    public static void TriedAddKeyedSingleton<TService>(this IServiceCollection collection, object? serviceKey, TService instance)
        where TService : class
        => collection.TryAddKeyedSingleton(serviceKey, instance);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="serviceKey">The service key.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddKeyedSingleton<TService>(
        this IServiceCollection collection,
        object? serviceKey,
        Func<IServiceProvider, object?, TService> implementationFactory)
        where TService : class
        => collection.TryAddKeyedSingleton(serviceKey, implementationFactory);
}