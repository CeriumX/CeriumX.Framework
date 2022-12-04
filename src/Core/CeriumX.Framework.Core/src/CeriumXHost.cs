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
// 创建时间：2022-12-04 11:38:33
// 创建人员：宋杰军
// 电子邮件：cockroach888@outlook.com
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
namespace CeriumX.Framework.Core;

/// <summary>
/// 提供方便的方法来创建具有预设默认值的 <see cref="ICeriumXHostBuilder"/> 的实例。
/// </summary>
public static class CeriumXHost
{
    /// <summary>
    /// 用预先配置的默认值初始化一个 <see cref="Internal.CeriumXHostBuilder"/> 类的新实例。
    /// </summary>
    /// <returns>The <see cref="ICeriumXHostBuilder"/> instance。</returns>
    public static ICeriumXHostBuilder CreateDefaultBuilder() => CreateDefaultBuilder();

    /// <summary>
    /// 用预先配置的默认值初始化一个 <see cref="Internal.CeriumXHostBuilder"/> 类的新实例。
    /// </summary>
    /// <param name="args">命令行参数</param>
    /// <returns>The <see cref="ICeriumXHostBuilder"/> instance。</returns>
    public static ICeriumXHostBuilder CreateDefaultBuilder(string[] args) => new Internal.CeriumXHostBuilder(args);
}