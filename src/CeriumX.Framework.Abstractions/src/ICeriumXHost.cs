//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：ICeriumXHost.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 00:48:16
// 创建人员：宋杰军
// 电子邮件：cockroach888@outlook.com
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
namespace CeriumX.Framework.Abstractions;

/// <summary>
/// CeriumX Host Interface
/// </summary>
public interface ICeriumXHost : ICeriumXHostContext, IDisposable
{
    /// <summary>
    /// 启动
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>表示响应当前异步操作的支持对象</returns>
    Task StartAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// 停止
    /// </summary>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>表示响应当前异步操作的支持对象</returns>
    Task StopAsync(CancellationToken cancellationToken = default);
}