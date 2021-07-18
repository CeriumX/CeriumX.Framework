//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：WebExtensionsHostedService.cs
// 项目名称：核心 - Web扩展（CeriumX.Framework.Core.WebExtensions）
// 创建时间：2021-07-18 16:18:31
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CeriumX.Framework.Core.WebExtensions
{
    /// <summary>
    /// 用于在Web扩展中响应应用程序生命周期事件的托管服务
    /// <para>Managed services for responding to application lifecycle events in web extensions.</para>
    /// </summary>
    internal sealed class WebExtensionsHostedService : IHostedService
    {
        private readonly ILogger<WebExtensionsHostedService> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebExtensionsHostedService"/> class.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger" /> to Web Extensions.</param>
        /// <param name="appLifetime">The <see cref="IHostApplicationLifetime" /> to Web Extensions.</param>
        public WebExtensionsHostedService(ILogger<WebExtensionsHostedService> logger, IHostApplicationLifetime appLifetime)
        {
            _logger = logger;
            
            appLifetime.ApplicationStarted.Register(OnStarted);
            appLifetime.ApplicationStopping.Register(OnStopping);
            appLifetime.ApplicationStopped.Register(OnStopped);
        }

        /// <summary>
        /// StartAsync 事件回调函数.
        /// </summary>
        /// <param name="cancellationToken"><seealso cref="CancellationToken"/></param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("1.作为触发 StartAsync 事件时的回调函数。");

            return Task.CompletedTask;
        }

        /// <summary>
        /// StopAsync 事件回调函数.
        /// </summary>
        /// <param name="cancellationToken"><seealso cref="CancellationToken"/></param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("4.作为触发 StopAsync 事件时的回调函数。");

            return Task.CompletedTask;
        }

        /// <summary>
        /// OnStarted 事件回调函数.
        /// </summary>
        private void OnStarted()
        {
            _logger.LogInformation("2.作为触发 OnStarted 事件时的回调函数。");
        }

        /// <summary>
        /// OnStopping 事件回调函数.
        /// </summary>
        private void OnStopping()
        {
            _logger.LogInformation("3.作为触发 OnStopping 事件时的回调函数。");
        }

        /// <summary>
        /// OnStopped 事件回调函数.
        /// </summary>
        private void OnStopped()
        {
            _logger.LogInformation("5.作为触发 OnStopped 事件时的回调函数。");
        }
    }
}
