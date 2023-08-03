using FineTable.Application.DTO.Request;
using FineTable.Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FineTable.Infrastructure.Service.Common;

namespace FineTable.Application.Manager.Interface
{
    public interface IFineManager
    {
        Task<ServiceResult<List<FineResponse>>> GetFine();
        Task<ServiceResult<FineResponse>> GetFineById(int id);
        Task<ServiceResult<bool>> UpdateFineStatus(FineRequest fine);
    }
}
