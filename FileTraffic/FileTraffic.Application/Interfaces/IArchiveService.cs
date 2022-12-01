using FileTraffic.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Application.Interfaces
{
    public interface IArchiveService
    {
        Task<IEnumerable<ArchiveDTO>> GetArchives();
        Task<ArchiveDTO> GetArchiveById(int? id);
        Task Add(ArchiveDTO categoryDto);
        Task Update(ArchiveDTO categoryDto);
        Task Remove(int? id);
    }
}
