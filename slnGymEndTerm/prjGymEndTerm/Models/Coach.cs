using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class Coach
    {
        public Coach()
        {
            CourseClasses = new HashSet<CourseClass>();
            FitnessVideos = new HashSet<FitnessVideo>();
            Skills = new HashSet<Skill>();
        }

        public int CoachId { get; set; }
        public string CoachAddress { get; set; }
        public int? CoachExperience { get; set; }
        public string CoachBackground { get; set; }

        public virtual LogIn CoachNavigation { get; set; }
        public virtual ICollection<CourseClass> CourseClasses { get; set; }
        public virtual ICollection<FitnessVideo> FitnessVideos { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
