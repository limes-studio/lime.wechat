﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
  
    文件名：WxJsonResult.cs
    文件功能描述：JSON返回结果
    
    
    创建标识：Lime - 20150319
----------------------------------------------------------------*/

namespace Lime.Weixin.MP.AppStore
{
    /// <summary>
    /// JSON返回结果（用于菜单接口等）
    /// </summary>
    public class WxJsonResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
