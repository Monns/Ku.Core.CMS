//----------------------------------------------------------------
// Copyright (C) 2018 vino 版权所有
//
// 文件名：WxUserTagRepository.cs
// 功能描述：微信用户标签 数据访问
//
// 创建者：kulend@qq.com
// 创建时间：2018-02-04 19:13
// 说明：此代码由工具自动生成，对此文件的更改可能会导致不正确的行为，
// 并且如果重新生成代码，这些更改将会丢失。
//
//----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Ku.Core.CMS.Data.Common;
using Ku.Core.CMS.Domain.Entity.WeChat;

namespace Ku.Core.CMS.Data.Repository.WeChat
{
    /// <summary>
    /// 微信用户标签 仓储接口
    /// </summary>
    public partial interface IWxUserTagRepository : IRepository<WxUserTag>
    {
    }

    /// <summary>
    /// 微信用户标签 仓储接口实现
    /// </summary>
    public partial class WxUserTagRepository : BaseRepository<WxUserTag>, IWxUserTagRepository
    {
        public WxUserTagRepository(VinoDbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
