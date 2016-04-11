using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lime.Weixin.MP.AdvancedAPIs;
using Lime.Weixin.MP.AdvancedAPIs.MerChant;
using Lime.Weixin.MP.CommonAPIs;
using Lime.Weixin.MP.Entities;
using Lime.Weixin.MP.Test.CommonAPIs;
using Lime.Weixin.MP.TenPayLib;

namespace Lime.Weixin.MP.Test.AdvancedAPIs
{
    //需要通过微信支付审核的账户才能成功
    [TestClass]
    public class ProductTest : CommonApiTest
    {
        [TestMethod]
        public void AddProdectTest()
        {
            var addProductData = new AddProductData();
            var result = ProductApi.AddProduct("[appid]", addProductData);
            Console.Write(result);
            Assert.IsNotNull(result);
        }
    }
}
