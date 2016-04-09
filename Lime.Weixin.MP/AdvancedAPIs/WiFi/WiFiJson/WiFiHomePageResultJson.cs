﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：WiFiHomePageResultJson.cs
    文件功能描述：商家主页返回结果返回结果
    
    
    创建标识：Lime - 20150709
----------------------------------------------------------------*/

using Lime.Weixin.Entities;

namespace Lime.Weixin.MP.AdvancedAPIs.WiFi
{
    /// <summary>
    /// 查询商家主页返回结果
    /// </summary>
    public class GetHomePageResult : WxJsonResult
    {
        public GetHomePage_Data date { get; set; }
    }

    public class GetHomePage_Data
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        public long shop_id { get; set; }
        /// <summary>
        /// 模板类型
        /// </summary>
        public int template_id { get; set; }
        /// <summary>
        /// 商家主页链接
        /// </summary>
        public string url { get; set; }
    }
}
