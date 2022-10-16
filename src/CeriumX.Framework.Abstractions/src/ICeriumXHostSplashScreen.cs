//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：ICeriumXHostSplashScreen.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 01:03:15
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
/// CeriumX Host 闪屏接口
/// </summary>
public interface ICeriumXHostSplashScreen
{
    /// <summary>
    /// 显示闪屏
    /// </summary>
    void ShowSplashScreen();

    /// <summary>
    /// 关闭闪屏
    /// </summary>
    /// <returns>表示响应当前异步操作的支持对象</returns>
    Task CloseSplashScreenAsync();

    /// <summary>
    /// 消息投喂
    /// </summary>
    /// <param name="message">需要投喂的消息</param>
    /// <returns>表示响应当前异步操作的支持对象</returns>
    Task DispatchMessageAsync(string message);
}