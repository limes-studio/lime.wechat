/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：ThirdPartyInfo_Suite_Ticket.cs
    文件功能描述：推送suite_ticket协议
    
    
    创建标识：Lime - 20150313
    
    修改标识：Lime - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Lime.Weixin.QY.Entities
{
    /// <summary>
    /// 推送suite_ticket协议
    /// </summary>
    public class RequestMessageInfo_Suite_Ticket : ThirdPartyInfoBase, IThirdPartyInfoBase
    {
        public override ThirdPartyInfo InfoType
        {
            get { return ThirdPartyInfo.SUITE_TICKET; }
        }

        /// <summary>
        /// Ticket内容
        /// </summary>
        public string SuiteTicket { get; set; }
    }
}
