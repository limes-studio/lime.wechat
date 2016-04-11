/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：ResponseMessageVideo.cs
    文件功能描述：响应回复视频消息
    
    
    创建标识：Lime - 20150313
    
    修改标识：Lime - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Lime.Weixin.QY.Entities
{
    /// <summary>
    /// 需要预先上传多媒体文件到微信服务器，只支持认证服务号。
    /// </summary>
    public class ResponseMessageVideo : ResponseMessageBase, IResponseMessageBase
    {
        new public virtual ResponseMsgType MsgType
        {
            get { return ResponseMsgType.Video; }
        }

        public Video Video { get; set; }

        public ResponseMessageVideo()
        {
            Video = new Video();
        }
    }
}
