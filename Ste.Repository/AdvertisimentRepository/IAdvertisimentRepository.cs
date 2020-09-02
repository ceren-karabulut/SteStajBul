using Ste.Data.Entities;
using Ste.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Repository.AdvertisimentRepository
{
  public interface IAdvertisimentRepository : IBaseRepository<Advertisiment>
    {
        Task<IEnumerable<Advertisiment>> GetAdvertisimentsBySearch(string city, string key);

        //will refactor
        Task<IEnumerable<Advertisiment>> GetAdvertisimentsByUser(CompanyUser user);

        Task<Advertisiment> GetAdvertisimentById(int id);

        Task<IEnumerable<Advertisiment>> GetAdvertisimentByKey(string key);

        Task<IEnumerable<Advertisiment>> GetAllRel();

        
    }
}
