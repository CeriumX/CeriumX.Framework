//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：IAppMainWindowLifetime.cs
// 项目名称：核心 - 抽象（CeriumX.Framework.Core.Abstractions）
// 创建时间：2021-07-13 15:41:37
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
    /// 应用程序主窗口生命周期相关事件接口
    /// </summary>
    public interface IAppMainWindowLifetime
    {
        /// <summary>
        /// 在应用程序主窗口的初始化完成时发生。
        /// </summary>
        CancellationToken AppWindowInitialized { get; }

        /// <summary>
        /// 在应用程序主窗口的布局、呈现并准备开始交互时发生。
        /// </summary>
        CancellationToken AppWindowLoaded { get; }

        /// <summary>
        /// 在调用应用程序主窗口的 Close 事件之后发生。
        /// </summary>
        CancellationToken AppWindowClosing { get; }

        /// <summary>
        /// 在应用程序主窗口即将关闭时发生。
        /// </summary>
        CancellationToken AppWindowClosed { get; }
    }
}
