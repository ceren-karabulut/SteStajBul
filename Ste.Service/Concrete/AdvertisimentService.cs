using Ste.Data.Entities;
using Ste.Service.Abstract;
using Ste.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ste.Service.Concrete
{
   public class AdvertisimentService : IAdvertisimentService
    {
        private IUnit _unit;
        public AdvertisimentService(IUnit unit)
        {
            _unit = unit;
        }

        public async Task<int> CreateAdvertisiment(Advertisiment advertisiment)
        {
           return  await _unit.Advertisiments.InsertAsync(advertisiment);
        }


        public async Task DeleteAdvertisiment(int id)
        {
            await _unit.Advertisiments.DeleteAsync(id);
        }

      

        public async Task<IEnumerable<Advertisiment>> GetAdvertisimentsBySearch( string key)
        {
            return await _unit.Advertisiments.GetAdvertisimentByKey(key);
        }

        public async Task<IEnumerable<Advertisiment>> GetAdvertisimentsOffUser(CompanyUser user)
        {
            return await _unit.Advertisiments.GetAdvertisimentsByUser(user);
        }

        public async Task<IEnumerable<Advertisiment>> GetAllAds()
        {
            return await _unit.Advertisiments.GetAllRel();
        }

        public async Task<IEnumerable<Advertisiment>> GetAllAdvertisiments()
        {
            return await _unit.Advertisiments.GetAllAsync();
        }

       

        public async Task<Advertisiment> GetById(int id)
        {
            return await _unit.Advertisiments.GetAdvertisimentById(id);
        }

        public async Task<int> UpdateAdvertisiment(Advertisiment advertisiment)
        {
          return  await _unit.Advertisiments.UpdateAsync(advertisiment);
        }

        
    }
}
