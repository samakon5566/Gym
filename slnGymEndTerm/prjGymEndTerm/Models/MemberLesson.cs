using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class MemberLesson
    {
        public int MemberLessonId { get; set; }
        public int MemberLessonLessonId { get; set; }
        public int MemberLessonMemberId { get; set; }
        public int? AttendanceTypeId { get; set; }
        public virtual AttendanceType AttendanceType { get; set; }
        public virtual Lesson MemberLessonLesson { get; set; }
        public virtual LogIn MemberLessonMember { get; set; }
    }
}
