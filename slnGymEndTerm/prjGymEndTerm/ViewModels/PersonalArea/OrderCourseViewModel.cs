using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class OrderCourseViewModel
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

        [DisplayName("會員")]
        public int OrderMemberId
        {
            get { return this.orderCourse.OrderMemberId; }
            set { this.orderCourse.OrderMemberId = value; }
        }
        [DisplayName("訂單狀態")]

        public string status_Content
        {
            get { return this.orderCourse.OrderStatus.StatusContent; }
            set { this.orderCourse.OrderStatus.StatusContent = value; }
        }
        [DisplayName("退費原因")]

        public string? Reason_Content
        {
            get {
                if (this.orderCourse.OrderReasonId==null)
                {
                    return null; 
                }
                return this.orderCourse.OrderReason.ReasonContent;
            }
            set { this.orderCourse.OrderReason.ReasonContent = value; }
        }

        [DisplayName("班別編號")]

        public int CourseClass_Id
        {
            get { return this.orderCourse.OrderClass.CourseClassId; }
            set { this.orderCourse.OrderClass.CourseClassId = value; }
        }

        [DisplayName("班別")]

        public string CourseClass_Name
        {
            get { return this.orderCourse.OrderClass.CourseClassName; }
            set { this.orderCourse.OrderClass.CourseClassName = value; }
        }
        [DisplayName("付款方式")]

        public string Payment_Name
        {
            get { return this.orderCourse.OrderPayment.PaymentName; }
            set { this.orderCourse.OrderPayment.PaymentName = value; }
        }
        [DisplayName("退費金額")]

        public string OrderReasonMoney
        {
            get {
                if (this.orderCourse.OrderReasonMoney == null)
                {
                    return null;
                }
                return this.orderCourse.OrderReasonMoney; }
            set { this.orderCourse.OrderReasonMoney = value; }
        }
        [DisplayName("成立時間")]

        public DateTime OrderTime
        {
            get { return this.orderCourse.OrderTime; }
            set { this.orderCourse.OrderTime = value; }
        }
        [DisplayName("退費時間")]

        public DateTime? OrderReviseTime
        {
            get { return this.orderCourse.OrderReviseTime; }
            set { this.orderCourse.OrderReviseTime = value; }
        }
    }    
}
