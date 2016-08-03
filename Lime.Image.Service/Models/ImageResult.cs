using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Lime.Image.Service.Models
{
    public class ImageResult
    {
        public bool status { get; set; }
        public ImageInfo info { get; set; }

        public Error error { get; set; }
    }

    public class ImageInfo
    {
        public string md5 { get; set; }
        public double size { get; set; }
    }

    public class Error
    {
        public int code { get; set; }
        public string message { get; set; }
    }

    public class RequestInfo
    {

        public string filename { get; set; }
        public ImageOptions options { get; set; }
    }
    public class ImageOptions
    {
        //缩放类型
        public ResizeType p { get; set; }
        //宽
        public int w { get; set; }
        //高
        public int h { get; set; }
        //旋转角度 rotate
        public int r { get; set; }
        //灰白化 gray
        public int g { get; set; }
        //图片格式
        public Extension t { get; set; }

        public int o { get; set; }

    }

    public enum ResizeType
    {
        
        Proportion=1,
        FillArea=0,
        //默认固定
        Crop=2
    }
    public enum Extension
    {
        //默认JPEG
        JPG = 1,
        JPEG = 0,
        PNG = 2,
        GIF = 3
    }
}