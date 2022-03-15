using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{
    public class PersonalAreaController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly GYMContext gym;
        public PersonalAreaController(IWebHostEnvironment p, GYMContext context)
        {
            _environment = p;
            gym = context;
        }
        private bool HasSessino()
        {
            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));

                CUserLogin.memberName = user.LogInName;
                CUserLogin.memberType = user.LogInTypeId;
                CUserLogin.memberId = user.LogInId;
                CUserLogin.memberfigure = user.LoginFigure;

                ViewBag.LogInName = user.LogInName;
                ViewBag.LogInTypeId = user.LogInTypeId;
                ViewBag.LogInId = user.LogInId;

                return true;
            }
            CUserLogin.memberName = null;
            CUserLogin.memberType = -1;
            CUserLogin.memberId = -1;
            CUserLogin.memberfigure =null;

            return false;
        }


        public IActionResult List()
        {
            if (HasSessino())
            {
                return View();
            }

            return RedirectToAction("Login", "Home");

        }
        public IActionResult 基本資料()
        {
            if (HasSessino())
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                LogIn l = gym.LogIns.FirstOrDefault(l => l.LogInId == user.LogInId);

                CLoginViewModel member = new CLoginViewModel();
                member.login = l;
                return View(member);
            }

            return RedirectToAction("Login", "Home");
        }
        [HttpPost]
        public IActionResult 基本資料(CLoginViewModel p)
        {           
            LogIn l = gym.LogIns.FirstOrDefault(l => l.LogInId == p.LogInId);            
            if (l != null)
            {
                if (p.LoginFigure != null)
            {
                string figureName = p.LoginFigure.FileName;
                l.LoginFigure = figureName;
                p.LoginFigure.CopyTo(new FileStream(_environment.WebRootPath + @"\img\LoginFigure\" + figureName, FileMode.Create));
            }

                l.LogInName = p.LogInName;
                l.LogInIdNumber = p.LogInIdNumber;
                l.LogInGender = p.LogInGender;
                l.LogInBrithDay = p.LogInBrithDay;
                l.LogInPhone = p.LogInPhone;
                l.LogInEmail = p.LogInEmail;
                //l.LogInPassword = p.LogInPassword;
                gym.SaveChanges();
            }
            
            return RedirectToAction("基本資料");
        }
        public IActionResult 課程管理()
        {
            if (HasSessino())
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));                
                
                var order = gym.OrderCourses
                    .Include(o => o.OrderClass)
                    .Include(o => o.OrderPayment)
                    .Include(o => o.OrderReason)
                    .Include(o => o.OrderStatus)
                    .Where(o => o.OrderMemberId == user.LogInId)
                    .Select(o => new OrderCourseViewModel() { orderCourse = o })
                    .OrderBy(o=>o.orderCourse.OrderTime);
                return View(order);
            }

            return RedirectToAction("Login", "Home");
        }
        public IActionResult 健身紀錄()
        {
            if (HasSessino())
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                var postures = gym.PostureChanges.Where(p => p.Order.OrderMemberId.Equals(user.LogInId)).Select(p => p).OrderBy(p=>p.RecordTime);
                List<CPostureChangeViewModel> list = new List<CPostureChangeViewModel>();
                foreach(var posture in postures)
                {
                    list.Add(new CPostureChangeViewModel
                    {
                        OrderId = posture.OrderId,
                        Weight = posture.Weight,
                        MuscleBass = posture.MuscleBass,
                        BasalMetabolism = posture.BasalMetabolism,
                        Fat = posture.Fat,
                        RecordTime = posture.RecordTime
                    });
                }

                List<decimal?> chartFat = new List<decimal?>();
                List<decimal?> chartWeight = new List<decimal?>();
                List<string> chartDate = new List<string>(); 
                foreach(var posture in postures)
                {
                    DateTime date = Convert.ToDateTime(posture.RecordTime);
                    chartDate.Add(date.ToString("yyyy-MM-dd"));
                }
                foreach (var posture in postures)
                {
                    chartFat.Add(posture.Fat);
                    chartWeight.Add(posture.Weight);
                }
                string WorkOutFat = JsonSerializer.Serialize(chartFat);
                string WorkOutWeight = JsonSerializer.Serialize(chartWeight);
                string WorkOutDate = JsonSerializer.Serialize(chartDate);

                ViewBag.workoutfat = WorkOutFat;
                ViewBag.workoutweight = WorkOutWeight;
                ViewBag.workoutdate = WorkOutDate;
                return View(list);
            }

            return RedirectToAction("Login", "Home");
        }
        public int ScoreUpdate(int MemberId, int CourseClassID, string Classcomment, int ClassScore, DateTime ClassRecord)
        {
            int LogInId = CUserLogin.memberId;
           
            int num = 0;
            try
            {
                //if (ClassScore!=0)
                //{
                //    MemberScore score = gym.MemberScores.FirstOrDefault(score=>score.MemberId == MemberId);
                //    score.Classcomment = Classcomment;
                //    score.ClassScore = ClassScore;
                //    score.ClassRecord = DateTime.Now;
                //    num = gym.SaveChanges();
                //}
                //else
                //{
                    MemberScore score = new MemberScore();
                    num = 1;
                    score.MemberId = LogInId;
                    score.CourseClassId = CourseClassID;
                    score.Classcomment = Classcomment;
                    score.ClassScore = ClassScore;
                    score.ClassRecord = DateTime.Now;
                    gym.Add(score);
                    num = gym.SaveChanges();
                //}
                
            }
            catch (Exception ex)
            {
                num = 0;
            }
            return num;
        }
        public int AttendUpdate() 
        {
            int lessonid = 0;
            
            DateTime now = DateTime.Now;
            lessonid = gym.MemberLessons.Where(m => m.MemberLessonMemberId == CUserLogin.memberId
            && (m.MemberLessonLesson.LessonTime < now && m.MemberLessonLesson.LessonTime.AddMinutes(60) > now)
            ).Select(m=>m.MemberLessonLessonId).FirstOrDefault();                

            if (lessonid != 0)
            {                                       
                MemberLesson m = gym.MemberLessons.FirstOrDefault(m=>m.MemberLessonLessonId == lessonid);
                m.AttendanceTypeId = 3;
                gym.SaveChanges();
            }
          
            return lessonid;
        }

        public IActionResult LeaveUpdate(int lessonId)
        {
            DateTime d = gym.Lessons.Where(m => m.LessonId == lessonId).Select(m => m.LessonTime).FirstOrDefault();

            if (d > DateTime.Now)
            {
                var lesson = gym.MemberLessons.FirstOrDefault(ml => ml.MemberLessonLessonId == lessonId);

                lesson.AttendanceTypeId = 1;
                gym.SaveChanges();
                return Content(lessonId.ToString());
            }
            else 
                return Content("0"); 
        }


        public IActionResult odlPassword(string password)
        {
            string loginPassword = gym.LogIns.Where(l => l.LogInId == CUserLogin.memberId).Select(l => l.LogInPassword).FirstOrDefault();
            if (password == loginPassword)
            {
                return Json("密碼正確");
            }
            return Json("密碼輸入錯誤");
        }


        public IActionResult passwordChange(string password1, string password2)
        {
            if (password1 != password2)
            {
                return Json("新密碼需輸入相同");
            }

            if (HasSessino())
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                CUserLogin.memberId = user.LogInId;

                string loginPassword = gym.LogIns.Where(l => l.LogInId == CUserLogin.memberId).Select(l => l.LogInPassword).FirstOrDefault();

                if (password2 != loginPassword)
                {
                    if ((new Regex(@"^[a-zA-Z]\w{5,17}$")).IsMatch(password2))
                    {

                        LogIn login = gym.LogIns.FirstOrDefault(l => l.LogInId == CUserLogin.memberId);

                        if (login != null)
                        {
                            login.LogInPassword = password2;
                            gym.SaveChanges();
                        }

                        return Json("");
                    }
                    return Json("新密碼格式錯誤");
                }
                else if (password2 == loginPassword)
                {
                    return Json("新密碼不得與舊密碼相同");
                }

            }

            return Json("K");
        }
    }
}
