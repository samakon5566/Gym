using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels.CoachArea
{
    public class CoachCommentListViewModel
    {
        MemberScore _score = null;
        public MemberScore score
        {
            get
            {
                if (_score == null)
                    _score = new MemberScore();
                return _score;
            }
            set { _score = value; }
        }
        public int ScoreId
        {
            get { return this.score.ScoreId; }
            set { this.score.ScoreId = value; }
        }
        [DisplayName("學生姓名")]
        public string StudentName
        {
            get { return this.score.Member.LogInName; }
            set { this.score.Member.LogInName = value; }
        }
        [DisplayName("教練名稱")]
        public string CoachName
        {
            get { return this.score.CourseClass.CourseClassCoach.CoachNavigation.LogInName; }
            set { this.score.CourseClass.CourseClassCoach.CoachNavigation.LogInName = value; }
        }

        [DisplayName("班級名稱")]
        public string ClassName
        {
            get { return this.score.CourseClass.CourseClassName; }
            set { this.score.CourseClass.CourseClassName = value; }
        }
        [DisplayName("評價分數")]
        public int ClassScore
        {
            get { return this.score.ClassScore; }
            set { this.score.ClassScore = value; }
        }
        [DisplayName("評價內容")]
        public string ClassRecord
        {
            get {
                if (this.score.Classcomment == null)
                    return "無";
                else
                return  this.score.Classcomment; 
            }
            set { this.score.Classcomment = value; }
        }
        [DisplayName("評價時間")]
        public DateTime? RecordTime
        {
            get { return this.score.ClassRecord; }
            set { this.score.ClassRecord = value; }
        }

    }
}
