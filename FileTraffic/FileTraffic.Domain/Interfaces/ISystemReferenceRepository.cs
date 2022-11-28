using FileTraffic.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Domain.Interfaces
{
    public interface ISystemReferenceRepository
    {
        Task<IEnumerable<Folder>> GetCategories();
        Task<Folder> GetById(int? id);

        Task<Folder> Create(Folder sys);
        Task<Folder> Update(Folder sys);
        Task<Folder> Remove(Folder sys);
    }
}
