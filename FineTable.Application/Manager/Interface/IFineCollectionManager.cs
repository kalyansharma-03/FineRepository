using FineTable.Application.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Application.Manager.Interface
{
    public interface IFineCollectionManager
    {
        Task<bool> AddFineCollection(FineCollectionRequest fineCollectionRequest);
    }
}
