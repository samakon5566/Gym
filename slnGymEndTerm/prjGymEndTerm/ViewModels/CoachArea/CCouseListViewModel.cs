using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels.CoachArea
{
    public class CCouseListViewModel
    {
        private MemberLesson _ms = null;
        public MemberLesson ms
        {
            get
            {
                if (_ms == null)
                    _ms = new MemberLesson();
                return _ms;
            }
            set { _ms = value; }
        }
        public string StudentName
        {
            get { return this.ms.MemberLessonMember.LogInName; }
            set { this.ms.MemberLessonMember.LogInName = value; }
        }
        public int? StudentAttend
        {
            get { return this.ms.AttendanceTypeId; }
            set { this.ms.AttendanceTypeId = value; }
        }

    }
}
