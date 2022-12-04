//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：CeriumXHost.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-12-04 11:38:50
// 创建人员：宋杰军
// 电子邮件：cockroach888@outlook.com
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
namespace CeriumX.Framework.Core.Internal;

/// <summary>
/// CeriumX Host
/// </summary>
internal sealed class CeriumXHost : ICeriumXHost
{
    private readonly IHost _host;


    /// <summary>
    /// CeriumX Host
    /// </summary>
    /// <param name="host">The <see cref="IHost"/> instance.</param>
    public CeriumXHost(IHost host) => _host = host;


    #region 接口实现[ICeriumXHostContext]

    /// <summary>
    /// 容器服务
    /// </summary>
    public IServiceProvider Services => _host.Services;

    #endregion

    #region 接口实现[ICeriumXHost]

    /// <summary>
    /// 启动
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>表示响应当前异步操作的支持对象</returns>
    public async Task StartAsync(CancellationToken cancellationToken = default)
        => await _host.RunAsync(cancellationToken).ConfigureAwait(false);

    /// <summary>
    /// 停止
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>表示响应当前异步操作的支持对象</returns>
    public async Task StopAsync(CancellationToken cancellationToken = default)
        => await _host.StopAsync(cancellationToken).ConfigureAwait(false);

    /// <summary>
    /// 资源释放
    /// </summary>
    public void Dispose() => _host.Dispose();

    #endregion

}