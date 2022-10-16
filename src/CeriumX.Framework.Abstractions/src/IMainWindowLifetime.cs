//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：IMainWindowLifetime.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 01:06:19
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
/// CeriumX Host 主窗口生命周期事件接口
/// </summary>
public interface IMainWindowLifetime
{
    /// <summary>
    /// 应用程序主窗口初始化完成时触发
    /// </summary>
    CancellationToken WindowInitialized { get; }

    /// <summary>
    /// 应用程序主窗口的布局、呈现并准备开始交互时触发
    /// </summary>
    CancellationToken WindowLoaded { get; }

    /// <summary>
    /// 调用应用程序主窗口的 Close 事件之后触发
    /// </summary>
    CancellationToken WindowClosing { get; }

    /// <summary>
    /// 应用程序主窗口即将关闭时触发
    /// </summary>
    CancellationToken WindowClosed { get; }

    /// <summary>
    /// 设置子窗体的拥有者
    /// </summary>
    /// <typeparam name="TForm">子窗体泛型</typeparam>
    /// <param name="subform">子窗体（必须是所支持的UI窗体）</param>
    void ConfigureOwner<TForm>(TForm subform) where TForm
        : class;
}