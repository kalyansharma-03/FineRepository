using FineTable.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Domain.Interface
{
    public interface IFineService
    {
        Task<List<EFine>> GetFine();
        Task<EFine> GetFineByFineId(int id);
        Task<bool> UpdateFineStatus(EFine fine);


    }
}
