﻿//----------------------------------------------------------------
// Copyright (C) 2018 kulend 版权所有
//
// 文件名：MemberTypeDto.cs
// 功能描述：会员类型 数据传输类
//
// 创建者：kulend@qq.com
// 创建时间：2018-02-04 19:13
//
//----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ku.Core.CMS.Domain.Dto.Membership
{
    /// <summary>
    /// 会员类型
    /// </summary>
    public class MemberTypeDto : BaseProtectedDto
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required, MaxLength(20)]
        [Display(Name = "名称")]
        public string Name { set; get; }

        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name = "排序")]
        public int OrderIndex { set; get; }
    }
}
