using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Domain.Entities
{
    public class EFine
    {
        public int Id { get; set; }
        public MemberTypes MemberType { get; set; }
        public int Amount { get; set; }

    }
}
