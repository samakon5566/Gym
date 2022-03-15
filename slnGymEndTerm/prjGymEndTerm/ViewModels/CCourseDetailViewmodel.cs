using Microsoft.AspNetCore.Http;
using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CCourseDetailViewmodel
    {

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

        public int CourseDetailId
        {
            get { return this.coursedetail.CourseDetailId; }
            set { this.coursedetail.CourseDetailId = value; }
        }

        [DisplayName("名稱")]
        public string CourseDetailName
        {
            get { return this.coursedetail.CourseDetailName; }
            set { this.coursedetail.CourseDetailName = value; }
        }

        [DisplayName("介紹")]

        public string CourseDetailIntroduce
        {
            get { return this.coursedetail.CourseDetailIntroduce; }
            set { this.coursedetail.CourseDetailIntroduce = value; }
        }

        [DisplayName("時間(分)")]

        public int? CourseDetailTime
        {
            get { return this.coursedetail.CourseDetailTime; }
            set { this.coursedetail.CourseDetailTime = value; }
        }

        [DisplayName("燃燒Cal")]

        public int? CourseDetailCal
        {
            get { return this.coursedetail.CourseDetailCal; }
            set { this.coursedetail.CourseDetailCal = value; }
        }
        [DisplayName("價格")]

        public int? CourseDetailMoney
        {
            get { return this.coursedetail.CourseDetailMoney; }
            set { this.coursedetail.CourseDetailMoney = value; }
        }

        [DisplayName("圖片")]
        public string CourseDetailPicture
        {
            get { return this.coursedetail.CourseDetailPicture; }
            set { this.coursedetail.CourseDetailPicture = value; }
        }

        [DisplayName("圖片")]
        public IFormFile DetailPicture { get; set; }

        [DisplayName("課程種類")]

        public int CourseCategoryId
        {
            get { return this.coursedetail.CourseCategoryId; }
            set { this.coursedetail.CourseCategoryId = value; }
        }

        //[DisplayName("種類")]
        //public string CourseCategoryName
        //{
        //    get { return this.coursedetail.CourseCategory.CourseCategoryName; }
        //    set { this.coursedetail.CourseCategory.CourseCategoryName = value; }
        //}

        [DisplayName("種類")]
        public string CourseCategoryName
        {
            get { return this.coursecategory.CourseCategoryName; }
            set { this.coursecategory.CourseCategoryName = value; }
        }



        public virtual CourseCategory CourseCategory { get; set; }
        public virtual ICollection<CourseClass> CourseClasses { get; set; }
    }
}
