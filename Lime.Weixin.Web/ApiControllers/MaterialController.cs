using Lime.Weixin.MP.CommonAPIs;
using Lime.Weixin.MP.AdvancedAPI;
namespace Lime.Weixin.Web.ApiControllers
{
    public class MaterialController : BaseApiController
    {
        public object GetMaterialList()
        {

            var accessToken = AccessTokenContainer.TryGetAccessToken(WeChatConfig.AppId, WeChatConfig.AppSecret);
           
            mediaApi
        }
    }
}