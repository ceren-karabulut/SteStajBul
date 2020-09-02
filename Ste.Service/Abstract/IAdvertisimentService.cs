using Ste.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Service.Abstract
{
   public interface IAdvertisimentService
    {
        Task<IEnumerable<Advertisiment>> GetAllAdvertisiments();

        Task<IEnumerable<Advertisiment>> GetAdvertisimentsBySearch(  string key );

        Task<Advertisiment> GetById(int id);

        Task<IEnumerable<Advertisiment>> GetAdvertisimentsOffUser (CompanyUser user);

        Task<int> CreateAdvertisiment(Advertisiment advertisiment);

        Task <int> UpdateAdvertisiment(Advertisiment advertisiment);

        Task DeleteAdvertisiment(int id);

        Task<IEnumerable<Advertisiment>> GetAllAds();

        
        
        
    }
}
