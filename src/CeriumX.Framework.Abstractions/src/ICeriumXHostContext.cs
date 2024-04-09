//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：ICeriumXHostContext.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 00:46:52
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
/// CeriumX Host context interface
/// </summary>
public interface ICeriumXHostContext
{
    /// <summary>
    /// Gets the services configured for the program (for example, using <see cref="M:CeriumXHostBuilder.ConfigureServices(Action&lt;CeriumXHostBuilderContext,IServiceCollection&gt;)" />).
    /// </summary>
    IServiceProvider Services { get; }
}