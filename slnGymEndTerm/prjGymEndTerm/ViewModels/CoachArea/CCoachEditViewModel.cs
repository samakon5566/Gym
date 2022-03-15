using Microsoft.AspNetCore.Http;
using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CCoachEditViewModel
    {
        private LogIn _login = null;
        private Coach _coach = null;
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

        public int LogInId {
            get { return this.login.LogInId; }
            set { this.login.LogInId = value; }
        }
        [DisplayName("帳號")]
        public string LogInAccount {
            get { return this.login.LogInAccount; }
            set { this.login.LogInAccount = value; }
        }
        public int LogInTypeId {
            get { return this.login.LogInTypeId; }
            set { this.login.LogInTypeId = value; }
        }
        [DisplayName("密碼")]
        public string LogInPassword {
            get { return this.login.LogInPassword; }
            set { this.login.LogInPassword = value; }
        }
        [DisplayName("姓名")]
        public string LogInName {
            get { return this.login.LogInName; }
            set { this.login.LogInName = value; }
        }
        [DisplayName("身分證")]
        public string LogInIdNumber {
            get { return this.login.LogInIdNumber; }
            set { this.login.LogInIdNumber = value; }
        }
        [DisplayName("性別")]
        public string LogInGender {
            get { return this.login.LogInGender; }
            set { this.login.LogInGender = value; }
        }
        [DisplayName("生日")]
        public DateTime LogInBrithDay {
            get { return this.login.LogInBrithDay; }
            set { this.login.LogInBrithDay = value; }
        }
        [DisplayName("電話")]
        public string LogInPhone {
            get { return this.login.LogInPhone; }
            set { this.login.LogInPhone = value; }
        }
        [DisplayName("信箱")]
        public string LogInEmail {
            get { return this.login.LogInEmail; }
            set { this.login.LogInEmail = value; }
        }
        [DisplayName("身高")]
        public decimal? LogInHeight {
            get { return this.login.LogInHeight; }
            set { this.login.LogInHeight = value; }
        }
        [DisplayName("體重")]
        public decimal? LogInWeight {
            get { return this.login.LogInWeight; }
            set { this.login.LogInWeight = value; }
        }
        [DisplayName("註冊日期")]
        public DateTime LogInRegisterTime {
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
        [DisplayName("地址")]

        public string CoachAddress
        {
            get { return this.coach.CoachAddress; }
            set { this.coach.CoachAddress = value; }
        }
        [DisplayName("專長")]

        public int? CoachExperience
        {
            get { return this.coach.CoachExperience; }
            set { this.coach.CoachExperience = value; }
        }

        [DisplayName("背景")]

        public string CoachBackground
        {
            get { return this.coach.CoachBackground; }
            set { this.coach.CoachBackground = value; }
        }
    }
}
