using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CCourseClassIncludeViewmodel
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

        private CourseCategory _coursecategory = null;
        public CourseCategory coursecategory
        {
            get
            {
                if (_coursecategory == null)
                    _coursecategory = new CourseCategory();
                return _coursecategory;
            }
            set { _coursecategory = value; }
        }

        private Classroom _classroom = null;
        public Classroom classroom
        {
            get
            {
                if (_classroom == null)
                    _classroom = new Classroom();
                return _classroom;
            }
            set { _classroom = value; }
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

        [DisplayName("種類")]
        public string _CourseCategoryName
        {
            get { return this.coursecategory.CourseCategoryName; }
            set { this.coursecategory.CourseCategoryName = value; }
        }

        [DisplayName("教練")]
        public string _CourseClassCoach
        {
            get;
            set;
        }

        [DisplayName("已報名數")]
        public string _NumberOfApplicants
        {
            get;
            set;
        }

        [DisplayName("教室")]
        public string _ClassroomName
        {
            get { return this.classroom.ClassroomName; }
            set { this.classroom.ClassroomName = value; }
        }

        [DisplayName("方案")]
        public string _DiscountPlanName
        {
            get { return this.discountPlan.DiscountPlan1; }
            set { this.discountPlan.DiscountPlan1 = value; }
        }



        public int CourseClassId
        {
            get { return this.courseclass.CourseClassId; }
            set { this.courseclass.CourseClassId = value; }
        }

        [DisplayName("課程分類")]
        public int CourseClassDetailId
        {
            get { return this.courseclass.CourseClassDetailId; }
            set { this.courseclass.CourseClassDetailId = value; }
        }

        [DisplayName("班名")]

        public string CourseClassName
        {
            get { return this.courseclass.CourseClassName; }
            set { this.courseclass.CourseClassName = value; }
        }

        [DisplayName("教練")]

        public int CourseClassCoachId
        {
            get { return this.courseclass.CourseClassCoachId; }
            set { this.courseclass.CourseClassCoachId = value; }
        }

        [DisplayName("人數限制")]

        public int CourseClassPeople
        {
            get { return this.courseclass.CourseClassPeople; }
            set { this.courseclass.CourseClassPeople = value; }
        }

        [DisplayName("教室")]

        public int CourseClassClassroomId
        {
            get { return this.courseclass.CourseClassClassroomId; }
            set { this.courseclass.CourseClassClassroomId = value; }
        }

        public int? CourseClassPlanId
        {
            get { return this.courseclass.CourseClassPlanId; }
            set { this.courseclass.CourseClassPlanId = value; }
        }


        [DisplayName("優惠")]
        public int CourseClassDicountId
        {
            get { return this.courseclass.CourseClassPlan.Dicount.DicountId; }
            set { this.courseclass.CourseClassPlan.Dicount.DicountId = value; }
        }

        public virtual Classroom CourseClassClassroom
        {
            get { return this.courseclass.CourseClassClassroom; }
            set { this.courseclass.CourseClassClassroom = value; }
        }
        public virtual Coach CourseClassCoach
        {
            get { return this.courseclass.CourseClassCoach; }
            set { this.courseclass.CourseClassCoach = value; }
        }
        public virtual CourseDetail CourseClassDetail
        {
            get { return this.courseclass.CourseClassDetail; }
            set { this.courseclass.CourseClassDetail = value; }
        }
        public virtual Dicount CourseClassDicount
        {
            get { return this.courseclass.CourseClassPlan.Dicount; }
            set { this.courseclass.CourseClassPlan.Dicount = value; }
        }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<MemberScore> MemberScores { get; set; }
        public virtual ICollection<OrderCourse> OrderCourses { get; set; }

        [DisplayName("種類")]
        public string CourseCategoryName
        {
            get { return this.courseclass.CourseClassDetail.CourseCategory.CourseCategoryName; }
            set { this.courseclass.CourseClassDetail.CourseCategory.CourseCategoryName = value; }
        }

        [DisplayName("分類")]
        public string CourseDetailName
        {
            get { return this.courseclass.CourseClassDetail.CourseDetailName; }
            set { this.courseclass.CourseClassDetail.CourseDetailName = value; }
        }

        [DisplayName("教練")]
        public string LogInName 
        {
            get { return this.courseclass.CourseClassCoach.CoachNavigation.LogInName; }
            set { this.courseclass.CourseClassCoach.CoachNavigation.LogInName = value; }
        }

        [DisplayName("教室")]
        public string ClassroomName
        {
            get { return this.courseclass.CourseClassClassroom.ClassroomName; }
            set { this.courseclass.CourseClassClassroom.ClassroomName = value; }
        }

        [DisplayName("課程方案")]
        public string DiscountPlan1
        {
            get { return this.courseclass.CourseClassPlan.DiscountPlan1; }
            set { this.courseclass.CourseClassPlan.DiscountPlan1 = value; }
        }

    }
}
