//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：AppHost.cs
// 项目名称：核心 - 实现（CeriumX.Framework.Core）
// 创建时间：2021-07-18 23:22:34
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
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CeriumX.Framework.Core.Internal
{
    /// <inheritdoc/>
    internal sealed class AppHost : IAppHost
    {
        private IHost _host;

        /// <inheritdoc/>
        public AppHost(IHost host) => _host = host;

        /// <summary>
        /// The programs configured services.
        /// </summary>
        public IServiceProvider Services => _host.Services;

        /// <summary>
        /// Start the program.
        /// </summary>
        /// <param name="cancellationToken">Used to abort program start.</param>
        /// <returns>A <see cref="Task"/> that will be completed when the <see cref="IAppHost"/> starts.</returns>
        public async Task StartAsync(CancellationToken cancellationToken = default) => await _host.StartAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Attempts to gracefully stop the program.
        /// </summary>
        /// <param name="cancellationToken">Used to indicate when stop should no longer be graceful.</param>
        /// <returns>A <see cref="Task"/> that will be completed when the <see cref="IAppHost"/> stops.</returns>
        public async Task StopAsync(CancellationToken cancellationToken = default) => await _host.StopAsync().ConfigureAwait(false);

        /// <summary>
        /// 资源释放
        /// </summary>
        public void Dispose()
        {
            _host.Dispose();
            _host = null;
        }
    }
}
