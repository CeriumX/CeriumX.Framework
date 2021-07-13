//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：AppHostBuilderContext.cs
// 项目名称：核心 - 抽象（CeriumX.Framework.Core.Abstractions）
// 创建时间：2021-07-13 14:58:58
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace CeriumX.Framework.Core.Abstractions
{
    /// <summary>
    /// Context containing the common services on the <see cref="IAppHost" />. Some properties may be null until set by the <see cref="IAppHost" />.
    /// </summary>
    public sealed class AppHostBuilderContext
    {
        private readonly HostBuilderContext _hostBuilderContext;

        /// <summary>
        /// Context containing the common services on the <see cref="IAppHost" />. Some properties may be null until set by the <see cref="IAppHost" />.
        /// </summary>
        /// <param name="hostBuilderContext"></param>
        internal AppHostBuilderContext(HostBuilderContext hostBuilderContext)
        {
            _hostBuilderContext = hostBuilderContext;
        }

        /// <summary>
        /// The <see cref="IConfiguration" /> containing the merged configuration of the application and the <see cref="IAppHost" />.
        /// </summary>
        public IConfiguration Configuration => _hostBuilderContext.Configuration;

        /// <summary>
        /// A central location for sharing state between components during the app building process.
        /// </summary>
        public IDictionary<object, object> Properties => _hostBuilderContext.Properties;
    }
}
