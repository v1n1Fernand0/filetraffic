using FileTraffic.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Application.Interfaces
{
    public interface IFolderService
    {
        Task<IEnumerable<FolderDTO>> GetFolder();
        Task<FolderDTO> GetFolderById(int? id);
        Task Add(FolderDTO sysDto);
        Task Update(FolderDTO sysDto);
        Task Remove(int? id);
    }
}
