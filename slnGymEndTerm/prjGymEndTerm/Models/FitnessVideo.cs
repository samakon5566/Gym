using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class FitnessVideo
    {
        public int FitnessVideoId { get; set; }
        public string FitnessVideoTitle { get; set; }
        public string FitnessVideoContent { get; set; }
        public string FitnessVideoUrl { get; set; }
        public DateTime FitnessVideoTime { get; set; }
        public int FitnessVideoCoachId { get; set; }
        public int FitnessVideoCourseCategoryId { get; set; }
        public virtual Coach FitnessVideoCoach { get; set; }
        public virtual CourseCategory FitnessVideoCourseCategory { get; set; }
    }
}
