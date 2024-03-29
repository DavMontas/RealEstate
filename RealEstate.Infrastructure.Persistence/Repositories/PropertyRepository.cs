﻿using RealEstate.Core.Application.Interfaces.Repositories;
using RealEstate.Core.Domain.Entities;
using RealEstate.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastructure.Persistence.Repositories
{
    public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
    {
        private readonly AppDbContext _db;
        public PropertyRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Property> GetAll()
        {
            return _db.Set<Property>().ToList();
        }

        public async Task<Property> GetByCodeAsync(string Code)
        {
            return await _db.Set<Property>().FindAsync(Code);
        }

        public async Task<Property> GetByNameAsync(string Name)
        {
            return await _db.Set<Property>().FindAsync(Name);
        }
    }
}
