//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：AppHostExtensions.cs
// 项目名称：核心 - 抽象（CeriumX.Framework.Core.Abstractions）
// 创建时间：2021-07-13 15:21:32
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CeriumX.Framework.Core.Abstractions
{
    /// <summary>
    /// The app host extensions.
    /// </summary>
    public static class AppHostExtensions
    {
        /// <summary>
        /// 从服务容器中获取指定泛型对象的注册服务
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="appHost">The IAppHost.</param>
        /// <returns>泛型对象注册的服务</returns>
        public static T GetService<T>(this IAppHost appHost) => appHost.Services.GetService<T>();

        /// <summary>
        /// 从服务容器中获取指定泛型对象和唯一编号的注册服务
        /// </summary>
        /// <typeparam name="TService">泛型对象</typeparam>
        /// <param name="appHost">The IAppHost.</param>
        /// <param name="uniqueId">唯一编号</param>
        /// <returns>泛型对象注册的服务</returns>
        public static TService GetService<TService>(this IAppHost appHost, string uniqueId)
        {
            var implementations = appHost.Services.GetServices<TService>();

            if (implementations == null || implementations.Count() <= 0)
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

            return default;
        }

        /// <summary>
        /// 从服务容器中获取指定泛型对象和指定实现的注册服务
        /// </summary>
        /// <typeparam name="TService">泛型对象</typeparam>
        /// <typeparam name="TImplementation">指定实现</typeparam>
        /// <param name="appHost">The IAppHost.</param>
        /// <returns>泛型对象注册的服务</returns>
        public static TService GetService<TService, TImplementation>(this IAppHost appHost)
        {
            var implementations = appHost.Services.GetServices<TService>();

            if (implementations == null || implementations.Count() <= 0)
            {
                throw new InvalidOperationException($"No service for type '{nameof(TService)}' has been registered.");
            }

            return implementations.FirstOrDefault(t => t.GetType() == typeof(TImplementation));
        }
    }
}
