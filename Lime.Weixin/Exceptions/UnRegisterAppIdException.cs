﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：UnRegisterAppIdException.cs
    文件功能描述：未注册AppId异常
    
    
    创建标识：Lime - 20160206

----------------------------------------------------------------*/

using System;

namespace Lime.Weixin.Exceptions
{
    public class UnRegisterAppIdException : WeixinException
    {
        public string AppId { get; set; }
        public UnRegisterAppIdException(string appId, string message, Exception inner = null)
            : base(message, inner)
        {
            AppId = appId;
        }
    }
}
