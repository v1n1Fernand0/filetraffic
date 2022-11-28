using FileTraffic.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Domain.Interfaces
{
    public interface IFolderRepository
    {
        Task<IEnumerable<Folder>> GetCategories();
        Task<Folder> GetById(int? id);

        Task<Folder> Create(Folder folder);
        Task<Folder> Update(Folder folder);
        Task<Folder> Remove(Folder folder);
    }
}
