using FineTable.Domain.Entities;
using FineTable.Domain.Interface;
using FineTable.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Infrastructure.Service
{
    public class FineCollectionService : IFineCollectionService
    {
        private readonly IServiceFactory _serviceFactory;

        public FineCollectionService(IServiceFactory serviceFactory)
        {
            try
            { 
                //var service = _serviceFactory.GetInstance<>
            } catch (Exception ex) { }
        }

        public Task<bool> CreateFineCollection(EFineCollection eFineCollection)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFineCollection(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EFineCollection> GetFineCollectionById(EFineCollection eFineCollection)
        {
            throw new NotImplementedException();
        }

        public Task<List<EFineCollection>> GetFineCollections()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFineCollection(EFineCollection eFineCollection)
        {
            throw new NotImplementedException();
        }
    }
}
