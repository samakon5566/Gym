using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CCustomerLetterViewModel
    {

        private CustomerLetter _customerLetter = null;
        public CustomerLetter customerLetter
        {
            get
            {
                if (_customerLetter == null)
                    _customerLetter = new CustomerLetter();
                return _customerLetter;
            }
            set { _customerLetter = value; }
        }
        [DisplayName("姓名")]

        public string LetterName {
            get { return this.customerLetter.LetterName; }
            set { this.customerLetter.LetterName = value; }
        }
        [DisplayName("電子信箱")]

        public string LetterEmail
        {
            get { return this.customerLetter.LetterEmail; }
            set { this.customerLetter.LetterEmail = value; }
        }

        [DisplayName("電話")]

        public string LetterPhone
        {
            get { return this.customerLetter.LetterPhone; }
            set { this.customerLetter.LetterPhone = value; }
        }
        public int LetterId
        {
            get { return this.customerLetter.LetterId; }
            set { this.customerLetter.LetterId = value; }
        }

        [DisplayName("信件內容")]

        public string LetterContent
        {
            get { return this.customerLetter.LetterContent; }
            set { this.customerLetter.LetterContent = value; }
        }

        [DisplayName("回覆狀態")]

        public int LetterStatusId
        {
            get { return this.customerLetter.LetterStatusId; }
            set { this.customerLetter.LetterStatusId = value; }
        }

        [DisplayName("回覆人ID")]

        public int? LetterManergerId
        {
            get { return this.customerLetter.LetterManergerId; }
            set { this.customerLetter.LetterManergerId = value; }
        }

        [DisplayName("回覆內容")]

        public string LetterManergerContent
        {
            get { return this.customerLetter.LetterManergerContent; }
            set { this.customerLetter.LetterManergerContent = value; }
        }

        [DisplayName("信件日期")]

        public DateTime? LetterTime
        {
            get { return this.customerLetter.LetterTime; }
            set { this.customerLetter.LetterTime = value; }
        }

        public virtual LogIn LetterManerger { get; set; }
        public virtual LogIn LetterMember { get; set; }
        public virtual LetterStatus LetterStatus { get; set; }


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

        [DisplayName("員工")]
        public string LogInName
        {
            get { return this.login.LogInName; }
            set { this.login.LogInName = value; }
        }



        private LetterStatus _status = null;
        public LetterStatus status
        {
            get
            {
                if (_status == null)
                    _status = new LetterStatus();
                return _status;
            }
            set { _status = value; }
        }

        [DisplayName("回覆狀態")]

        public string LetterStatusName 
        {
            get { return this.status.LetterStatusName; }
            set { this.status.LetterStatusName = value; }
        }

        [DisplayName("員工")]
        public string LetterManagerName
        {
            get;
            set;
        }
    }
}
