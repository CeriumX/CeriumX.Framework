//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：AppHostLifetime.cs
// 项目名称：核心 - 实现（CeriumX.Framework.Core）
// 创建时间：2021-07-18 23:27:24
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using CeriumX.Framework.Core.Abstractions;
using Microsoft.Extensions.Hosting;
using System.Threading;

namespace CeriumX.Framework.Core.Internal
{
    /// <summary>
    /// Allows consumers to be notified of app lifetime events. This implementation is not intended to be user-replaceable.
    /// </summary>
    internal sealed class AppHostLifetime : IAppHostLifetime
    {
        private readonly IHostApplicationLifetime _applicationLifetime;

        /// <inheritdoc/>
        public AppHostLifetime(IHostApplicationLifetime lifetime)
        {
            _applicationLifetime = lifetime;
        }

        /// <summary>
        /// Triggered when the app host has fully started.
        /// </summary>
        public CancellationToken AppHostStarted => _applicationLifetime.ApplicationStarted;

        /// <summary>
        /// Triggered when the app host is starting a graceful shutdown.
        /// <para>Shutdown will block until all callbacks registered on this token have completed.</para>
        /// </summary>
        public CancellationToken AppHostStopping => _applicationLifetime.ApplicationStopping;

        /// <summary>
        /// Triggered when the app host has completed a graceful shutdown.
        /// <para>The app will not exit until all callbacks registered on this token have completed.</para>
        /// </summary>
        public CancellationToken AppHostStopped => _applicationLifetime.ApplicationStopped;
    }
}
