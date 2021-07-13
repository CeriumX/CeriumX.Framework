//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：IAppHostLifetime.cs
// 项目名称：核心 - 抽象（CeriumX.Framework.Core.Abstractions）
// 创建时间：2021-07-13 15:31:42
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using System.Threading;

namespace CeriumX.Framework.Core.Abstractions
{
    /// <summary>
    /// Allows consumers to be notified of app lifetime events. This interface is not intended to be user-replaceable.
    /// </summary>
    public interface IAppHostLifetime
    {
        /// <summary>
        /// Triggered when the app host has fully started.
        /// </summary>
        CancellationToken AppHostStarted { get; }

        /// <summary>
        /// Triggered when the app host is starting a graceful shutdown.
        /// Shutdown will block until all callbacks registered on this token have completed.
        /// </summary>
        CancellationToken AppHostStopping { get; }

        /// <summary>
        /// Triggered when the app host has completed a graceful shutdown.
        /// The app will not exit until all callbacks registered on this token have completed.
        /// </summary>
        CancellationToken AppHostStopped { get; }
    }
}
