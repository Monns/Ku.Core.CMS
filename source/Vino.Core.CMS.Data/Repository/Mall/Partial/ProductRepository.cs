//----------------------------------------------------------------
// Copyright (C) 2018 vino 版权所有
//
// 文件名：ProductRepository.cs
// 功能描述：商品 数据访问
//
// 创建者：kulend@qq.com
// 创建时间：2018-02-24 10:50
// 说明：此代码由工具自动生成，对此文件的更改可能会导致不正确的行为，
// 并且如果重新生成代码，这些更改将会丢失。
//
//----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Ku.Core.CMS.Data.Common;
using Ku.Core.CMS.Domain.Entity.Mall;

namespace Ku.Core.CMS.Data.Repository.Mall
{
    /// <summary>
    /// 商品 仓储接口
    /// </summary>
    public partial interface IProductRepository : IRepository<Product>
    {
    }

    /// <summary>
    /// 商品 仓储接口实现
    /// </summary>
    public partial class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(VinoDbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
