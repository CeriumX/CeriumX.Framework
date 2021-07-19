//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：AppMainWindowLifetime.cs
// 项目名称：核心 - 实现（CeriumX.Framework.Core）
// 创建时间：2021-07-18 23:27:48
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using CeriumX.Framework.Core.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;

namespace CeriumX.Framework.Core.Internal
{
    /// <summary>
    /// 应用程序主窗口生命周期相关事件
    /// </summary>
    internal sealed class AppMainWindowLifetime : IAppMainWindowLifetime
    {
        private readonly CancellationTokenSource _initializedSource = new CancellationTokenSource();
        private readonly CancellationTokenSource _loadedSource = new CancellationTokenSource();
        private readonly CancellationTokenSource _closingSource = new CancellationTokenSource();
        private readonly CancellationTokenSource _closedSource = new CancellationTokenSource();
        private readonly ILogger<AppMainWindowLifetime> _logger;

        /// <summary>
        /// 应用程序主窗口生命周期相关事件
        /// </summary>
        /// <param name="logger"><inheritdoc/></param>
        public AppMainWindowLifetime(ILogger<AppMainWindowLifetime> logger)
        {
            _logger = logger;
        }

        #region 接口实现[IAppMainWindowLifetime]

        /// <summary>
        /// 在应用程序主窗口的初始化完成时发生。
        /// </summary>
        public CancellationToken AppWindowInitialized => _initializedSource.Token;

        /// <summary>
        /// 在应用程序主窗口的布局、呈现并准备开始交互时发生。
        /// </summary>
        public CancellationToken AppWindowLoaded => _loadedSource.Token;

        /// <summary>
        /// 在调用应用程序主窗口的 Close 事件之后发生。
        /// </summary>
        public CancellationToken AppWindowClosing => _closingSource.Token;

        /// <summary>
        /// 在应用程序主窗口即将关闭时发生。
        /// </summary>
        public CancellationToken AppWindowClosed => _closedSource.Token;

        #endregion

        #region 成员方法

        /// <inheritdoc/>
        public void NotifyInitialized()
        {
            try
            {
                ExecuteHandlers(_initializedSource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }

        /// <inheritdoc/>
        public void NotifyLoaded()
        {
            try
            {
                ExecuteHandlers(_loadedSource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }

        /// <inheritdoc/>
        public void NotifyClosing()
        {
            try
            {
                ExecuteHandlers(_closingSource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }

        /// <inheritdoc/>
        public void NotifyClosed()
        {
            try
            {
                ExecuteHandlers(_closedSource);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }

        /// <inheritdoc/>
        private void ExecuteHandlers(CancellationTokenSource cancel)
        {
            // Noop if this is already cancelled
            if (cancel.IsCancellationRequested)
            {
                return;
            }

            // Run the cancellation token callbacks
            cancel.Cancel(throwOnFirstException: false);
        }

        #endregion

    }
}
