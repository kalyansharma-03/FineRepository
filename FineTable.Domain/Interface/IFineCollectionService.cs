using FineTable.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Domain.Interface
{
    public  interface IFineCollectionService
    {
        Task<bool> AddFineCollection(EFineCollection eFineCollection);
        Task<List<EFineCollection>> GetFineCollections();
        Task<EFineCollection> GetFineCollectionById(EFineCollection eFineCollection);
        Task<bool> UpdateFineCollection(EFineCollection eFineCollection);
        Task<bool> DeleteFineCollection(int id);

    }
}
