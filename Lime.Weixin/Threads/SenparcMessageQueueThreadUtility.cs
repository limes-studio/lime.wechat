/*----------------------------------------------------------------
    Copyright (C) 2016 Lime

    文件名：LimeMessageQueueThreadUtility.cs
    文件功能描述：LimeMessageQueue消息列队线程处理


    创建标识：Lime - 20160210

----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lime.Weixin.MessageQueue;

namespace Lime.Weixin.Threads
{
    /// <summary>
    /// LimeMessageQueue线程自动处理
    /// </summary>
    public class LimeMessageQueueThreadUtility
    {
        private readonly int _sleepMilliSeconds;


        public LimeMessageQueueThreadUtility(int sleepMilliSeconds = 2000)
        {
            _sleepMilliSeconds = sleepMilliSeconds;
        }

        /// <summary>
        /// 析构函数，将未处理的列队处理掉
        /// </summary>
        ~LimeMessageQueueThreadUtility()
        {
            try
            {
                var mq = new LimeMessageQueue();
                System.Diagnostics.Trace.WriteLine(string.Format("LimeMessageQueueThreadUtility执行析构函数"));
                System.Diagnostics.Trace.WriteLine(string.Format("当前列队数量：{0}", mq.GetCount()));

                LimeMessageQueue.OperateQueue();//处理列队
            }
            catch (Exception ex)
            {
                //此处可以添加日志
                System.Diagnostics.Trace.WriteLine(string.Format("LimeMessageQueueThreadUtility执行析构函数错误：{0}", ex.Message));
            }

        }

        /// <summary>
        /// 启动线程轮询
        /// </summary>
        public void Run()
        {
            do
            {
                LimeMessageQueue.OperateQueue();
                Thread.Sleep(_sleepMilliSeconds);
            } while (true);
        }
    }
}
