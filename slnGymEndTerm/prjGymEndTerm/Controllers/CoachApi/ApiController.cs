using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers.CoachApi
{
    public class ApiController : Controller
    {
        private readonly GYMContext gym;
        public ApiController(GYMContext context)
        {
            gym = context;
        }
        public int Login(string txtAccount,string txtPassword)
        {
            LogIn user = gym.LogIns.FirstOrDefault(c => c.LogInAccount.Equals(txtAccount) && c.LogInPassword.Equals(txtPassword));
            if (user != null)
            {
                string json = "";
                json = JsonSerializer.Serialize(user);
                HttpContext.Session.SetString(LoginDictionary.SK_Logined_User, json);
                return user.LogInTypeId;
            }
            return 4;
        }



        public IActionResult select(int id)
        {
            var order = gym.PostureChanges.Where(p =>p.OrderId == id).OrderBy(p=>p.RecordTime);

            return Json(order);
        }
        //下拉選單 課程大象
        public IActionResult selectCategoty()
        {
            var course = gym.CourseCategories.Select(m => new
            {
                m.CourseCategoryId,
                m.CourseCategoryName
            } );
            return Json(course);
        }
        //下拉選單 班級名稱
        public IActionResult selectClass(int id)
        {
            var course = gym.CourseClasses.Where(c=>c.CourseClassDetail.CourseCategory.CourseCategoryId==id
            && c.CourseClassCoach.CoachId==CUserLogin.memberId
            ) .Select(m => new
            {
                m.CourseClassId,
                m.CourseClassName
            });
            return Json(course);
        }
        public int Delete(int id)
        {
            PostureChange posture = gym.PostureChanges.FirstOrDefault(p=>p.RecordId==id);
            if (posture != null)
            {
                gym.Remove(posture);
                gym.SaveChanges();
                return 1;
            }
            else
                return 0;
        }
        public int Insert(int id, decimal weight, decimal muscleBass, decimal basalMetabolism, decimal fat)
        {
            int num = 0;
            try
            {
                PostureChange posture = new PostureChange();
                posture.OrderId = id;
                posture.Weight = weight;
                posture.MuscleBass = muscleBass;
                posture.BasalMetabolism = basalMetabolism;
                posture.Fat = fat;
                posture.RecordTime = DateTime.Now;
                gym.Add(posture);
                num = gym.SaveChanges();
            }
            catch (Exception ex)
            {
                num = 0;
            }
            return num;
        }
        public int  Update(int id, decimal weight, decimal muscleBass, decimal basalMetabolism, decimal fat)
        {
            int num = 0;
            try
            {
                PostureChange posture = gym.PostureChanges.Where(p => p.RecordId == id).FirstOrDefault();
                num = 1;
                posture.Weight = weight;
                posture.MuscleBass = muscleBass;
                posture.BasalMetabolism = basalMetabolism;
                posture.Fat = fat;
                num = gym.SaveChanges();
            }
            catch (Exception ex)
            {
                num = 0;
            }
            return num;
        }
        public void InsertVideo(string Video_Title,string Vido_Content,string Video_Url,int Video_Category)
        {
            try
            {
                FitnessVideo video = new FitnessVideo();
                video.FitnessVideoTitle = Video_Title;
                video.FitnessVideoContent = Vido_Content;
                video.FitnessVideoUrl = Video_Url;
                video.FitnessVideoTime = DateTime.Now;
                video.FitnessVideoCoachId = CUserLogin.memberId;
                video.FitnessVideoCourseCategoryId = Video_Category;
                gym.Add(video);
                gym.SaveChanges();
            }
            catch (Exception ex)
            {
                
            }
        }

        public IActionResult selectMemberClass()
        {
            List<CCouachCalendar> memberList = new List<CCouachCalendar>();
            var lesson = gym.MemberLessons.Where(l =>
            l.MemberLessonMemberId == CUserLogin.memberId).Select(l =>
            new
            {
                id = l.MemberLessonLessonId,
                title = l.MemberLessonLesson.LessonClass.CourseClassName,
                start = l.MemberLessonLesson.LessonTime,
                end = l.MemberLessonLesson.LessonTime.AddMinutes(60)
            });
            foreach (var item in lesson)
            {
                CCouachCalendar CCC = new CCouachCalendar();
                CCC.id = item.id;
                CCC.title = item.title;
                CCC.start = ConvertDateTime(item.start);
                CCC.end = ConvertDateTime(item.end);
                memberList.Add(CCC);
            }

            return Json(memberList);
        }


        public IActionResult selectAllClass()
        {
            List<CCouachCalendar> courseList = new List<CCouachCalendar>();
            var lesson = gym.Lessons.Where(l =>
            l.LessonClass.CourseClassCoachId == CUserLogin.memberId).Select(l=>
            new
            {
                id = l.LessonId,
                title=l.LessonClass.CourseClassName,
                start=l.LessonTime,
                end=l.LessonTime.AddMinutes(60)
            });
            foreach(var item in lesson)
            {
                CCouachCalendar CCC = new CCouachCalendar();

                CCC.id = item.id;
                CCC.title = item.title;
                CCC.start = ConvertDateTime(item.start);
                CCC.end = ConvertDateTime(item.end);
                courseList.Add(CCC);
            }

            //CCouachCalendar a = new CCouachCalendar();
            //a.title = "有氧";
            //a.start = "2022-01-03T14:00:00";
            //a.end = "2022-01-03T15:00:00";
            //courseList.Add(a);

            //CCouachCalendar b = new CCouachCalendar();
            //b.title = "舉重";
            //b.start = "2022-01-04T14:00:00";
            //b.end = "2022-01-04T15:00:00";
            //courseList.Add(b);

            //CCouachCalendar c = new CCouachCalendar();
            //c.title = "瑜珈";
            //c.start = "2022-01-05T14:00:00";
            //c.end = "2022-01-05T15:00:00";
            //courseList.Add(c);

            return Json(courseList);
        }
        public string ConvertDateTime(DateTime dt)
        {
            string result = "";
            result = dt.ToString("yyyy-MM-dd");
            result += "T";
            result += dt.ToString("HH:mm:ss");

            return result;
        }
        public void InsertClass(int  CourseDetail,string ClassName,int CoursePlan)
        {
            try
            {
                CourseClass course = new CourseClass();
                course.CourseClassDetailId = CourseDetail;
                course.CourseClassName = ClassName;
                course.CourseClassCoachId = CUserLogin.memberId;
                course.CourseClassPeople = 1;
                course.CourseClassClassroomId = 3;
                course.CourseClassPlanId = CoursePlan;
                gym.Add(course);
                gym.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }
        public void InsertLesson(int ClassId, string courseTime)
        {
            try
            {
                string[] sArray = courseTime.Split('T');
                string lessonTime = sArray[0] + " " + sArray[1];
                Lesson l = new Lesson();
                l.LessonClassId = ClassId;
                l.LessonTime = DateTime.Parse(lessonTime);
                gym.Add(l);
                gym.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }
        public String CourseRoom(int LessonId)
        {
            string RoomName = gym.Lessons.
                Where(c => c.LessonId == LessonId).Select(c => c.LessonClass.CourseClassClassroom.ClassroomName).FirstOrDefault();
            return RoomName;
        }
        public void SetChatPwd(string pwd)
        {
            CChatRoom.RoomPwd = pwd;
        }
        public int CheckChatPwd(string pwd,string group)
        {
                return (pwd == CChatRoom.RoomPwd && group==CChatRoom.RoomId) ?1:0;  
        }
    }
}
