using FileTraffic.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Application.Interfaces
{
    public interface ISystemReferenceService
    {
        Task<IEnumerable<SystemReferenceDTO>> GetSystemReferences();
        Task<SystemReferenceDTO> GetById(int? id);
        Task Add(SystemReferenceDTO sysDto);
        Task Update(SystemReferenceDTO sysDto);
        Task Remove(int? id);
    }
}
