//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//
// <copyright file="IFunctionRepository.cs">
//        最后生成时间：2017-08-03 13:54
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Vino.Core.CMS.Core.Data;
using Vino.Core.CMS.Data.Common;
using Vino.Core.CMS.Domain.Entity.System;

namespace Vino.Core.CMS.Data.Repository.System
{
    /// <summary>
    /// 功能 仓储接口
    /// </summary>
    public partial interface IFunctionRepository : IRepository<Function>
    {
    }

    /// <summary>
    /// 功能 仓储接口实现
    /// </summary>
    public partial class FunctionRepository : BaseRepository<Function>, IFunctionRepository
    {
        public FunctionRepository(VinoDbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
