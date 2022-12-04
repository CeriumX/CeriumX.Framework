//=========================================================================
//**   通用混合开发框架（CeriumX.Framework）
//=========================================================================
//**   脉脉含情的充满精神的高尚的小强精神
//**   风幽思静繁花落；夜半楼台听江雨。（cockroach888@outlook.com）
//=========================================================================
//**   Copyright © 蟑螂·魂 2022 -- Support 华夏银河空间联盟
//=========================================================================
// 文件名称：CeriumXHostBuilderExtensions.cs
// 项目名称：通用混合开发框架
// 创建时间：2022-12-03 21:51:06
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
/// 通用混合开发框架 CeriumXHost 扩展服务
/// </summary>
public static class CeriumXHostBuilderExtensions
{
    /// <summary>
    /// 指定主机要使用的内容根目录
    /// </summary>
    /// <param name="hostBuilder">The <see cref="ICeriumXHostBuilder"/> to configure.</param>
    /// <param name="contentRoot">应用程序的根目录的路径</param>
    /// <returns>The same instance of the <see cref="ICeriumXHostBuilder"/> for chaining.</returns>
    /// <exception cref="ArgumentNullException">当一个空的引用被传递到一个不接受它作为有效参数的方法时，会抛出一个异常。</exception>
    public static ICeriumXHostBuilder UseContentRoot(this ICeriumXHostBuilder hostBuilder, string contentRoot)
    {
        return hostBuilder.ConfigureHostConfiguration(configBuilder =>
        {
            configBuilder.AddInMemoryCollection(new[]
            {
                    new KeyValuePair<string, string>(HostDefaults.ContentRootKey,
                        contentRoot  ?? throw new ArgumentNullException(nameof(contentRoot)))
                });
        });
    }
}