using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupLabelAddResponse.
    /// </summary>
    public class HanoiGroupLabelAddResponse : TopResponse
    {
        /// <summary>
        /// 添加成功的返回值
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
