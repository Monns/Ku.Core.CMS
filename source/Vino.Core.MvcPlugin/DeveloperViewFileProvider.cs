﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.FileProviders.Physical;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ku.Core.MvcPlugin
{
    public class DeveloperViewFileProvider : IFileProvider
    {
        public DeveloperViewFileProvider(IHostingEnvironment hostingEnvironment)
        {
            HostingEnvironment = hostingEnvironment;
        }
        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            return null;
        }
        public IHostingEnvironment HostingEnvironment { get; }

        public IFileInfo GetFileInfo(string subpath)
        {
            if (subpath.StartsWith("/Porject.RootPath/"))
            {
                var parent = new DirectoryInfo(HostingEnvironment.ContentRootPath).Parent;
                var file = Path.Combine(parent.FullName, subpath.Replace("/Porject.RootPath/", "").Replace("/", "\\"));
                if (File.Exists(file))
                {
                    return new PhysicalFileInfo(new FileInfo(file));
                }
            }
            return null;
        }

        public IChangeToken Watch(string filter)
        {
            if (filter.StartsWith("/Porject.RootPath/"))
            {
                var parent = new DirectoryInfo(HostingEnvironment.ContentRootPath).Parent;
                var file = Path.Combine(parent.FullName, filter.Replace("/Porject.RootPath/", "").Replace("/", "\\"));
                if (File.Exists(file))
                {
                    return new PollingFileChangeToken(new FileInfo(file));
                }
            }
            return null;
        }
    }
}
