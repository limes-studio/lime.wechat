﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：Video.cs
    文件功能描述：响应回复消息 视频类
    
    
    创建标识：Lime - 20150211
    
    修改标识：Lime - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Lime.Weixin.MP.Entities
{
    public class Video
    {
        public string MediaId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
