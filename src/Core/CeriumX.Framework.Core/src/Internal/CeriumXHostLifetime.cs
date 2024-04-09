//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：CeriumXHostLifetime.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-12-04 11:39:05
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
/// CeriumX Host 生命周期事件
/// </summary>
/// <param name="lifetime">通用主机应用程序生命周期</param>
internal sealed class CeriumXHostLifetime(IHostApplicationLifetime lifetime) : ICeriumXHostLifetime
{
    private readonly IHostApplicationLifetime _applicationLifetime = lifetime;


    #region 接口实现[ICeriumXHostLifetime]

    /// <summary>
    /// Triggered when the CeriumX Host has fully started.
    /// </summary>
    public CancellationToken CeriumXHostStarted => _applicationLifetime.ApplicationStarted;

    /// <summary>
    /// Triggered when the CeriumX Host is starting a graceful shutdown.
    /// Shutdown will block until all callbacks registered on this token have completed.
    /// </summary>
    public CancellationToken CeriumXHostStopping => _applicationLifetime.ApplicationStopping;

    /// <summary>
    /// Triggered when the CeriumX Host has completed a graceful shutdown.
    /// The application will not exit until all callbacks registered on this token have completed.
    /// </summary>
    public CancellationToken CeriumXHostStopped => _applicationLifetime.ApplicationStopped;

    #endregion

}