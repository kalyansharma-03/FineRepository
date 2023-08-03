using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Domain.Enum
{
    public enum MemberType
    {
        [EnumMember(Value = "Staff")]
        Staff,
        [EnumMember(Value = "Student")]
        Student
    }
}
