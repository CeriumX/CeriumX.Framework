﻿//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：CeriumXHostInstance.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 01:12:57
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
/// CeriumX Host 单例模式
/// </summary>
public static class CeriumXHostInstance
{
    /// <summary>
    /// CeriumX Host default instance.
    /// </summary>
    public static ICeriumXHost? Default { get; private set; }

    /// <summary>
    /// 设置 CeriumX Host 实例
    /// </summary>
    /// <param name="host">CeriumX Host</param>
    internal static void SetInstance(ICeriumXHost host) => Default = host;
}