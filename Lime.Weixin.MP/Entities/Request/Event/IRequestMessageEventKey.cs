/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：IRequestMessageEventKey.cs
    文件功能描述：具有EventKey属性的RequestMessage接口
    
    
    创建标识：Lime - 20150211
    
    修改标识：Lime - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Lime.Weixin.MP.Entities
{
    /// <summary>
    /// 具有EventKey属性的RequestMessage接口
    /// </summary>
    public interface IRequestMessageEventKey
    {
        string EventKey { get; set; }
    }
}
