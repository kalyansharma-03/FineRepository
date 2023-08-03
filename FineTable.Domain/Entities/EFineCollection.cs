using FineTable.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Domain.Entities
{
    public class EFineCollection
    {
        [Key]
        public int Id { get; set; }
        public int MemberID { get; set; }
        public int Amount { get; set; }
        public int Days { get; set; }
        public MemberType MemberType { get; set; }
        public DateTime CreatedDate {get; set;}
        public DateTime ReturnDate{get; set;}
        
    }
}
