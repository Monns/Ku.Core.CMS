//----------------------------------------------------------------
// Copyright (C) 2018 kulend 版权所有
//
// 文件名：SmsTempletDto.cs
// 功能描述：短信模板 数据传输类
//
// 创建者：kulend@qq.com
// 创建时间：2018-04-02 09:50
//
//----------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ku.Core.Infrastructure.Attributes;

namespace Ku.Core.CMS.Domain.Dto.System
{
    /// <summary>
    /// 短信模板
    /// </summary>
    public class SmsTempletDto : BaseProtectedDto
    {
        /// <summary>
        /// 标记
        /// </summary>
        [Display(Name = "标记")]
        [Required, StringLength(64, MinimumLength = 5)]
        public string Tag { set; get; }

        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        [Required, StringLength(100)]
        public string Name { set; get; }

        /// <summary>
        /// 示例
        /// </summary>
        [Display(Name = "示例")]
        [StringLength(400)]
        [DataType(DataType.MultilineText)]
        public string Example { get; set; }

        /// <summary>
        /// 模板
        /// </summary>
        [Display(Name = "模板")]
        [StringLength(400)]
        [DataType(DataType.MultilineText)]
        public string Templet { get; set; }

        /// <summary>
        /// 模板KEY
        /// </summary>
        [Display(Name = "模板KEY")]
        [StringLength(64)]
        public string TempletKey { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [Display(Name = "签名")]
        [StringLength(40)]
        public string Signature { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [Display(Name = "是否可用", Prompt = "是|否")]
        public bool IsEnable { set; get; } = true;

        /// <summary>
        /// 过期时间（分钟）
        /// </summary>
        [Display(Name = "过期时间", Prompt = "分钟，0为不设置过期时间")]
        public int ExpireMinute { set; get; }

        /// <summary>
        /// 短信账户ID
        /// </summary>
        [Display(Name = "短信账户ID")]
        public long? SmsAccountId { set; get; }

        /// <summary>
        /// 短信账号
        /// </summary>
        public SmsAccountDto SmsAccount { set; get; }
    }
}
