﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Domain.Validation
{
    public class DomainExceptionValidation:Exception
    {
        public DomainExceptionValidation(string error) : base(error)
        { }

        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new DomainExceptionValidation(error);
        }

        public static void When(bool hasError, string propretyName, string? error)
        {
            if (hasError && !string.IsNullOrEmpty(error))
                throw new DomainExceptionValidation(error);
            else 
                throw new DomainExceptionValidation($"Invalid {propretyName.ToLower()}. {propretyName} is required");
        }
    }
}