using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CLessonViewModel
    {
        private Lesson _lesson = null;
        public Lesson lesson
        {
            get
            {
                if (_lesson == null)
                    _lesson = new Lesson();
                return _lesson;
            }
            set { _lesson = value; }
        }

        private CourseClass _courseclass = null;
        public CourseClass courseclass
        {
            get
            {
                if (_courseclass == null)
                    _courseclass = new CourseClass();
                return _courseclass;
            }
            set { _courseclass = value; }
        }
        public int LessonClassId { get; set; }
        public int LessonId { get; set; }


        [DisplayName("時段")]
        public DateTime LessonTime { get; set; }

        [DisplayName("種類")]
        public string CourseCategoryName { get; set; }

        [DisplayName("分類")]
        public string CourseDetailName{get;set;}

        [DisplayName("班名")]
        public string CourseClassName{get;set;}

        [DisplayName("教練")]
        public string CourseClassCoach{get;set;}
        [DisplayName("教室")]
        public string ClassroomName{get;set;}

        public int ClassroomId { get; set; }

        public string date { get; set; }

        public int[] time { get; set; }

        public int coachID { get; set; }

    }
}
