using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CCoachViewModel
    {
        private Coach  _coach=null;
        public Coach coach { 
            get {
                if (_coach == null)
                    _coach = new Coach();
                return _coach;
            }
            set { _coach = value; }
        }
        public int CoachId
        {
            get { return this.coach.CoachId; }
            set { this.coach.CoachId = value; }
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
        [DisplayName("背景")]
        public string CoachBackground
        {
            get { return this.coach.CoachBackground; }
            set { this.coach.CoachBackground = value; }
        }
    }
}
