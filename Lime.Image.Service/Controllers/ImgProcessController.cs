using Lime.Image.Service.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Lime.Image.Service.Utility;
using System.Web.Http.Cors;
namespace Lime.Image.Service.Controllers
{

    public class ImgProcessController : ApiController
    {



        //[HttpPost]
        //[Route("api/uploadtest")]
        //public async Task<HttpResponseMessage> UploadFiletest()
        //{
        //    HttpContent postContent = Request.Content;
        //    // Verify that this is an HTML Form file upload request
        //    if (!postContent.IsMimeMultipartContent("form-data"))
        //    {
        //        throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.UnsupportedMediaType));
        //    }

        //    // Create a stream provider for setting up output streams
        //    MultipartFormDataStreamProvider streamProvider = new ReNameMultipartFormDataStreamProvider(ServerUploadFolder);


        //    // Read the MIME multipart asynchronously content using the stream provider we just created.
        //    await Request.Content.ReadAsMultipartAsync(streamProvider);


        //    // Create response
        //    //var t = new FileResult
        //    //{
        //    //    FileNames = streamProvider.FileData.Select(entry => entry.LocalFileName),
        //    //    Submitter = streamProvider.FormData["submitter"]
        //    //};
        //    //return JsonHelper.toJson(t);
        //    return JsonHelper.toJson(1);

        //}
        ///// <summary>
        ///// rename file
        ///// </summary>
        //private class ReNameMultipartFormDataStreamProvider : MultipartFormDataStreamProvider
        //{
        //    public ReNameMultipartFormDataStreamProvider(string root)
        //        : base(root)
        //    { }
        //    public override string GetLocalFileName(System.Net.Http.Headers.HttpContentHeaders headers)
        //    {
        //        //截取文件扩展名
        //        string exp = Path.GetExtension(headers.ContentDisposition.FileName.TrimStart('"').TrimEnd('"'));
        //        string name = base.GetLocalFileName(headers);
        //        return name + exp;
        //    }
        //}

        /// <summary>
        /// Mutiple file Upload
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("api/upload")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public async Task<HttpResponseMessage> UploadFile()
        {
            HttpContent postContent = Request.Content;
            // Verify that this is an HTML Form file upload request
            if (!postContent.IsMimeMultipartContent("form-data"))
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.UnsupportedMediaType));
            }
            CustomerMultipartMemoryStreamProvider streamProvider = new CustomerMultipartMemoryStreamProvider();

            await postContent.ReadAsMultipartAsync(streamProvider);

            List<FileResult> list = new List<FileResult>();
            foreach (var item in streamProvider.Contents)
            {


                //is a  file body
                if (!string.IsNullOrEmpty(item.Headers.ContentDisposition.FileName))
                {
                    FileResult re = new FileResult();
                    if (item.Headers.ContentLength > 0)
                    {

                        if (ImgProcessHelper.fileTypes.Contains(streamProvider.GetExtension(item.Headers).ToLower()))
                        {
                            if (item.Headers.ContentLength > ImgProcessHelper.MaxSize)
                            {
                                re.Code = false;
                                re.Msg = "Size too large";
                            }
                            else
                            {
                                byte[] t = await item.ReadAsByteArrayAsync();

                                string filename = ImgProcessHelper.MD5Byte(t);
                                var path = ImgProcessHelper.CalcPath(filename);

                                if (!File.Exists(path))
                                {
                                    System.IO.File.WriteAllBytes(path, t);
                                }


                                re.Code = true;
                                re.FileName = filename.ToString();
                                re.location = filename.ToString();
                                re.Msg = "OK";

                            }
                        }
                        else
                        {
                            re.Code = false;
                            re.Msg = "UnAcceptable File Type";
                        }
                    }
                    else
                    {
                        re.Code = false;
                        re.Msg = "Please select a picture";
                    }

                    list.Add(re);
                }


            }
            return JsonHelper.toJson(list);

        }
        [HttpGet]
        [Route("api/{md5:regex(^[a-z0-9]{32}$)}")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public async Task<HttpResponseMessage> Get(string md5, [FromUri] ImageOptions option)
        {
            RequestInfo imginfo = new RequestInfo() { filename = md5, options = option };

            HttpResponseMessage res = await ImgProcessHelper.GetImage(imginfo);

            return res;
        }

    }
}
