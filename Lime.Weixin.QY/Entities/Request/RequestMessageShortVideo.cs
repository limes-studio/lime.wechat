/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：RequestMessageShortVideo.cs
    文件功能描述：接收小视频消息
    
    
    创建标识：Lime - 20150708
----------------------------------------------------------------*/

namespace Lime.Weixin.QY.Entities
{
    public class RequestMessageShortVideo : RequestMessageBase, IRequestMessageBase
    {
        public override RequestMsgType MsgType
        {
            get { return RequestMsgType.ShortVideo; }
        }

        public string MediaId { get; set;}
        public string ThumbMediaId { get; set; }
    }
}
