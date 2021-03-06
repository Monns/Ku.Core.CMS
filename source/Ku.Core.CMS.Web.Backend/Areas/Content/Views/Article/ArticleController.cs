﻿//----------------------------------------------------------------
// Copyright (C) 2018 vino 版权所有
//
// 文件名：ArticleController.cs
// 功能描述：文章 后台访问控制类
//
// 创建者：kulend@qq.com
// 创建时间：2018-02-04 19:13
//
//----------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ku.Core.CMS.Domain.Dto.Content;
using Ku.Core.CMS.Domain.Entity.Content;
using Ku.Core.CMS.IService.Content;
using Ku.Core.CMS.Web.Base;
using Ku.Core.CMS.Web.Filters;
using Ku.Core.CMS.Web.Security;
using Ku.Core.Infrastructure.Exceptions;

namespace Ku.Core.CMS.Web.Backend.Areas.Content.Views.Article
{
    /// <summary>
    /// 文章 后台访问控制类
    /// </summary>
    [Area("Content")]
    [Auth("content.article")]
    public class ArticleController : BackendController
    {
        private readonly IArticleService _service;

        public ArticleController(IArticleService service)
        {
            this._service = service;
        }

        /// <summary>
        /// 列表页
        /// </summary>
        /// <returns></returns>
        [Auth("view")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        /// <summary>
        /// 取得列表数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        [Auth("view")]
        public async Task<IActionResult> GetList(int page, int rows, ArticleSearch where)
        {
            var data = await _service.GetListAsync(page, rows, where, null);
            return PagerData(data.items, page, rows, data.count);
        }

        /// <summary>
        /// 新增编辑页
        /// </summary>
        /// <param name="id"></param>
        [Auth("edit")]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id.HasValue)
            {
                //编辑
                var model = await _service.GetByIdAsync(id.Value);
                if (model == null)
                {
                    throw new VinoDataNotFoundException("无法取得数据!");
                }
                ViewData["Mode"] = "Edit";
                return View(model);
            }
            else
            {
                //新增
                ArticleDto dto = new ArticleDto();
                ViewData["Mode"] = "Add";
                return View(dto);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        [HttpPost]
        [Auth("edit")]
        [UserOperationAttribute("")]
        public async Task<IActionResult> Save(ArticleDto model)
        {
            await _service.SaveAsync(model);
            return JsonData(true);
        }

        /// <summary>
        /// 删除
        /// </summary>
        [HttpPost]
        [Auth("delete")]
        public async Task<IActionResult> Delete(params long[] id)
        {
            await _service.DeleteAsync(id);
            return JsonData(true);
        }

        /// <summary>
        /// 恢复
        /// </summary>
        [HttpPost]
        [Auth("restore")]
        public async Task<IActionResult> Restore(params long[] id)
        {
            await _service.RestoreAsync(id);
            return JsonData(true);
        }
    }
}
