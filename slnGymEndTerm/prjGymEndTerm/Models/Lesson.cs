using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class Lesson
    {
        public Lesson()
        {
            MemberLessons = new HashSet<MemberLesson>();
        }

        public int LessonClassId { get; set; }
        public int LessonId { get; set; }
        public DateTime LessonTime { get; set; }

        public virtual CourseClass LessonClass { get; set; }
        public virtual ICollection<MemberLesson> MemberLessons { get; set; }
    }
}
