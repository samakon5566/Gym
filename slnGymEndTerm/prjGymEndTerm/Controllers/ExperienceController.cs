using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly GYMContext _gymcontext;
        public ExperienceController(GYMContext gymcontext)
        {
            _gymcontext = gymcontext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tdee計算機()
        {

            return View();
        }
        public IActionResult FFMI計算機()
        {
            return View();
        }
        public IActionResult 課程設計()
        {
            return View();
        }
        public IActionResult 客製化課程_資訊蒐集()
        {
            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
            {
                LogIn user = System.Text.Json.JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                if (user.LogInTypeId.Equals(2))
                {
                    return View();
                }
            }
            return RedirectToAction("Login", "Home");
        }

        //public IActionResult Lessoncount()
        //{
            

        //    return Json()
        //}

        public IActionResult Arrangement(int id)
        {
            var courseinfos = _gymcontext.CourseClasses.Where(c => c.CourseClassDetail.CourseCategoryId.Equals(id) && c.Lessons.All(l => l.LessonTime > DateTime.Now)).
                Select(c => new
                {
                    coursecategory = c.CourseClassDetail.CourseCategory.CourseCategoryName,
                    coursedetail = c.CourseClassDetail.CourseDetailName
                }).Distinct();

            return Json(courseinfos);
        }

        public IActionResult ArrangementClassName(string id,List<string> classnames)
        {
            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
            {
                LogIn user = System.Text.Json.JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                if (user.LogInTypeId.Equals(2))
                {
                    var courseexist = _gymcontext.Lessons.Where(c => classnames.Contains(c.LessonClass.CourseClassName)).Select(c => c.LessonTime);
                    var courseorder = _gymcontext.OrderCourses.Where(o => o.OrderMemberId.Equals(user.LogInId)).Select(o => o.OrderClassId);
                    var courseinfos = _gymcontext.CourseClasses.Where(c =>!courseorder.Contains(c.CourseClassId)&& c.CourseClassDetail.CourseDetailName.Equals(id) && c.Lessons.All(l => l.LessonTime > DateTime.Now) && (c.Lessons.Select(c => c.LessonTime).Intersect(courseexist)).Count() == 0 && c.OrderCourses.Count <= c.CourseClassPeople).
                    Select(c => new
                    {
                        classid = c.CourseClassId,
                        classname = c.CourseClassName,
                        money = ((int)c.CourseClassDetail.CourseDetailMoney).ToString("c2"),
                        classcal = c.CourseClassDetail.CourseDetailCal
                    });
                    return Json(courseinfos);
                }
            }
            return RedirectToAction("Login", "Home");

        }

        public IActionResult ArrangementLesson(string id)
        {
            var courseinfos = _gymcontext.CourseClasses.Where(c => c.CourseClassName.Equals(id) && c.Lessons.All(l => l.LessonTime > DateTime.Now)).
                Select(c => new
                {
                    coachname = c.CourseClassCoach.CoachNavigation.LogInName,
                    lessontime = c.Lessons.Select(l => l.LessonTime),
                    vacancy = c.CourseClassPeople - c.OrderCourses.Count,
                    coursepeople = c.CourseClassPeople
                });
            return Json(courseinfos);
        }
    }
}
