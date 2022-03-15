using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class LogIn
    {
        public LogIn()
        {
            CustomerLetters = new HashSet<CustomerLetter>();
            MemberLessons = new HashSet<MemberLesson>();
            MemberScores = new HashSet<MemberScore>();
            News = new HashSet<News>();
            OrderCourses = new HashSet<OrderCourse>();
        }

        public int LogInId { get; set; }
        public string LogInAccount { get; set; }
        public int LogInTypeId { get; set; }
        public string LogInPassword { get; set; }
        public string LogInName { get; set; }
        public string LogInIdNumber { get; set; }
        public string LogInGender { get; set; }
        public DateTime LogInBrithDay { get; set; }
        public string LogInPhone { get; set; }
        public string LogInEmail { get; set; }
        public decimal? LogInHeight { get; set; }
        public decimal? LogInWeight { get; set; }
        public DateTime LogInRegisterTime { get; set; }
        public string LoginFigure { get; set; }

        public virtual LoginType LogInType { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual ICollection<CustomerLetter> CustomerLetters { get; set; }
        public virtual ICollection<MemberLesson> MemberLessons { get; set; }
        public virtual ICollection<MemberScore> MemberScores { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<OrderCourse> OrderCourses { get; set; }
    }
}
