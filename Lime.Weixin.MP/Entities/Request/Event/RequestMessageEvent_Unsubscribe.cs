﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：RequestMessageEvent_Unsubscribe.cs
    文件功能描述：事件之取消订阅
    
    
    创建标识：Lime - 20150211
    
    修改标识：Lime - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Lime.Weixin.MP.Entities
{
    /// <summary>
    /// 事件之取消订阅
    /// </summary>
    public class RequestMessageEvent_Unsubscribe : RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.unsubscribe; }
        }
    }
}
