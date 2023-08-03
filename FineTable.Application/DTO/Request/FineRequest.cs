using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Application.DTO.Request
{
    public class FineRequest
    {
        public int Id { get; set; }
        public MemberTypes MemberType { get; set; }
        public int Amount { get; set; }
    }
}
