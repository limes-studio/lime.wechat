﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Lime
    
    文件名：MenuMatchRule.cs
    文件功能描述：个性化菜单匹配规则
    
    
    创建标识：Lime - 20151222

----------------------------------------------------------------*/

namespace Lime.Weixin.MP.Entities.Menu
{
    /// <summary>
    /// 个性化菜单匹配规则
    /// matchrule共六个字段，均可为空，但不能全部为空，至少要有一个匹配信息是不为空的。 country、province、city组成地区信息，将按照country、province、city的顺序进行验证，要符合地区信息表的内容。地区信息从大到小验证，小的可以不填，即若填写了省份信息，则国家信息也必填并且匹配，城市信息可以不填。 例如 “中国 广东省 广州市”、“中国 广东省”都是合法的地域信息，而“中国 广州市”则不合法，因为填写了城市信息但没有填写省份信息。 地区信息表请点击下载。
    /// </summary>
    public class MenuMatchRule
    {
        /// <summary>
        /// 用户分组id，可通过用户分组管理接口获取
        /// </summary>
        public string group_id { get; set; }
        /// <summary>
        /// 性别：男（1）女（2），不填则不做匹配
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// 国家信息，是用户在微信中设置的地区，具体请参考地区信息表
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 省份信息，是用户在微信中设置的地区，具体请参考地区信息表
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 城市信息，是用户在微信中设置的地区，具体请参考地区信息表
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 客户端版本，当前只具体到系统型号：IOS(1), Android(2),Others(3)，不填则不做匹配
        /// </summary>
        public string client_platform_type { get; set; }

        /// <summary>
        /// 判断是否所有属性都为null
        /// </summary>
        /// <returns></returns>
        public bool CheckAllNull()
        {
            return string.IsNullOrEmpty(group_id)
                   && string.IsNullOrEmpty(sex)
                   && string.IsNullOrEmpty(country)
                   && string.IsNullOrEmpty(province)
                   && string.IsNullOrEmpty(city)
                   && string.IsNullOrEmpty(client_platform_type);
        }
    }
}
