/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：RequestMessageUnauthorized.cs
    文件功能描述：推送取消授权通知
    
    
    创建标识：Lime - 20150430
----------------------------------------------------------------*/

namespace Lime.Weixin.Open
{
    public class RequestMessageUnauthorized : RequestMessageBase
    {
        public override RequestInfoType InfoType
        {
            get { return RequestInfoType.unauthorized; }
        }
        public string AuthorizerAppid { get; set; }
    }
}
