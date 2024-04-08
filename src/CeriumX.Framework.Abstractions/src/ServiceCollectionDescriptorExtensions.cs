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
    public static void TriedAddTransient(
        this IServiceCollection collection,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type service)
        => collection.TryAddTransient(service);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// with the <paramref name="implementationType"/> implementation
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="implementationType">The implementation type of the service.</param>
    public static void TriedAddTransient(
        this IServiceCollection collection,
        Type service,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
        => collection.TryAddTransient(service, implementationType);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddTransient(
        this IServiceCollection collection,
        Type service,
        Func<IServiceProvider, object> implementationFactory)
        => collection.TryAddTransient(service, implementationFactory);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    public static void TriedAddTransient<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this IServiceCollection collection)
        where TService : class
        => collection.TryAddTransient<TService>();

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// implementation type specified in <typeparamref name="TImplementation"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    public static void TriedAddTransient<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection collection)
        where TService : class
        where TImplementation : class, TService
        => collection.TryAddTransient<TService, TImplementation>();

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Transient"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="services"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/>.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddTransient<TService>(
        this IServiceCollection services,
        Func<IServiceProvider, TService> implementationFactory)
        where TService : class
        => services.TryAddTransient(implementationFactory);



    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    public static void TriedAddScoped(
        this IServiceCollection collection,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type service)
        => collection.TryAddScoped(service);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// with the <paramref name="implementationType"/> implementation
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="implementationType">The implementation type of the service.</param>
    public static void TriedAddScoped(
        this IServiceCollection collection,
        Type service,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
        => collection.TryAddScoped(service, implementationType);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddScoped(
        this IServiceCollection collection,
        Type service,
        Func<IServiceProvider, object> implementationFactory)
        => collection.TryAddScoped(service, implementationFactory);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    public static void TriedAddScoped<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this IServiceCollection collection)
        where TService : class
        => collection.TryAddScoped<TService>();

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// implementation type specified in <typeparamref name="TImplementation"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    public static void TriedAddScoped<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection collection)
        where TService : class
        where TImplementation : class, TService
        => collection.TryAddScoped<TService, TImplementation>();

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Scoped"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="services"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/>.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddScoped<TService>(
        this IServiceCollection services,
        Func<IServiceProvider, TService> implementationFactory)
        where TService : class
        => services.TryAddScoped(implementationFactory);



    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    public static void TriedAddSingleton(
        this IServiceCollection collection,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type service)
        => collection.TryAddSingleton(service);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// with the <paramref name="implementationType"/> implementation
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="implementationType">The implementation type of the service.</param>
    public static void TriedAddSingleton(
        this IServiceCollection collection,
        Type service,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
        => collection.TryAddSingleton(service, implementationType);

    /// <summary>
    /// Adds the specified <paramref name="service"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="service">The type of the service to register.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddSingleton(
        this IServiceCollection collection,
        Type service,
        Func<IServiceProvider, object> implementationFactory)
        => collection.TryAddSingleton(service, implementationFactory);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    public static void TriedAddSingleton<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TService>(this IServiceCollection collection)
        where TService : class
        => collection.TryAddSingleton<TService>();

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// implementation type specified in <typeparamref name="TImplementation"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    public static void TriedAddSingleton<TService, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection collection)
        where TService : class
        where TImplementation : class, TService
        => collection.TryAddSingleton<TService, TImplementation>();

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// with an instance specified in <paramref name="instance"/>
    /// to the <paramref name="collection"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="collection">The <see cref="IServiceCollection"/>.</param>
    /// <param name="instance">The instance of the service to add.</param>
    public static void TriedddSingleton<TService>(this IServiceCollection collection, TService instance)
        where TService : class
        => collection?.TryAddSingleton(instance);

    /// <summary>
    /// Adds the specified <typeparamref name="TService"/> as a <see cref="ServiceLifetime.Singleton"/> service
    /// using the factory specified in <paramref name="implementationFactory"/>
    /// to the <paramref name="services"/> if the service type hasn't already been registered.
    /// </summary>
    /// <typeparam name="TService">The type of the service to add.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/>.</param>
    /// <param name="implementationFactory">The factory that creates the service.</param>
    public static void TriedAddSingleton<TService>(
        this IServiceCollection services,
        Func<IServiceProvider, TService> implementationFactory)
        where TService : class
        => services.TryAddSingleton(implementationFactory);
}