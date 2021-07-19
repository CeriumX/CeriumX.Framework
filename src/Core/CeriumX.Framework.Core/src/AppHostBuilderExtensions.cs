//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：AppHostBuilderExtensions.cs
// 项目名称：核心 - 实现（CeriumX.Framework.Core）
// 创建时间：2021-07-18 23:12:05
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using CeriumX.Framework.Core.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;

namespace CeriumX.Framework.Core
{
    /// <summary>
    /// Extension methods for <see cref = "IAppHostBuilder" />.
    /// </summary>
    public static class AppHostBuilderExtensions
    {
        /// <summary>
        /// Specify the content root directory to be used by the host.
        /// </summary>
        /// <param name="hostBuilder">The <see cref="IAppHostBuilder"/> to configure.</param>
        /// <param name="contentRoot">Path to root directory of the application.</param>
        /// <returns>The same instance of the <see cref="IAppHostBuilder"/> for chaining.</returns>
        public static IAppHostBuilder UseContentRoot(this IAppHostBuilder hostBuilder, string contentRoot)
        {
            return hostBuilder.ConfigureHostConfiguration(configBuilder =>
            {
                configBuilder.AddInMemoryCollection(new[]
                {
                    new KeyValuePair<string, string>(HostDefaults.ContentRootKey,
                        contentRoot  ?? throw new ArgumentNullException(nameof(contentRoot)))
                });
            });
        }
    }
}
