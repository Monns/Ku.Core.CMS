﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Ku.Core.CMS.Domain.Entity.System;

namespace Ku.Core.CMS.Domain.Entity.Material
{
    public class Material : BaseProtectedEntity
    {
        /// <summary>
        /// 标题
        /// </summary>
        [MaxLength(128)]
        public string Title { set; get; }

        /// <summary>
        /// 文件名
        /// </summary>
        [MaxLength(128)]
        public string FileName { set; get; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [MaxLength(20)]
        public string FileType { set; get; }

        /// <summary>
        /// MD5码
        /// </summary>
        [MaxLength(32)]
        public string Md5Code { set; get; }

        /// <summary>
        /// 文件大小
        /// </summary>
        public long FileSize { set; get; }

        /// <summary>
        /// 上传用户ID
        /// </summary>
        public long UploadUserId { set; get; }

        /// <summary>
        /// 上传用户
        /// </summary>
        public User UploadUser { set; get; }

        [MaxLength(256)]
        public string FilePath { set; get; }

        [MaxLength(256)]
        public string Folder { set; get; }

        /// <summary>
        /// 是否公开
        /// </summary>
        public bool IsPublic { set; get; } = false;

        /// <summary>
        /// 分组ID
        /// </summary>
        public long? GroupId { set; get; }

        /// <summary>
        /// 分组
        /// </summary>
        public MaterialGroup Group { set; get; }
    }
}
