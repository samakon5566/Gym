using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            OrderCourses = new HashSet<OrderCourse>();
            RefundReasons = new HashSet<RefundReason>();
        }

        public int StatusId { get; set; }
        public string StatusContent { get; set; }

        public virtual ICollection<OrderCourse> OrderCourses { get; set; }
        public virtual ICollection<RefundReason> RefundReasons { get; set; }
    }
}
