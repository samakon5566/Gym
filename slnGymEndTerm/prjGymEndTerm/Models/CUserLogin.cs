using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.Models
{
    public class CUserLogin
    {
        //public static string _member = null;

        public static int memberId { get; set; }
        public static int memberType { get; set; }
        public static string memberName
        {
            get;set;
            //get
            //{
            //    //if (_member == null)
            //    //    _member = new LogIn();
            //    return _member;
            //}
            //set
            //{
            //    _member = value;
            //}
        }
        public static string memberfigure { get; set; }
    }
}
