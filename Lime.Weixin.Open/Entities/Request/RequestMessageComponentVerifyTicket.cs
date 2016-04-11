/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：RequestMessageComponentVerifyTicket.cs
    文件功能描述：推送component_verify_ticket协议
    
    
    创建标识：Lime - 20150430
----------------------------------------------------------------*/

namespace Lime.Weixin.Open
{
    public class RequestMessageComponentVerifyTicket : RequestMessageBase
    {
        public override RequestInfoType InfoType
        {
            get { return RequestInfoType.component_verify_ticket; }
        }
        public string ComponentVerifyTicket { get; set; }
    }
}
