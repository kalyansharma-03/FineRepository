using FineTable.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Application.DTO.Response
{
    public class FineResponse
    {
        public int Id { get; set; }
        public MemberType MemberType { get; set; }
        public int Amount { get; set; }
    }
}
