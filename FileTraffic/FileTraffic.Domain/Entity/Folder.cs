using FileTraffic.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Domain.Entity
{
    public class Folder:Entity
    {
        public Folder(string name)
        {
            ValidateDomain(name);
        }

        public Folder(int id,string name)
        {
            DomainExceptionValidation.When(id <= 0,"Invalid Id. id is required");
            Id = id;
            ValidateDomain(name);
        }

        public string? Name { get; set; }
        public string Key { get; set; }
        public IEnumerable<Archive> Archives { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),"Invalid Name. name is required");
            Name = name;
        }
    }
}
