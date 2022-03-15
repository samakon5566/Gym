using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels.CoachArea
{
    public class CoachArea_StudentViewModel
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
        [DisplayName("姓名")]
        public string LogInName
        {
            get { return this.login.LogInName; }
            set { this.login.LogInName = value; }
        }
        [DisplayName("性別")]
        public string LogInGender
        {
            get { return this.login.LogInGender; }
            set { this.login.LogInGender = value; }
        }
        [DisplayName("電話")]
        public string LogInPhone
        {
            get { return this.login.LogInPhone; }
            set { this.login.LogInPhone = value; }
        }
        [DisplayName("信箱")]
        public string LogInEmail
        {
            get { return this.login.LogInEmail; }
            set { this.login.LogInEmail = value; }
        }
    }
}
