using Microsoft.AspNetCore.Http;
using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CLoginViewModel
    {
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
        [DisplayName("帳號")]
        public string LogInAccount
        {
            get { return this.login.LogInAccount; }
            set { this.login.LogInAccount = value; }
        }
        public int LogInTypeId
        {
            get { return this.login.LogInTypeId; }
            set { this.login.LogInTypeId = value; }
        }
        [DisplayName("密碼")]
        public string LogInPassword
        {
            get { return this.login.LogInPassword; }
            set { this.login.LogInPassword = value; }
        }
        [DisplayName("姓名")]
        public string LogInName
        {
            get { return this.login.LogInName; }
            set { this.login.LogInName = value; }
        }

        [DisplayName("身分證字號")]

        public string LogInIdNumber
        {
            get { return this.login.LogInIdNumber; }
            set { this.login.LogInIdNumber = value; }
        }
        [DisplayName("性別")]

        public string LogInGender
        {
            get { return this.login.LogInGender; }
            set { this.login.LogInGender = value; }
        }
        [DisplayName("生日")]

        public DateTime LogInBrithDay
        {
            get { return this.login.LogInBrithDay; }
            set { this.login.LogInBrithDay = value; }
        }
        [DisplayName("電話")]

        public string LogInPhone
        {
            get { return this.login.LogInPhone; }
            set { this.login.LogInPhone = value; }
        }
        [DisplayName("郵件")]

        public string LogInEmail
        {
            get { return this.login.LogInEmail; }
            set { this.login.LogInEmail = value; }
        }
        [DisplayName("身高")]
        public decimal? LogInHeight
        {
            get { return this.login.LogInHeight; }
            set { this.login.LogInHeight = value; }
        }
        [DisplayName("體重")]
        public decimal? LogInWeight
        {
            get { return this.login.LogInWeight; }
            set { this.login.LogInWeight = value; }
        }
        [DisplayName("註冊日期")]

        public DateTime LogInRegisterTime
        {
            get { return this.login.LogInRegisterTime; }
            set { this.login.LogInRegisterTime = value; }
        }

        


        [DisplayName("照片")]
        public string LoginFigures
        {
            get { return this.login.LoginFigure; }
            set { this.login.LoginFigure = value; }
        }

        [DisplayName("圖片")]

        public IFormFile LoginFigure { get; set; }

        public virtual LoginType LogInType { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual ICollection<CustomerLetter> CustomerLetterLetterManergers { get; set; }
        public virtual ICollection<CustomerLetter> CustomerLetterLetterMembers { get; set; }
        public virtual ICollection<MemberLesson> MemberLessons { get; set; }
        public virtual ICollection<MemberScore> MemberScores { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<OrderCourse> OrderCourses { get; set; }

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

        [DisplayName("地址")]
        public string CoachAddress
        {
            get { return this.coach.CoachAddress; }
            set { this.coach.CoachAddress = value; }
        }
        [DisplayName("年資")]
        public int? CoachExperience
        {
            get { return this.coach.CoachExperience; }
            set { this.coach.CoachExperience = value; }
        }

        [DisplayName("專業證照/技能")]
        public string CoachBackground { get; set; }

        private Skill _skill = null;
        public Skill skill
        {
            get
            {
                if (_skill == null)
                    _skill = new Skill();
                return _skill;
            }
            set { _skill = value; }
        }

        public int SkillCourseCategoryId
        {
            get { return this.skill.SkillCourseCategoryId; }
            set { this.skill.SkillCourseCategoryId = value; }
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

        [DisplayName("專長課程")]

        public string CourseCategoryName
        {
            get { return this.coursecategory.CourseCategoryName; }
            set { this.coursecategory.CourseCategoryName = value; }
        }
        [DisplayName("授課項目")]
        public List<string> coachSkillCategory { get; set; }

        public int[] skillAry { get; set; }
        public List<string> skillCategoryAll { get; set; }

    }
}
