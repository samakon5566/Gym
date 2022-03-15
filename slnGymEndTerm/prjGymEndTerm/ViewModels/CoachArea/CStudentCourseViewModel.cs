using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels.CoachArea
{
    public class CStudentCourseViewModel
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

        [DisplayName("課程分類")]
        public string CourseCategory_Name
        {
            get { return this.orderCourse.OrderClass.CourseClassDetail.CourseCategory.CourseCategoryName; }
            set { this.orderCourse.OrderClass.CourseClassDetail.CourseCategory.CourseCategoryName = value; }
        }
        [DisplayName("班級分類")]
        public string CourseDetail_Name
        {
            get { return this.orderCourse.OrderClass.CourseClassDetail.CourseDetailName; }
            set { this.orderCourse.OrderClass.CourseClassDetail.CourseDetailName = value; }
        }
        [DisplayName("課程分類")]
        public string CourseClass_Name
        {
            get { return this.orderCourse.OrderClass.CourseClassName; }
            set { this.orderCourse.OrderClass.CourseClassName = value; }
        }
        [DisplayName("課程時間")]
        public String Lesson_Time
        {
            get;set;
        }

    }
}
