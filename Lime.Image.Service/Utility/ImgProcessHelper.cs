using ImageMagick;
using Lime.Image.Service.Models;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lime.Image.Service.Utility
{
    public class ImgProcessHelper
    {

        public static readonly string configpath = @"C:\Users\zhuangch\temp";
        public static readonly string[] fileTypes = new string[] { ".jpg", ".jpeg", ".png", ".gif" };
        public static readonly long MaxSize = 3 * 1024 * 1024;
        public static ImageOptimizer optimizer = new ImageOptimizer();
        /// <summary>
        /// Calculate Path
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string CalcPath(string filename)
        {
            var sh = new SHA1Managed();
            byte[] data = sh.ComputeHash(Encoding.UTF8.GetBytes(filename.Substring(0, 6)));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            string result = sBuilder.ToString();

            string first = result.Substring(0, 6);
            string second = result.Substring(6, 6);

            string path = string.Format(@"{0}\{1}\{2}\{3}\", configpath, first, second, filename);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path + filename;

        }
        /// <summary>
        /// Get MD5 of file 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string MD5Byte(byte[] input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = md5.ComputeHash(input);

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        protected static string AttachInfo(string origin, ImageOptions options)
        {
            StringBuilder str = new StringBuilder();
            str.Append(origin);

            str.AppendFormat("_w{0}_h{1}_p{2}_r{3}_g{4}_{5}", options.w, options.h, (int)options.p, options.r, options.g, options.t.ToString());

            return str.ToString();

        }

        protected static async Task<byte[]> CreateImage(string origin, string dest, ImageOptions option)
        {

            MagickFormat format = new MagickFormat();
            switch (option.t)
            {
                case Extension.JPG: format = MagickFormat.Jpg; break;
                case Extension.JPEG: format = MagickFormat.Jpeg; break;
                case Extension.GIF: format = MagickFormat.Gif; break;
                case Extension.PNG: format = MagickFormat.Png; break;
                default: format = MagickFormat.Jpeg; break;
            }
            // Read image from file
            using (MagickImage image = new MagickImage(origin))
            {
                //byte[] data1 = image.ToByteArray();


                if (option.w == 0 && option.h == 0)
                {
                    //do nothing
                }

                //缩放
                else
                {
                    //if (option.p == ResizeType.Percent)
                    //{
                    //    //Percentage w = new Percentage(option.w > 100 ? 100 : option.w);
                    //    //Percentage h = new Percentage(option.h > 100 ? 100 : option.h);
                    //    Percentage w = new Percentage(option.w);
                    //    Percentage h = new Percentage(option.h);
                    //    image.Resize(w, h);
                    //}

                    MagickGeometry size = new MagickGeometry(option.w, option.h);
                    //等比例缩放
                    if (option.p == ResizeType.Proportion)
                    {
                        size.FillArea = true;
                        image.Resize(size);

                    }
                    //指定大小，会有拉伸变形
                    if (option.p == ResizeType.FillArea)
                    {
                        size.IgnoreAspectRatio = true;
                        image.Resize(size);
                    }
                    //裁剪指定大小区域
                    if (option.p == ResizeType.Crop)
                    {
                        size.IgnoreAspectRatio = true;
                        image.Crop(size);
                    }
                }

                if (option.r > 0)
                {
                    image.Rotate(option.r);
                }
                if (option.g == 1)
                {
                    image.Grayscale(PixelIntensityMethod.Average);
                }
                // Sets the output format 
                image.Format = format;
                if (image.Format == MagickFormat.Jpeg)
                {
                    image.Quality = 75;
                    image.CompressionMethod = CompressionMethod.JPEG2000;
                }
                else
                {
                    image.Quality = 90;

                    image.CompressionMethod = CompressionMethod.LZMA;
                }

                // Create byte array that contains a jpeg file
                image.Write(dest);
                byte[] data = image.ToByteArray();

                //await Optinize(dest);

                return data;
            }

        }

        //private static async Task<int> Optinize(string filename)
        //{
        //    optimizer.OptimalCompression = true;
        //    optimizer.LosslessCompress(filename);

        //    return 1;
        //}

        public async static Task<HttpResponseMessage> GetImage(RequestInfo info)
        {
            var resp = new HttpResponseMessage();
            string originFilePath = CalcPath(info.filename);
            //原图
            if (info.options.o == 1)
            {
                if (File.Exists(originFilePath))
                {
                    MagickImage img = new MagickImage(originFilePath);
                    var imgByte = img.ToByteArray();
                    resp.Content = new ByteArrayContent(imgByte);
                    var contentType = string.Format("image/{0}", img.Format);
                    resp.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
                    resp.StatusCode = HttpStatusCode.OK;
                }
                else
                {
                    resp.StatusCode = HttpStatusCode.NotFound;
                }

            }
            else
            {
                string expectedFilePath = AttachInfo(originFilePath, info.options);

                try
                {
                    //源文件必须存在
                    if (File.Exists(originFilePath))
                    {

                        if (File.Exists(expectedFilePath))
                        {

                            var imgByte = File.ReadAllBytes(expectedFilePath);
                            resp.Content = new ByteArrayContent(imgByte);
                            var contentType = string.Format("image/{0}", info.options.t.ToString());
                            resp.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
                            resp.StatusCode = HttpStatusCode.OK;
                        }
                        //动态生成图片
                        else
                        {
                            var imgByte = await CreateImage(originFilePath, expectedFilePath, info.options);
                            resp.Content = new ByteArrayContent(imgByte);
                            var contentType = string.Format("image/{0}", info.options.t.ToString());
                            resp.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
                        }

                    }
                    else
                    {
                        resp.StatusCode = HttpStatusCode.NotFound;
                    }
                }
                catch (Exception ex)
                {
                    resp.StatusCode = HttpStatusCode.ServiceUnavailable;
                    return resp;
                }
            }

            return resp;


        }


    }
    /// <summary>
    /// 
    /// </summary>
    public class CustomerMultipartMemoryStreamProvider : MultipartMemoryStreamProvider
    {
        public CustomerMultipartMemoryStreamProvider() : base() { }

        public string GetExtension(System.Net.Http.Headers.HttpContentHeaders headers)
        {
            var filename = headers.ContentDisposition.FileName ?? "";

            return Path.GetExtension(filename.TrimStart('"').TrimEnd('"'));
        }
    }



}