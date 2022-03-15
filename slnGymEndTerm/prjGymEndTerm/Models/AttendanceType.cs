using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class AttendanceType
    {
        public AttendanceType()
        {
            MemberLessons = new HashSet<MemberLesson>();
        }

        public int AttendanceTypeId { get; set; }
        public string AttendanceName { get; set; }

        public virtual ICollection<MemberLesson> MemberLessons { get; set; }
    }
}
