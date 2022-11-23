﻿using FileTraffic.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Domain.Entity
{
    public class Archive:Entity
    {
        public Archive(string name, long size, string extension)
        {
            ValidateDomain(name,size,extension);
        }

        public Archive(int id, string name, long size, string extension)
        {
            DomainExceptionValidation.When(id <= 0,"Invalid Id. Id is required");
            Id = id;
            ValidateDomain(name, size, extension);
        }


        public string Name { get; set; }
        public long Size { get; set; }
        public string Extension { get; set; }
        public SystemReference System { get; set; }

        private void ValidateDomain(string name, long size, string extension)
        {
            // verificar um tamanho de arquivo máximo para validar posteriormente?
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid Name. name is required");
            DomainExceptionValidation.When(size <= 0, "Invalid Size. size is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(extension),"Invalid Extension. extension is required");

            Name= name;
            Size= size;
            Extension= extension;
        }

    }
}
