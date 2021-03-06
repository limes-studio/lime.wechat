﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：AnalysisResultJson.cs
    文件功能描述：分析数据接口返回结果
    
    
    创建标识：Lime - 20150309
    
    修改标识：Lime - 20150310
    修改描述：整理接口
----------------------------------------------------------------*/

using System.Collections.Generic;

namespace Lime.Weixin.MP.AdvancedAPIs.Analysis
{
    /// <summary>
    /// 分析数据接口返回结果
    /// </summary>
    public class AnalysisResultJson<T> : BaseAnalysisResult
    {
        public List<T> list
        {
            get { return base.ListObj as List<T>; }
            set { base.ListObj = value; }
        }

        public AnalysisResultJson()
        {
            ListObj = new List<T>();
        }
    }

}
