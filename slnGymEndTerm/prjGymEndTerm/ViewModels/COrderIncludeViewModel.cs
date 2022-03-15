using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class COrderIncludeViewModel
    {
        private OrderCourse _orderCourse = null;
        public OrderCourse orderCourse
        {
            get
            {
                if (_orderCourse == null)
                    _orderCourse = new OrderCourse();
                return _orderCourse;
            }
            set { _orderCourse = value; }
        }

        public int OrderId
        {
            get { return this.orderCourse.OrderId; }
            set { this.orderCourse.OrderId = value; }
        }
        [DisplayName("會員")]
        public int OrderMemberId
        {
            get { return this.orderCourse.OrderMemberId; }
            set { this.orderCourse.OrderMemberId = value; }
        }
        [DisplayName("訂單狀態")]

        public int? OrderStatusId
        {
            get { return this.orderCourse.OrderStatusId; }
            set { this.orderCourse.OrderStatusId = value; }
        }
        [DisplayName("取消原因")]

        public int? OrderReasonId
        {
            get { return this.orderCourse.OrderReasonId; }
            set { this.orderCourse.OrderReasonId = value; }
        }
        [DisplayName("班別")]

        public int OrderClassId
        {
            get { return this.orderCourse.OrderClassId; }
            set { this.orderCourse.OrderClassId = value; }
        }
        [DisplayName("付款方式")]

        public int OrderPaymentId
        {
            get { return this.orderCourse.OrderPaymentId; }
            set { this.orderCourse.OrderPaymentId = value; }
        }
        [DisplayName("退費金額")]

        public string OrderReasonMoney
        {
            get { return this.orderCourse.OrderReasonMoney; }
            set { this.orderCourse.OrderReasonMoney = value; }
        }
        [DisplayName("成立時間")]

        public DateTime OrderTime
        {
            get { return this.orderCourse.OrderTime; }
            set { this.orderCourse.OrderTime = value; }
        }
        [DisplayName("異動時間")]

        public DateTime? OrderReviseTime
        {
            get { return this.orderCourse.OrderReviseTime; }
            set { this.orderCourse.OrderReviseTime = value; }
        }

        public virtual CourseClass OrderClass { get; set; }
        public virtual LogIn OrderMember { get; set; }
        public virtual Payment OrderPayment { get; set; }
        public virtual RefundReason OrderReason { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual ICollection<PostureChange> PostureChanges { get; set; }

        [DisplayName("姓名")]
        public string LogInName
        {
            get { return this.orderCourse.OrderMember.LogInName; }
            set { this.orderCourse.OrderMember.LogInName = value; }
        }

        [DisplayName("班名")]

        public string CourseClassName
        {
            get { return this.orderCourse.OrderClass.CourseClassName; }
            set { this.orderCourse.OrderClass.CourseClassName = value; }
        }
        [DisplayName("付款方式")]

        public string PaymentName
        {
            get { return this.orderCourse.OrderPayment.PaymentName; }
            set { this.orderCourse.OrderPayment.PaymentName = value; }
        }

        [DisplayName("退款原因")]

        public string ReasonContent
        {
            get { return this.orderCourse.OrderReason.ReasonContent; }
            set { this.orderCourse.OrderReason.ReasonContent = value; }
        }
        [DisplayName("訂單狀態")]

        public string StatusContent
        {
            get { return this.orderCourse.OrderStatus.StatusContent; }
            set { this.orderCourse.OrderStatus.StatusContent = value; }
        }


        [DisplayName("課程折數")]
        public decimal DiscountPercent
        {
            get { return this.orderCourse.OrderClass.CourseClassPlan.Dicount.DiscountPercent; }
            set { this.orderCourse.OrderClass.CourseClassPlan.Dicount.DiscountPercent = value; }
        }


        [DisplayName("課程金額")]

        public int? CourseDetailMoney
        {
            get { return this.orderCourse.OrderClass.CourseClassDetail.CourseDetailMoney; }
            set { this.orderCourse.OrderClass.CourseClassDetail.CourseDetailMoney = value; }
        }
    }
}
