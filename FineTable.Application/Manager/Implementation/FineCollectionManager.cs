using FineTable.Application.DTO.Request;
using FineTable.Application.Manager.Interface;
using FineTable.Domain.Entities;
using FineTable.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Application.Manager.Implementation
{
    public class FineCollectionManager : IFineCollectionManager
    {
        private readonly IFineCollectionService _service;
        private readonly IFineService _serviceFine;
        public FineCollectionManager(IFineCollectionService fineCollectionService, IFineService serviceFine)
        {
            _service = fineCollectionService;
            _serviceFine = serviceFine;
        }

        public async Task<bool> AddFineCollection(FineCollectionRequest fineCollectionRequest)
        {
            try {
                var parse = new EFineCollection()
                {
                    Amount = fineCollectionRequest.Amount,
                    CreatedDate = fineCollectionRequest.CreatedDate,
                    Days = fineCollectionRequest.Days,
                    MemberID = fineCollectionRequest.MemberID,  
                    ReturnDate = fineCollectionRequest.ReturnDate,  
                    MemberType = fineCollectionRequest.MemberType,
                };
                var FineAll = await _serviceFine.GetFine();
                var rate= FineAll.Where(x=>x.MemberType == parse.MemberType).Select(x => x.Amount).FirstOrDefault();


                var result = await _service.AddFineCollection(parse);
                return true;
            }
            catch(Exception ex) { throw; }
        }
    }
}
