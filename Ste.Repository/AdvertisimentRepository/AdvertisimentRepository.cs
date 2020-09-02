using Microsoft.EntityFrameworkCore;
using Ste.Data.Context;
using Ste.Data.Entities;
using Ste.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Repository.AdvertisimentRepository
{
  public  class AdvertisimentRepository : BaseRepository<Advertisiment> , IAdvertisimentRepository 
    {
        private readonly ApplicationDbContext _context;
        public AdvertisimentRepository(ApplicationDbContext context) : base(context)
        {
            _context=context;
        }


        public async Task<Advertisiment> GetAdvertisimentById(int id)
        {
            return await _context.Set<Advertisiment>()
                .Include(x => x.CompanyUser)
                .AsTracking()
                .FirstOrDefaultAsync(x => x.AdvertisimentId == id);
        }

        //singular search bar
        public async Task<IEnumerable<Advertisiment>> GetAdvertisimentByKey(string key)
        {
            if(key != null)
            {
                return await _context.Advertisiments
                    .Include(x => x.CompanyUser)
                    .Where(x=> x.JobDesc.ToLower().Contains(key.ToLower()) || x.City.ToLower().Contains(key.ToLower()))
                    .OrderByDescending(x => x.CreateDate)
                    .AsNoTracking()
                    .ToListAsync();
            }
            else{

                return await _context.Advertisiments
                    .Include(x=>x.CompanyUser)
                   .OrderByDescending(x => x.CreateDate)
                   .ToListAsync();
            }
        }

        public async Task<IEnumerable<Advertisiment>> GetAdvertisimentsBySearch(string city, string key)
        {
            if (city != null && key != null)
            {
                return await _context.Advertisiments
                    .Where(x => x.City.ToLower().Contains(city.ToLower()))
                    .Where(x => x.JobTitle.ToLower().Contains(key.ToLower()) || x.JobDesc.ToLower().Contains(key.ToLower()))
                    .Include(x => x.CompanyUser)
                    .AsNoTracking()
                    .OrderByDescending(x => x.CreateDate)
                    .ToListAsync();
            }

            else if (city != null || key == null)
            {
                return await _context.Advertisiments
                    .Where(x => x.City.ToLower().Contains(city.ToLower()))
                    .Include(x => x.CompanyUser)
                    .AsNoTracking()
                    .OrderByDescending(x => x.CreateDate)
                    .ToListAsync();
            }

            else if (city == null || key != null)
            {
                return await _context.Advertisiments
                    .Where(x => x.JobTitle.ToLower().Contains(key.ToLower()) || x.JobDesc.ToLower().Contains(key.ToLower()))
                    .OrderByDescending(x => x.CreateDate)
                    .Include(x => x.CompanyUser)
                    .AsNoTracking()
                    .ToListAsync();
            }
            else
            {
                return await _context.Advertisiments
                    .OrderByDescending(x => x.CreateDate)
                    .Include(x => x.CompanyUser)
                    .AsNoTracking()
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<Advertisiment>> GetAdvertisimentsByUser(CompanyUser user)
        {
            var data = await _context.Advertisiments
                 .Include(x => x.CompanyUser)
                 .Where(x => x.CompanyId == user.Id)
                 .ToListAsync();

            return data;
        }

        public async Task<IEnumerable<Advertisiment>> GetAllRel()
        {
            var entities = _context.Set<Advertisiment>()
                .Include(x => x.CompanyUser)
                .AsNoTracking()
                .ToListAsync();

            return await entities;
        }

       
    }
}
