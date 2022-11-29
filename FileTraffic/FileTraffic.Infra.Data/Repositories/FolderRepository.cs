using FileTraffic.Domain.Entity;
using FileTraffic.Domain.Interfaces;
using FileTraffic.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Infra.Data.Repositories
{
    public class FolderRepository : IFolderRepository
    {
        private readonly ApplicationDbContext _context;
        public FolderRepository(ApplicationDbContext context)
        {
            _context= context;
        }
        public async Task<Folder> Create(Folder folder)
        {
            _context.Folders.Add(folder);
            await _context.SaveChangesAsync();
            return folder;
        }

        public async Task<Folder> GetById(int? id)
        {
            var folder = await _context.Folders.FindAsync(id);
            return folder;
        }

        public async Task<IEnumerable<Folder>> GetFolders()
        {
            return await _context.Folders.ToListAsync();
        }

        public async Task<IEnumerable<Folder>> GetFoldersIncludingFiles()
        {
            return await _context.Folders.Include(x => x.Archives).ToListAsync();
        }

        public async Task<Folder> Remove(Folder sys)
        {
            _context.Folders.Remove(sys);
            await _context.SaveChangesAsync();
            return sys;
        }

        public async Task<Folder> Update(Folder folder)
        {
            _context.Folders.Update(folder);
            await _context.SaveChangesAsync();
            return folder;
        }
    }
}
