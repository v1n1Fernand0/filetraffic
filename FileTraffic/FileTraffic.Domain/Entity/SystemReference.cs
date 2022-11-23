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
            Name = name;
        }

        public SystemReference(int id,string name)
        {
            DomainExceptionValidation.When(id <= 0,"Id",null);
            Id = id;
            Name = name;
        }

        public string Name { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),"Name",null);
            Name = name;
        }
    }
}
