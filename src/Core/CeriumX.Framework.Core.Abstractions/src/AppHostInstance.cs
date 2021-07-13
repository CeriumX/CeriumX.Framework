//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：AppHostInstance.cs
// 项目名称：核心 - 抽象（CeriumX.Framework.Core.Abstractions）
// 创建时间：2021-07-13 15:51:45
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================

namespace CeriumX.Framework.Core.Abstractions
{
    /// <summary>
    /// The Application Host Instance.
    /// </summary>
    public static class AppHostInstance
    {
        /// <summary>
        /// The Application Host Instance of Current.
        /// </summary>
        public static IAppHost Current { get; private set; }

        /// <summary>
        /// Set Application Host Instance.
        /// </summary>
        /// <param name="appHost">Application Host Instance.</param>
        internal static void SetAppHostInstance(IAppHost appHost) => Current = appHost;
    }
}
