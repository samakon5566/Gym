using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class CourseClass
    {
        public CourseClass()
        {
            Lessons = new HashSet<Lesson>();
            MemberScores = new HashSet<MemberScore>();
            OrderCourses = new HashSet<OrderCourse>();
        }

        public int CourseClassId { get; set; }
        public int CourseClassDetailId { get; set; }
        public string CourseClassName { get; set; }
        public int CourseClassCoachId { get; set; }
        public int CourseClassPeople { get; set; }
        public int CourseClassClassroomId { get; set; }
        public int? CourseClassPlanId { get; set; }

        public virtual Classroom CourseClassClassroom { get; set; }
        public virtual Coach CourseClassCoach { get; set; }
        public virtual CourseDetail CourseClassDetail { get; set; }
        public virtual DiscountPlan CourseClassPlan { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<MemberScore> MemberScores { get; set; }
        public virtual ICollection<OrderCourse> OrderCourses { get; set; }
    }
}
