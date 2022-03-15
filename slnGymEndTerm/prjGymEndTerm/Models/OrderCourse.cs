using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class OrderCourse
    {
        public OrderCourse()
        {
            PostureChanges = new HashSet<PostureChange>();
        }

        public int OrderId { get; set; }
        public int OrderMemberId { get; set; }
        public int? OrderStatusId { get; set; }
        public int? OrderReasonId { get; set; }
        public int OrderClassId { get; set; }
        public int OrderPaymentId { get; set; }
        public string OrderReasonMoney { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime? OrderReviseTime { get; set; }

        public virtual CourseClass OrderClass { get; set; }
        public virtual LogIn OrderMember { get; set; }
        public virtual Payment OrderPayment { get; set; }
        public virtual RefundReason OrderReason { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual ICollection<PostureChange> PostureChanges { get; set; }
    }
}
