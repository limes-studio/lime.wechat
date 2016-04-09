﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：RequestMessageBase.cs
    文件功能描述：接收请求消息基类
    
    
    创建标识：Lime - 20150211
    
    修改标识：Lime - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Lime.Weixin.Entities
{
    public interface IRequestMessageBase : IMessageBase
    {
        //删除MsgType因为企业号和公众号的MsgType为两个独立的枚举类型
        //RequestMsgType MsgType { get; }
        long MsgId { get; set; }
    }

    /// <summary>
    /// 接收到请求的消息
    /// </summary>
    public abstract class RequestMessageBase : MessageBase, IRequestMessageBase
    {
        public RequestMessageBase()
        {

        }

        //public virtual RequestMsgType MsgType
        //{
        //    get { return RequestMsgType.Text; }
        //}

        public long MsgId { get; set; }
    }
}
