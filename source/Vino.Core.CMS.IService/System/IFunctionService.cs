//----------------------------------------------------------------
// Copyright (C) 2018 vino 版权所有
//
// 文件名：IFunctionService.cs
// 功能描述：功能 业务逻辑接口类
//
// 创建者：kulend@qq.com
// 创建时间：2018-02-04 19:13
//
//----------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Ku.Core.CMS.Domain.Dto.System;
using Ku.Core.CMS.Domain.Entity.System;

namespace Ku.Core.CMS.IService.System
{
    public partial interface IFunctionService
    {
        #region 自动创建的接口

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sort">排序</param>
        /// <returns>List<FunctionDto></returns>
        Task<List<FunctionDto>> GetListAsync(FunctionSearch where, string sort);

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="size">条数</param>
        /// <param name="where">查询条件</param>
        /// <param name="sort">排序</param>
        /// <returns>count：条数；items：分页数据</returns>
        Task<(int count, List<FunctionDto> items)> GetListAsync(int page, int size, FunctionSearch where, string sort);

        /// <summary>
        /// 根据主键取得数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        Task<FunctionDto> GetByIdAsync(long id);

        /// <summary>
        /// 保存数据
        /// </summary>
        Task SaveAsync(FunctionDto dto);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        Task DeleteAsync(params long[] id);

        /// <summary>
        /// 恢复数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        Task RestoreAsync(params long[] id);

        #endregion

        #region 其他接口

        Task<List<FunctionDto>> GetParentsAsync(long parentId);

        Task<List<FunctionDto>> GetSubsAsync(long? parentId);

        Task<bool> CheckUserAuth(long userId, string authCode);

        Task<List<string>> GetUserAuthCodesAsync(long userId, bool encrypt = false);

        #endregion
    }
}
