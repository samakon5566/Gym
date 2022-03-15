using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class Payment
    {
        public Payment()
        {
            OrderCourses = new HashSet<OrderCourse>();
        }

        public int PaymentId { get; set; }
        public string PaymentName { get; set; }

        public virtual ICollection<OrderCourse> OrderCourses { get; set; }
    }
}
