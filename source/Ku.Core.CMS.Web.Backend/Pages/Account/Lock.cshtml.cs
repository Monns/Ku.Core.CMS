﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ku.Core.Cache;
using Ku.Core.CMS.Domain;
using Ku.Core.CMS.IService.System;
using Ku.Core.CMS.Web.Base;
using Ku.Core.CMS.Web.Extensions;
using Ku.Core.CMS.Web.Filters;
using Ku.Core.CMS.Web.Security;
using Ku.Core.Infrastructure.Exceptions;
using Ku.Core.Tokens.Jwt;

namespace Ku.Core.CMS.Web.Backend.Pages.Account
{
    [Auth]
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class LockModel : BasePage
    {
        private IUserService _userService;
        private ICacheService _cacheService;
        private IJwtProvider _jwtProvider;

        public LockModel(IUserService userService, ICacheService cacheService, IJwtProvider jwtProvider)
        {
            this._userService = userService;
            this._cacheService = cacheService;
            this._jwtProvider = jwtProvider;
        }

        [IgnorePageLock]
        public void OnGet()
        {
            ViewData["ReturnUrl"] = WebUtility.UrlDecode(Request.Query["ReturnUrl"]);
        }

        /// <summary>
        /// 页面加锁
        /// </summary>
        public IActionResult OnPost()
        {
            //缓存中添加页面锁定消息
            var tokenId = User.GetTokenIdOrNull();
            _cacheService.Add(string.Format(CacheKeyDefinition.PageLock, tokenId), true, TimeSpan.FromMinutes(_jwtProvider.GetJwtConfig().ExpiredMinutes));
            return Json(true);
        }

        /// <summary>
        /// 页面解锁
        /// </summary>
        [IgnorePageLock]
        public async Task<IActionResult> OnDeleteAsync([FromForm]string Password)
        {
            var userId = User.GetUserIdOrZero();
            if (!await _userService.PasswordCheckAsync(userId, Password))
            {
                throw new VinoException("解锁密码不正确！");
            }

            //缓存中去除页面锁定消息
            var tokenId = User.GetTokenIdOrNull();
            _cacheService.Remove(string.Format(CacheKeyDefinition.PageLock, tokenId));

            return Json(true);
        }
    }
}