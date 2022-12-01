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
        public Folder(string key)
        {
            ValidateDomain(key);
        }

        public Folder(int id,string key)
        {
            DomainExceptionValidation.When(id <= 0,"Invalid Id. id is required");
            Id = id;
            ValidateDomain(key);
        }

        public string Key { get; set; }
        public IEnumerable<Archive> Archives { get; set; }

        private void ValidateDomain(string key)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(key),"Invalid Key. key is required");
            Key = key;
        }
    }
}
