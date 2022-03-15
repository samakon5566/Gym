using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class CourseDetail
    {
        public CourseDetail()
        {
            CourseClasses = new HashSet<CourseClass>();
        }

        public int CourseDetailId { get; set; }
        public string CourseDetailName { get; set; }
        public string CourseDetailIntroduce { get; set; }
        public int? CourseDetailTime { get; set; }
        public int? CourseDetailCal { get; set; }
        public int? CourseDetailMoney { get; set; }
        public string CourseDetailPicture { get; set; }
        public int CourseCategoryId { get; set; }

        public virtual CourseCategory CourseCategory { get; set; }
        public virtual ICollection<CourseClass> CourseClasses { get; set; }
    }
}
