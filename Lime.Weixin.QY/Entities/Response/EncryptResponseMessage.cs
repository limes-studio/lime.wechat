﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：EncryptResponseMessage.cs
    文件功能描述：返回给服务器的加密消息
    
    
    创建标识：Lime - 20150313
    
    修改标识：Lime - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Lime.Weixin.QY.Entities.Response
{
    /// <summary>
    /// 返回给服务器的加密消息
    /// </summary>
    public class EncryptResponseMessage
    {
        public string Encrypt { get; set; }
        public string MsgSignature { get; set; }
        public string TimeStamp { get; set; }
        public string Nonce { get; set; }
    }
}
