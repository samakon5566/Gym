using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class CourseCategory
    {
        public CourseCategory()
        {
            CourseDetails = new HashSet<CourseDetail>();
            FitnessVideos = new HashSet<FitnessVideo>();
            Skills = new HashSet<Skill>();
        }

        public int CourseCategoryId { get; set; }
        public string CourseCategoryName { get; set; }

        public virtual ICollection<CourseDetail> CourseDetails { get; set; }
        public virtual ICollection<FitnessVideo> FitnessVideos { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
