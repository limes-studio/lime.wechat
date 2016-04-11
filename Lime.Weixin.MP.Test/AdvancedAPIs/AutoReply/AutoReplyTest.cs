using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lime.Weixin.MP.AdvancedAPIs;
using Lime.Weixin.MP.AdvancedAPIs.Analysis;
using Lime.Weixin.MP.CommonAPIs;
using Lime.Weixin.MP.Entities;
using Lime.Weixin.MP.Test.CommonAPIs;

namespace Lime.Weixin.MP.Test.AdvancedAPIs
{
    //已经通过测试
    [TestClass]
    public class AutoReplyTest : CommonApiTest
    {
        [TestMethod]
        public void ArticleSummaryTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = AutoReplyApi.GetCurrentAutoreplyInfo(accessToken);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }
    }
}
