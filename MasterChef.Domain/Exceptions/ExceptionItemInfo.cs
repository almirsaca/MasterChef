﻿using MasterChef.Infra;

namespace MasterChef.Domain.Exceptions
{
    public class ExceptionItemInfo
    {
        public string Model { get; protected set; }
        public string Reference { get; protected set; }
        public string Message { get; protected set; }

        public ExceptionItemInfo(string model, string reference, string message)
        {
            Throw.IfIsNullOrWhiteSpace(model);
            Throw.IfIsNullOrWhiteSpace(reference);
            Throw.IfIsNullOrWhiteSpace(message);

            this.Model = model;
            this.Reference = reference;
            this.Message = message;
        }
    }
}
