using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class DiscountPlan
    {
        public DiscountPlan()
        {
            CourseClasses = new HashSet<CourseClass>();
        }

        public int DiscountPlanId { get; set; }
        public int DicountId { get; set; }
        public string DiscountPlan1 { get; set; }

        public virtual Dicount Dicount { get; set; }
        public virtual ICollection<CourseClass> CourseClasses { get; set; }
    }
}
