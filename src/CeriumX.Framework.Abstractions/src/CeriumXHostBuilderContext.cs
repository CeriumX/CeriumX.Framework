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
/// Context containing the common services on the <see cref="ICeriumXHost" />. Some properties may be null until set by the <see cref="ICeriumXHost" />.
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
    /// The <see cref="IHostEnvironment" /> initialized by the <see cref="ICeriumXHost" />.
    /// </summary>
    public IHostEnvironment HostingEnvironment
    {
        get => _hostBuilderContext.HostingEnvironment;
        set => _hostBuilderContext.HostingEnvironment = value;
    }

    /// <summary>
    /// The <see cref="IConfiguration" /> containing the merged configuration of the application and the <see cref="ICeriumXHost" />.
    /// </summary>
    public IConfiguration Configuration
    {
        get => _hostBuilderContext.Configuration;
        set => _hostBuilderContext.Configuration = value;
    }

    /// <summary>
    /// A central location for sharing state between components during the host building process.
    /// </summary>
    public IDictionary<object, object> Properties => _hostBuilderContext.Properties;
}