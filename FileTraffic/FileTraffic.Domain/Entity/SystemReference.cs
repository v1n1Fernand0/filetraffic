using FileTraffic.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Domain.Entity
{
    public class SystemReference:Entity
    {
        public SystemReference(string name)
        {
            ValidateDomain(name);
        }

        public SystemReference(int id,string name)
        {
            DomainExceptionValidation.When(id <= 0,"Invalid Id. id is required");
            Id = id;
            ValidateDomain(name);
        }

        public string Name { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),"Invalid Name. name is required");
            Name = name;
        }
    }
}
