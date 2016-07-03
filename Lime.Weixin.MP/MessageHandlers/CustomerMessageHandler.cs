using System;
using System.IO;
using Lime.Weixin.MP.MessageHandlers;
using Lime.Weixin.MP.Entities;
using Lime.Weixin.MP.Entities.Request;
using Lime.Weixin.Context;


namespace Lime.Weixin.MP.MessageHandlers
{
    public class CustomMessageHandler : MessageHandler<MessageContext<IRequestMessageBase, IResponseMessageBase>>
    {
        public  CustomMessageHandler(Stream inputStream, PostModel postModel, int maxRecordCount = 0)
            : base(inputStream, postModel, maxRecordCount)
        {

        }

        public override IResponseMessageBase DefaultResponseMessage(IRequestMessageBase requestMessage)
        {
            //ResponseMessageText也可以是News等其他类型
            var responseMessage = CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content = "这条消息来自DefaultResponseMessage。";
            return responseMessage;
        }

        public override IResponseMessageBase OnTextRequest(RequestMessageText requestMessage)
        {
            //TODO:这里的逻辑可以交给Service处理具体信息，参考OnLocationRequest方法或/Service/LocationSercice.cs
            var responseMessage = CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content =
                string.Format(
                    "您刚才发送了文字信息：{0}",
                    requestMessage.Content);
            return responseMessage;
        }

 

        //更多没有重写的OnXX方法，将默认返回DefaultResponseMessage中的结果。
        
    }
}
