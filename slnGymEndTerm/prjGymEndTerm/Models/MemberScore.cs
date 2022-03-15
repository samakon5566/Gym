using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class MemberScore
    {
        public int ScoreId { get; set; }
        public int MemberId { get; set; }
        public int CourseClassId { get; set; }
        public string Classcomment { get; set; }
        public int ClassScore { get; set; }
        public DateTime? ClassRecord { get; set; }

        public virtual CourseClass CourseClass { get; set; }
        public virtual LogIn Member { get; set; }
    }
}
