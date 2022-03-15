using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class Skill
    {
        public int SkillId { get; set; }
        public int SkillCoachId { get; set; }
        public int SkillCourseCategoryId { get; set; }

        public virtual Coach SkillCoach { get; set; }
        public virtual CourseCategory SkillCourseCategory { get; set; }
    }
}
