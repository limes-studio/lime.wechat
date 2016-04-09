/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：LimeMessageQueueItem.cs
    文件功能描述：LimeMessageQueue消息列队项
    
    
    创建标识：Lime - 20151226
    
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lime.Weixin.MessageQueue
{
    /// <summary>
    /// LimeMessageQueue消息列队项
    /// </summary>
    public class LimeMessageQueueItem
    {
        /// <summary>
        /// 列队项唯一标识
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 列队项目命中触发时执行的委托
        /// </summary>
        public Action Action { get; set; }
        /// <summary>
        /// 此实例对象的创建时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 项目说明（主要用于调试）
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 初始化LimeMessageQueue消息列队项
        /// </summary>
        /// <param name="key"></param>
        /// <param name="action"></param>
        /// <param name="description"></param>
        public LimeMessageQueueItem(string key, Action action, string description = null)
        {
            Key = key;
            Action = action;
            Description = description;
            AddTime = DateTime.Now;
        }
    }
}
