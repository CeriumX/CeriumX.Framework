//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：WebExtensionsHostedService.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-12-11 20:40:46
// 创建人员：宋杰军
// 电子邮件：cockroach888@outlook.com
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
namespace CeriumX.Framework.Core.WebExtensions;

/// <summary>
/// Web扩展生命周期事件响应的后台托管服务
/// </summary>
internal sealed class WebExtensionsHostedService : IHostedService
{
    private readonly ILogger<WebExtensionsHostedService> _logger;


    /// <summary>
    /// Web扩展生命周期事件响应的后台托管服务
    /// </summary>
    /// <param name="logger">日志服务</param>
    /// <param name="lifetime">通用主机应用程序生命周期</param>
    public WebExtensionsHostedService(ILogger<WebExtensionsHostedService> logger, IHostApplicationLifetime lifetime)
    {
        _logger = logger;

        lifetime.ApplicationStarted.Register(OnStarted);
        lifetime.ApplicationStopping.Register(OnStopping);
        lifetime.ApplicationStopped.Register(OnStopped);
    }


    #region 接口实现[IHostedService]

    /// <summary>
    /// 启动事件异步回调函数
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>表示响应当前异步操作的支持对象</returns>
    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Web: 1.作为触发 StartAsync 事件时的回调函数。");

        return Task.CompletedTask;
    }

    /// <summary>
    /// 停止事件异步回调函数
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>表示响应当前异步操作的支持对象</returns>
    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Web: 4.作为触发 StopAsync 事件时的回调函数。");

        return Task.CompletedTask;
    }

    #endregion


    /// <summary>
    /// 启动完成时事件回调函数
    /// </summary>
    private void OnStarted()
    {
        _logger.LogInformation("Web: 2.作为触发 OnStarted 事件时的回调函数。");
    }

    /// <summary>
    /// 停止进行时事件回调函数
    /// </summary>
    private void OnStopping()
    {
        _logger.LogInformation("Web: 3.作为触发 OnStopping 事件时的回调函数。");
    }

    /// <summary>
    /// 停止完成时事件回调函数
    /// </summary>
    private void OnStopped()
    {
        _logger.LogInformation("Web: 5.作为触发 OnStopped 事件时的回调函数。");
    }
}