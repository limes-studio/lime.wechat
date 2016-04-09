/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：ResponseMessageImage.cs
    文件功能描述：响应回复图片消息
    
    
    创建标识：Lime - 20150313
    
    修改标识：Lime - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Lime.Weixin.QY.Entities
{
    public class ResponseMessageImage : ResponseMessageBase, IResponseMessageBase
    {
        new public virtual ResponseMsgType MsgType
        {
            get { return ResponseMsgType.Image; }
        }

        public Image Image { get; set; }

        public ResponseMessageImage()
        {
            Image = new Image();
        }
    }
}
