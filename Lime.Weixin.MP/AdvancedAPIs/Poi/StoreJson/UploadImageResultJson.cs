/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：UploadImageResultJson.cs
    文件功能描述：门店 上传图片返回结果
    
    
    创建标识：Lime - 20150513
----------------------------------------------------------------*/

using Lime.Weixin.Entities;

namespace Lime.Weixin.MP.AdvancedAPIs.Poi
{
    /// <summary>
    /// 上传图片返回结果
    /// </summary>
    public class UploadImageResultJson : WxJsonResult
    {
        /// <summary>
        /// 上传成功后图片的链接
        /// </summary>
        public string url { get; set; }
    }
}
