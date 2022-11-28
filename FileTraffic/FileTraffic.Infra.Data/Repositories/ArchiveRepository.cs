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
    public class ArchiveRepository : IArchiveRepository
    {
        private readonly ApplicationDbContext _context;
        public ArchiveRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Archive> Create(Archive archive)
        {
            _context.Archives.Add(archive);
            await _context.SaveChangesAsync();
            return archive;
        }

        public async Task<Archive> GetById(int? id, string key)
        {
            var archive = await _context.Archives.FirstOrDefaultAsync(x => x.Folder.Key.Contains(key) && x.Id == id);
            return archive;
        }

        public async Task<IEnumerable<Archive>> GetArchives(string key)
        {
            return await _context.Archives.Where(x => x.Folder.Key.Equals(key)).ToListAsync();
        }

        public async Task<Archive> Remove(Archive archive)
        {
            _context.Archives.Remove(archive);
            await _context.SaveChangesAsync();
            return archive;
        }

        public async Task<Archive> Update(Archive archive)
        {
            _context.Archives.Update(archive);
            await _context.SaveChangesAsync();
            return archive;
        }
    }
}
