using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lime.Weixin.MP.AdvancedAPIs;
using Lime.Weixin.MP.AdvancedAPIs.Poi;
using Lime.Weixin.MP.CommonAPIs;
using Lime.Weixin.MP.Entities;
using Lime.Weixin.MP.Test.CommonAPIs;

namespace Lime.Weixin.MP.Test.AdvancedAPIs
{
    [TestClass]
    public class PoiTest : CommonApiTest
    {
        [TestMethod]
        public void UploadImageTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);

            string file = @"E:\1.jpg";

            var result = PoiApi.UploadImage(accessToken, file);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }

        [TestMethod]
        public void GetPoiListTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);

            var result = PoiApi.GetPoiList(accessToken, 0);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }
    }
}
