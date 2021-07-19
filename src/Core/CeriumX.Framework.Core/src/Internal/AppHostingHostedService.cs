//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：AppHostingHostedService.cs
// 项目名称：核心 - 实现（CeriumX.Framework.Core）
// 创建时间：2021-07-18 23:25:16
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace CeriumX.Framework.Core.Internal
{
    /// <summary>
    /// 用于在框架核心实现中响应应用程序生命周期事件的托管服务
    /// <para>Managed services for responding to application lifecycle events in the core implementation of the framework.</para>
    /// </summary>
    internal sealed class AppHostingHostedService : IHostedService
    {
        private readonly ILogger<AppHostingHostedService> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppHostingHostedService"/> class.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to framework core implementation.</param>
        /// <param name="appLifetime">The <see cref="IHostApplicationLifetime" /> to framework core implementation.</param>
        public AppHostingHostedService(ILogger<AppHostingHostedService> logger, IHostApplicationLifetime appLifetime)
        {
            _logger = logger;

            appLifetime.ApplicationStarted.Register(OnStarted);
            appLifetime.ApplicationStopping.Register(OnStopping);
            appLifetime.ApplicationStopped.Register(OnStopped);
        }


        /// <summary>
        /// StartAsync 事件回调函数
        /// </summary>
        /// <param name="cancellationToken"><seealso cref="CancellationToken"/></param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("1.作为触发 StartAsync 事件时的回调函数。");

            return Task.CompletedTask;
        }

        /// <summary>
        /// StopAsync 事件回调函数
        /// </summary>
        /// <param name="cancellationToken"><seealso cref="CancellationToken"/></param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("4.作为触发 StopAsync 事件时的回调函数。");

            return Task.CompletedTask;
        }


        /// <summary>
        /// OnStarted 事件回调函数
        /// </summary>
        private void OnStarted()
        {
            _logger.LogInformation("2.作为触发 OnStarted 事件时的回调函数。");
        }

        /// <summary>
        /// OnStopping 事件回调函数
        /// </summary>
        private void OnStopping()
        {
            _logger.LogInformation("3.作为触发 OnStopping 事件时的回调函数。");
        }

        /// <summary>
        /// OnStopped 事件回调函数
        /// </summary>
        private void OnStopped()
        {
            _logger.LogInformation("5.作为触发 OnStopped 事件时的回调函数。");
        }
    }
}
