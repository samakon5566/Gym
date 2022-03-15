using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CCourseClassViewmodel
    {
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

        public int CourseClassId
        {
            get { return this.courseclass.CourseClassId; }
            set { this.courseclass.CourseClassId = value; }
        }

        [DisplayName("種類")]
        public string CourseCategoryName{get;set;}

        [DisplayName("教練")]
        public string CourseClassCoach
        {
            get;
            set;
        }

        [DisplayName("已報名數")]
        public int NumberOfApplicants
        {
            get;
            set;
        }

        [DisplayName("教室")]
        public string ClassroomName
        {
            get;
            set;
        }

        [DisplayName("課程方案")]
        public string DiscountPlanName
        {
            get;
            set;
        }

        [DisplayName("班名")]
        public string CourseClassName
        {
            get { return this.courseclass.CourseClassName; }
            set { this.courseclass.CourseClassName = value; }
        }

        [DisplayName("分類")]
        public string CourseDetailName
        {
            get;
            set;
        }

        [DisplayName("人數限制")]
        public int CourseClassPeople
        {
            get { return this.courseclass.CourseClassPeople; }
            set { this.courseclass.CourseClassPeople = value; }
        }
    }
}
