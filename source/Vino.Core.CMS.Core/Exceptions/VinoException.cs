﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vino.Core.CMS.Core.Exceptions
{
    public class VinoException : System.Exception
    {
        public new string Message { set; get; }
        public int Code { set; get; }
        public new object Data { set; get; }

        public VinoException()
            : base()
        {

        }

        public VinoException(string message)
            : base(message)
        {
            this.Code = 99;
            this.Message = message;
        }

        public VinoException(int code, string message)
            : base(message)
        {
            this.Code = code;
            this.Message = message;
        }

        public VinoException(int code, string message, object data)
            : base(message)
        {
            this.Code = code;
            this.Message = message;
            this.Data = data;
        }
    }

    public class VinoArgNullException : VinoException
    {
        public VinoArgNullException()
            : base(902, "参数出错")
        {

        }

        public VinoArgNullException(string msg)
            : base(902, msg)
        {
        }

        public VinoArgNullException(string msg, object data)
            : base(902, msg, data)
        {
        }
    }
}
