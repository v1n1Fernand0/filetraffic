using FileTraffic.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Domain.Interfaces
{
    public interface IArchiveRepository
    {
        Task<IEnumerable<Archive>> GetCategories();
        Task<Archive> GetById(int? id);

        Task<Archive> Create(Archive archive);
        Task<Archive> Update(Archive archive);
        Task<Archive> Remove(Archive archive);
    }
}
