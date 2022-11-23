using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Domain.Entity
{
    public class Entity
    {
        protected int Id { get; set; }
        protected DateTime UpdateDate { get; set; }
        protected DateTime CreateDate { get; set; }
        protected string? UserUpdater { get; set; }
        protected string UserCreater { get; set; }
    }
}
