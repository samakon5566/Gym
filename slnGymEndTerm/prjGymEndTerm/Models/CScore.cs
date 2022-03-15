using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.Models
{
    public class CScore
    {

        public int score1Count { get; set; }
        public int score2Count { get; set; }
        public int score3Count { get; set; }
        public int score4Count { get; set; }
        public int score5Count { get; set; }

        public List<string> coachName { get; set; }
        public List<string> coachPicture { get; set; }
        public List<int> coachScore5Count { get; set; }


        public int scoreCount(GYMContext gym,int classScore)
        {
            int scoreCount = gym.MemberScores.Where(s => s.ClassScore == classScore).Count();
            return scoreCount;
        }

        public int yearScoreCount(GYMContext gym, int year,int classScore)
        {
            int yearScoreCount = gym.MemberScores.Where(s => s.ClassScore == classScore && ((DateTime)s.ClassRecord).Year == year).Count();
            return yearScoreCount;
        }

        public int categoryAndYearScoreCount(GYMContext gym, int year, int categoryID, int classScore)
        {
            int categoryAndYearScoreCount = gym.MemberScores
                .Where(s => s.ClassScore == classScore && s.CourseClass.CourseClassDetail.CourseCategory.CourseCategoryId == categoryID 
                && ((DateTime)s.ClassRecord).Year == year).Count();
            return categoryAndYearScoreCount;
        }

        public int ALLScoreCount(GYMContext gym, int classScore)
        {
            int ALLScoreCount = gym.MemberScores.Where(s => s.ClassScore == classScore).Count();
            return ALLScoreCount;
        }

        public int coachAndYearScoreCount(GYMContext gym, int year,int coachID, int classScore)
        {
            int coachAndYearScoreCount = gym.MemberScores.Where(s => s.ClassScore == classScore && ((DateTime)s.ClassRecord).Year == year && s.CourseClass.CourseClassCoachId== coachID).Count();
            return coachAndYearScoreCount;
        }

        public int coachScoreCount(GYMContext gym, int coachID, int classScore)
        {
            int coachScoreCount = gym.MemberScores.Where(s => s.ClassScore == classScore && s.CourseClass.CourseClassCoachId == coachID).Count();
            return coachScoreCount;
        }

        public int categoryScoreCount(GYMContext gym, int categoryID, int classScore)
        {
            int coachScoreCount = gym.MemberScores
                .Where(s => s.ClassScore == classScore && s.CourseClass.CourseClassDetail.CourseCategory.CourseCategoryId == categoryID).Count();
            return coachScoreCount;
        }
    }
}
