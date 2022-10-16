//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：CeriumXHostBuilderContext.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-10-17 00:40:11
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
/// CeriumX Host 建造者上下文
/// </summary>
public sealed class CeriumXHostBuilderContext
{
    private readonly HostBuilderContext _hostBuilderContext;


    /// <summary>
    /// CeriumX Host 建造者上下文
    /// </summary>
    /// <param name="hostBuilderContext">The <see cref="HostBuilderContext" /> to <see cref="CeriumXHostBuilderContext"/>.</param>
    internal CeriumXHostBuilderContext(HostBuilderContext hostBuilderContext)
    {
        _hostBuilderContext = hostBuilderContext;
    }


    /// <summary>
    /// <see cref="IHostEnvironment"/>
    /// </summary>
    internal IHostEnvironment HostingEnvironment => _hostBuilderContext.HostingEnvironment;

    /// <summary>
    /// <see cref="IConfiguration"/>
    /// </summary>
    public IConfiguration Configuration => _hostBuilderContext.Configuration;

    /// <summary>
    /// 用于数据交换或属性信息等的字典
    /// </summary>
    public IDictionary<object, object> Properties => _hostBuilderContext.Properties;
}