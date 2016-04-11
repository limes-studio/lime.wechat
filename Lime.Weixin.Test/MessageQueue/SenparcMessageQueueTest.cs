using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lime.Weixin;
using Lime.Weixin.MessageQueue;

namespace Lime.WeixinTests.MessageQueue
{
    [TestClass]
    public class LimeMessageQueueTest
    {
        [TestMethod]
        public void TestAll()
        {
            var mq = new LimeMessageQueue();
            var count = mq.GetCount();
            var key = DateTime.Now.Ticks.ToString();

            //Test Add()
            var item = mq.Add(key, () => WeixinTrace.Log("测试LimeMessageQueue写入Key=A"));
            Assert.AreEqual(count+1,mq.GetCount());
            //var hashCode = item.GetHashCode();

            //Test GetCurrentKey()
            var currentKey = mq.GetCurrentKey();
            Assert.AreEqual(key,currentKey);

            //Test GetItem
            var currentItem = mq.GetItem(currentKey);
            Assert.AreEqual(currentItem.Key,item.Key);
            Assert.AreEqual(currentItem.AddTime,item.AddTime);

            //Test Remove
            mq.Remove(key);
            Assert.AreEqual(count, mq.GetCount());
        }
    }
}
