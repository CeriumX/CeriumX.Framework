//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2021 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：IAppHostSplashScreen.cs
// 项目名称：核心 - 抽象（CeriumX.Framework.Core.Abstractions）
// 创建时间：2021-07-13 15:45:43
// 创建人员：宋杰军
// 负责人员：宋杰军
// 参与人员：宋杰军
// ========================================================================
// 修改日期：
// 修改人员：
// 修改内容：
// ========================================================================
using System.Threading.Tasks;

namespace CeriumX.Framework.Core.Abstractions
{
    /// <summary>
    /// 应用程序闪屏服务接口
    /// </summary>
    public interface IAppHostSplashScreen
    {
        /// <summary>
        /// 显示闪屏
        /// </summary>
        void SplashScreenShow();

        /// <summary>
        /// 关闭闪屏
        /// </summary>
        /// <returns>An object that represents the current operation.</returns>
        Task SplashScreenCloseAsync();

        /// <summary>
        /// 投递消息
        /// </summary>
        /// <param name="message">投递的消息</param>
        /// <returns>An object that represents the current operation.</returns>
        Task DispatchMessageAsync(string message);
    }
}
