using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CSorceViewModel
    {

        private MemberScore _sorce = null;
        public MemberScore sorce
        {
            get
            {
                if (_sorce == null)
                    _sorce = new MemberScore();
                return _sorce;
            }
            set { _sorce = value; }
        }

        public int ScoreId
        {
            get { return this.sorce.ScoreId; }
            set { this.sorce.ScoreId = value; }
        }

        [DisplayName("會員")]

        public int MemberId
        {
            get { return this.sorce.MemberId; }
            set { this.sorce.MemberId = value; }
        }

        [DisplayName("班別")]

        public int CourseClassId
        {
            get { return this.sorce.CourseClassId; }
            set { this.sorce.CourseClassId = value; }
        }

        [DisplayName("評論內容")]

        public string Classcomment
        {
            get { return this.sorce.Classcomment; }
            set { this.sorce.Classcomment = value; }
        }

        [DisplayName("評分")]

        public int ClassScore
        {
            get { return this.sorce.ClassScore; }
            set { this.sorce.ClassScore = value; }
        }

        [DisplayName("評論日期")]
        public DateTime? ClassRecord
        {
            get { return this.sorce.ClassRecord; }
            set { this.sorce.ClassRecord = value; }
        }

        public virtual CourseClass CourseClass { get; set; }
        public virtual LogIn Member { get; set; }



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

        [DisplayName("課程分類")]
        public int CourseClassDetailId
        {
            get { return this.courseclass.CourseClassDetailId; }
            set { this.courseclass.CourseClassDetailId = value; }
        }

        [DisplayName("課程分類名稱")]
        public string CourseDetailName
        {
            get { return this.coursedetail.CourseDetailName; }
            set { this.coursedetail.CourseDetailName = value; }
        }

        private CourseDetail _coursedetail = null;
        public CourseDetail coursedetail
        {
            get
            {
                if (_coursedetail == null)
                    _coursedetail = new CourseDetail();
                return _coursedetail;
            }
            set { _coursedetail = value; }
        }

        [DisplayName("課程種類")]

        public int CourseCategoryId
        {
            get { return this.coursedetail.CourseCategoryId; }
            set { this.coursedetail.CourseCategoryId = value; }
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

        [DisplayName("課程種類")]

        public string CourseCategoryName
        {
            get { return this.coursecategory.CourseCategoryName; }
            set { this.coursecategory.CourseCategoryName = value; }
        }


        private Coach _coach = null;
        public Coach coach
        {
            get
            {
                if (_coach == null)
                    _coach = new Coach();
                return _coach;
            }
            set { _coach = value; }
        }

        [DisplayName("教練")]

        public string CoachName
        {
            get;
            set;
        }
    }
}
