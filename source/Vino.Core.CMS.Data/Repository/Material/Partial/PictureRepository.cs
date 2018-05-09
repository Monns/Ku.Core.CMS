//----------------------------------------------------------------
// Copyright (C) 2018 vino 版权所有
//
// 文件名：PictureRepository.cs
// 功能描述：图片素材 数据访问
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
using Ku.Core.CMS.Domain.Entity.Material;

namespace Ku.Core.CMS.Data.Repository.Material
{
    /// <summary>
    /// 图片素材 仓储接口
    /// </summary>
    public partial interface IPictureRepository : IRepository<Picture>
    {
    }

    /// <summary>
    /// 图片素材 仓储接口实现
    /// </summary>
    public partial class PictureRepository : BaseRepository<Picture>, IPictureRepository
    {
        public PictureRepository(VinoDbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
