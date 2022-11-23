﻿using FileTraffic.Domain.Entity;
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
    public class SystemReferenceRepository : ISystemReferenceRepository
    {
        private readonly ApplicationDbContext _context;
        public SystemReferenceRepository(ApplicationDbContext context)
        {
            _context= context;
        }
        public async Task<SystemReference> Create(SystemReference sys)
        {
            _context.Systems.Add(sys);
            await _context.SaveChangesAsync();
            return sys;
        }

        public async Task<SystemReference> GetById(int? id)
        {
            var sys = await _context.Systems.FindAsync(id);
            return sys;
        }

        public async Task<IEnumerable<SystemReference>> GetCategories()
        {
            return await _context.Systems.ToListAsync();
        }

        public async Task<SystemReference> Remove(SystemReference sys)
        {
            _context.Systems.Remove(sys);
            await _context.SaveChangesAsync();
            return sys;
        }

        public async Task<SystemReference> Update(SystemReference sys)
        {
            _context.Systems.Update(sys);
            await _context.SaveChangesAsync();
            return sys;
        }
    }
}