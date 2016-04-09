﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：GetSessionStateResultJson.cs
    文件功能描述：获取客户的会话状态返回结果
    
    
    创建标识：Lime - 20150306
    
----------------------------------------------------------------*/

using Lime.Weixin.Entities;

namespace Lime.Weixin.MP.AdvancedAPIs.CustomService
{
    /// <summary>
    /// 获取客户的会话状态返回结果
    /// </summary>
    public class GetSessionStateResultJson : WxJsonResult
	{
		/// <summary>
        /// 正在接待的客服，为空表示没有人在接待
		/// </summary>
        public string kf_account { get; set; }

        /// <summary>
        /// 会话接入的时间
        /// </summary>
        public string createtime { get; set; }
	}
}