﻿using System;

namespace MasterChef.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public ExceptionItemInfo ExceptionItemInfo { get; set; }
        public DomainException(string model, string reference, string message) : this(new ExceptionItemInfo(model, reference, message))
        {

        }
        public DomainException(ExceptionItemInfo exceptionItemInfo) : base(exceptionItemInfo.Message)
        {
            this.ExceptionItemInfo = exceptionItemInfo;
        }
    }
}
