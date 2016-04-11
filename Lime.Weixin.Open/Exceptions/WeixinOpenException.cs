/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：WeixinOpenException.cs
    文件功能描述：微信开放平台异常处理类
    
    
    创建标识：Lime - 20151004

----------------------------------------------------------------*/

using System;
using Lime.Weixin.Exceptions;
using Lime.Weixin.Open.CommonAPIs;
using Lime.Weixin.Open.ComponentAPIs;

namespace Lime.Weixin.Open.Exceptions
{
    /// <summary>
    /// 第三方平台异常
    /// </summary>
    public class WeixinOpenException : WeixinException
    {
        /// <summary>
        /// ComponentBag
        /// </summary>
        public ComponentBag ComponentBag { get; set; }

        public WeixinOpenException(string message, ComponentBag componentBag = null, Exception inner=null)
            : base(message, inner)
        {
            ComponentBag = ComponentBag;
        }
    }
}
