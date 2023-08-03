using FineTable.Domain.Entities;
using FineTable.Domain.Interface;
using FineTable.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Infrastructure.Service
{
    public class FineService : IFineService
    {
        private readonly IServiceFactory _factory;
        
        public FineService(IServiceFactory factory)
        {
            _factory = factory;
        }

        public async Task<List<EFine>> GetFine()
        {
            try 
            {
                var service = _factory.GetInstance<EFine>();
                var result = await service.ListAsync();
                return result;
            }
            catch(Exception ex) { throw ex; }
        }

        public async Task<EFine> GetFineByFineId(int id)
        {
            try
            {
                var service = _factory.GetInstance<EFine>();
                var result = await service.FindAsync(id);
                if(result == null)
                {
                    return null;
                }
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateFineStatus(EFine fine)
        {
            try
            {
                var service = _factory.GetInstance<EFine>();
                var user = await service.FindAsync(fine.Id);
                if (user != null)
                {
                    user.MemberType = fine.MemberType;
                    user.Amount = fine.Amount;
                    await service.UpdateAsync(user);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
