/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：IMessageHandler.cs
    文件功能描述：MessageHandler接口
    
    
    创建标识：Lime - 20150924
    
----------------------------------------------------------------*/

using Lime.Weixin.MessageHandlers;
using Lime.Weixin.MP.Entities;

namespace Lime.Weixin.MP.MessageHandlers
{

    public interface IMessageHandler : IMessageHandler<IRequestMessageBase, IResponseMessageBase>
    {
        new IRequestMessageBase RequestMessage { get; set; }
        new IResponseMessageBase ResponseMessage { get; set; }
    }
}
