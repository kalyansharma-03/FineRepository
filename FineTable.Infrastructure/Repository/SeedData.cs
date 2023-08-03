using FineTable.Domain.Entities;
using FineTable.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Infrastructure.Repository
{
    public static class SeedData
    {
        public static List<EFine> GetInitialEFineData()
        {
            var initialData = new List<EFine>
            {
                new EFine { Id = 1,MemberType=MemberType.Staff, Amount = 50},
                new EFine { Id = 2,MemberType=MemberType.Student, Amount = 10},

            };
            return initialData;
        }
    }
}
