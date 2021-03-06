﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ku.Core.Infrastructure.DependencyResolver
{
    public interface IIocResolver
    {
        T Resolve<T>();

        IEnumerable<T> ResolveAll<T>();

        bool IsRegister<T>();

        T Resolve<T>(IDictionary<string, object> withParameters);
    }
}
