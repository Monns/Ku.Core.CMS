//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//
// <copyright file="IFunctionService.cs">
//        最后生成时间：2017-08-03 12:01
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Vino.Core.Cache;
using Vino.Core.CMS.Data.Common;
using Vino.Core.CMS.Data.Repository.System;

namespace Vino.Core.CMS.Service.System
{
    public partial interface IFunctionService
    {
    }

    public partial class FunctionService : BaseService, IFunctionService
    {
        protected readonly IFunctionRepository _repository;

        public FunctionService(VinoDbContext context, ICacheService cache, IMapper mapper, IFunctionRepository repository)
            : base(context, cache, mapper)
        {
            this._repository = repository;
        }
    }
}
