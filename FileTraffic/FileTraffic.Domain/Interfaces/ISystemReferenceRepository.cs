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
        Task<IEnumerable<SystemReference>> GetCategories();
        Task<SystemReference> GetById(int? id);

        Task<SystemReference> Create(SystemReference sys);
        Task<SystemReference> Update(SystemReference sys);
        Task<SystemReference> Remove(SystemReference sys);
    }
}
