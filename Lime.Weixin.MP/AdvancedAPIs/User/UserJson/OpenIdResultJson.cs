﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：OpenIdResultJson.cs
    文件功能描述：获取关注者OpenId信息返回结果
    
    
    创建标识：Lime - 20150211
    
    修改标识：Lime - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System.Collections.Generic;
using Lime.Weixin.Entities;

namespace Lime.Weixin.MP.AdvancedAPIs.User
{
    public class OpenIdResultJson : WxJsonResult
    {
       public int total { get; set; }
       public int count { get; set; }
       public OpenIdResultJson_Data data { get; set; }
       public string next_openid { get; set; }
    }

    public class OpenIdResultJson_Data
    {
        public List<string> openid { get; set; }
    }
}
