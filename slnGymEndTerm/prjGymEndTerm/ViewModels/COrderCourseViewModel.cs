using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class COrderCourseViewModel
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
        public int OrderId {
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


        private LogIn _login = null;
        public LogIn login
        {
            get
            {
                if (_login == null)
                    _login = new LogIn();
                return _login;
            }
            set { _login = value; }
        }

        public int LogInId
        {
            get { return this.login.LogInId; }
            set { this.login.LogInId = value; }
        }

        [DisplayName("姓名")]
        public string LogInName
        {
            get { return this.login.LogInName; }
            set { this.login.LogInName = value; }
        }

        private CourseClass _courseclass = null;
        public CourseClass courseclass
        {
            get
            {
                if (_courseclass == null)
                    _courseclass = new CourseClass();
                return _courseclass;
            }
            set { _courseclass = value; }
        }

        [DisplayName("班名")]

        public string CourseClassName
        {
            get { return this.courseclass.CourseClassName; }
            set { this.courseclass.CourseClassName = value; }
        }


        private Payment _payment = null;
        public Payment payment
        {
            get
            {
                if (_payment == null)
                    _payment = new Payment();
                return _payment;
            }
            set { _payment = value; }
        }

        public string PaymentName 
        {
            get { return this.payment.PaymentName; }
            set { this.payment.PaymentName = value; }
        }


        private RefundReason _refundReason = null;
        public RefundReason refundReason
        {
            get
            {
                if (_refundReason == null)
                    _refundReason = new RefundReason();
                return _refundReason;
            }
            set { _refundReason = value; }
        }

        public string ReasonContent
        {
            get { return this.refundReason.ReasonContent; }
            set { this.refundReason.ReasonContent = value; }
        }



        private OrderStatus _orderStatus = null;
        public OrderStatus orderStatus
        {
            get
            {
                if (_orderStatus == null)
                    _orderStatus = new OrderStatus();
                return _orderStatus;
            }
            set { _orderStatus = value; }
        }

        public string StatusContent
        {
            get { return this.orderStatus.StatusContent; }
            set { this.orderStatus.StatusContent = value; }
        }

        private Dicount _dicount = null;
        public Dicount dicount
        {
            get
            {
                if (_dicount == null)
                    _dicount = new Dicount();
                return _dicount;
            }
            set { _dicount = value; }
        }

        public decimal DiscountPercent
        {
            get { return this.dicount.DiscountPercent; }
            set { this.dicount.DiscountPercent = value; }
        }


        private DiscountPlan _discountPlan = null;
        public DiscountPlan discountPlan
        {
            get
            {
                if (_discountPlan == null)
                    _discountPlan = new DiscountPlan();
                return _discountPlan;
            }
            set { _discountPlan = value; }
        }

        [DisplayName("課程方案")]
        public string DiscountPlan1 
        {
            get { return this.discountPlan.DiscountPlan1; }
            set { this.discountPlan.DiscountPlan1 = value; }
        }

        private CourseDetail _courseDetail = null;
        public CourseDetail courseDetail
        {
            get
            {
                if (_courseDetail == null)
                    _courseDetail = new CourseDetail();
                return _courseDetail;
            }
            set { _courseDetail = value; }
        }

        public int? CourseDetailMoney
        {
            get { return this.courseDetail.CourseDetailMoney; }
            set { this.courseDetail.CourseDetailMoney = value; }
        }

        [DisplayName("金額")]
        public int classMoney { get; set; }
    }
}
