﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lime.Weixin.Entities;

namespace Lime.Weixin.MP.AdvancedAPIs.Url
{
    /// <summary>
    /// ShortUrl返回结果
    /// </summary>
    public class ShortUrlResult : WxJsonResult
    {
        public string short_url { get; set; }
    }
}
