using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class RefundReason
    {
        public RefundReason()
        {
            OrderCourses = new HashSet<OrderCourse>();
        }

        public int ReasonId { get; set; }
        public string ReasonContent { get; set; }
        public int StatusId { get; set; }

        public virtual OrderStatus Status { get; set; }
        public virtual ICollection<OrderCourse> OrderCourses { get; set; }
    }
}
