﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
  
    文件名：PassportBag.cs
    文件功能描述：Passport包
    
    
    创建标识：Lime - 20150319
----------------------------------------------------------------*/

namespace Lime.Weixin.MP.AppStore
{
    public class PassportBag
    {
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public string AppUrl { get; set; }

        public Passport Passport { get; set; }

        public PassportBag(string appKey, string appSecret, string appUrl)
        {
            AppKey = appKey;
            AppSecret = appSecret;
            AppUrl = appUrl;
        }
    }
}
