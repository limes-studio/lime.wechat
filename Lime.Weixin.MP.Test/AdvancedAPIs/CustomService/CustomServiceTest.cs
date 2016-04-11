using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lime.Weixin.MP.AdvancedAPIs;
using Lime.Weixin.MP.AdvancedAPIs.CustomService;
using Lime.Weixin.MP.CommonAPIs;
using Lime.Weixin.MP.Helpers;
using Lime.Weixin.MP.Test.CommonAPIs;

namespace Lime.Weixin.MP.Test.AdvancedAPIs
{
    [TestClass]
    public class CustomServiceTest : CommonApiTest
    {
        protected string _custonPassWord = MD5UtilHelper.GetMD5("123123", null);

        [TestMethod]
        public void GetRecordTest()
        {
            var openId = "o3IHxjkke04__4n1kFeXpfMjjRBc";
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.GetRecord(accessToken, DateTime.Today, DateTime.Now, 10, 1);
            Assert.IsTrue(result.recordlist.Count > 0);
        }

        [TestMethod]
        public void GetCustomBasicInfoTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.GetCustomBasicInfo(accessToken);
            Assert.IsTrue(result.kf_list.Count > 0);
        }

        [TestMethod]
        public void GetCustomOnlineInfoTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.GetCustomOnlineInfo(accessToken);
            Assert.IsTrue(result.kf_online_list.Count > 0);
        }

        [TestMethod]
        public void AddCustomTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.AddCustom(accessToken, "zcc@LimeRobot", "zcc", _custonPassWord);
            Assert.AreEqual(result.errcode,ReturnCode.请求成功);
        }

        [TestMethod]
        public void UpdateCustomTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.UpdateCustom(accessToken, "zcc@LimeRobot", "zcc", _custonPassWord);
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }

        [TestMethod]
        public void UploadCustomHeadimgCustom()
        {
            string file = "C:\\Users\\czhang\\Desktop\\logo.png";

            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.UploadCustomHeadimg(accessToken, "zcc@LimeRobot", file);
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }

        [TestMethod]
        public void DeleteCustomTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.DeleteCustom(accessToken, "zcc@LimeRobot");
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }

        [TestMethod]
        public void CreateSessionTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.CreateSession(accessToken, _testOpenId, "zcc@LimeRobot");
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }

        [TestMethod]
        public void CloseSessionTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.CloseSession(accessToken, _testOpenId, "zcc@LimeRobot");
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }

        [TestMethod]
        public void GetSessionStateTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.GetSessionState(accessToken, _testOpenId);
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }

        [TestMethod]
        public void GetSessionListTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.GetSessionList(accessToken, _testOpenId);
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }

        [TestMethod]
        public void GetWaitCaseTest()
        {
            var accessToken = AccessTokenContainer.GetAccessToken(_appId);
            var result = CustomServiceApi.GetWaitCase(accessToken);
            Assert.AreEqual(result.errcode, ReturnCode.请求成功);
        }
    }
}
