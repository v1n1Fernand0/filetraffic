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
        Task<IEnumerable<ArchiveDTO>> GetArchives(string folderKey);
        Task<ArchiveDTO> GetById(int? id,string folderKey);
        Task Add(ArchiveDTO categoryDto);
        Task Update(ArchiveDTO categoryDto);
        Task Remove(int? id);
    }
}
