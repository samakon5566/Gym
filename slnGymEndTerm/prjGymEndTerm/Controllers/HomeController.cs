using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IWebHostEnvironment _environment;

        private readonly GYMContext gym;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment p, GYMContext context)
        {
            _logger = logger;
            _environment = p;
            gym = context;
        }

        private int HasSessino()
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

                return user.LogInTypeId;
            }
            CUserLogin.memberName = null;
            CUserLogin.memberType = -1;
            CUserLogin.memberId = -1;
            CUserLogin.memberfigure = null;

            ViewBag.LogInName = null;
            ViewBag.LogInTypeId = -1;
            ViewBag.LogInId = -1;
            return 0;
        }

        public IActionResult Index()
        {
            HasSessino();
            var news = gym.News.OrderByDescending(n => n.NewsTime)
                .Select(n => new
                {
                    newstitle = n.NewsTitle,
                    newscontent = n.NewsContent.Trim()
                });
            ViewBag.News = JsonSerializer.Serialize(news.Take(5).ToList());
            return View();
        }

        public IActionResult Alldetail(int id,bool flag)
        {
            if (id != 0)
            {
                if (flag)
                {
                    var hot10 = from o in gym.OrderCourses
                                where o.OrderClass.CourseClassDetail.CourseCategoryId.Equals(id)
                                group o by new { detailname =  o.OrderClass.CourseClassDetail.CourseDetailName , detailpic = o.OrderClass.CourseClassDetail.CourseDetailPicture } into g
                                orderby g.Count() descending
                                select new
                                {
                                    detailinfo = g.Key,
                                };

                    return Json(hot10.Take(9));
                }
                else
                {
                    var recommend10 = from m in gym.MemberScores
                                      where m.CourseClass.CourseClassDetail.CourseCategoryId.Equals(id)
                                      group m by new { detailname = m.CourseClass.CourseClassDetail.CourseDetailName, detailpic = m.CourseClass.CourseClassDetail.CourseDetailPicture } into g
                                       orderby  g.Count() descending, g.Average(s => s.ClassScore) descending
                                       select new
                                       {                              
                                           detailinfo = g.Key,
                                       };

                    return Json(recommend10.Take(9));
                }
            }
            else
            {
                if (flag)
                {
                    var hot10 = from o in gym.OrderCourses
                                group o by new { detailname = o.OrderClass.CourseClassDetail.CourseDetailName, detailpic = o.OrderClass.CourseClassDetail.CourseDetailPicture } into g
                                orderby g.Count() descending
                                select new
                                {
                                    detailinfo = g.Key,
                                };

                    return Json(hot10.Take(9));
                }
                else
                {
                    var recommend10 = from m in gym.MemberScores
                                      group m by new { detailname = m.CourseClass.CourseClassDetail.CourseDetailName, detailpic = m.CourseClass.CourseClassDetail.CourseDetailPicture } into g
                                      orderby g.Count() descending, g.Average(s => s.ClassScore) descending
                                      select new
                                      {
                                          detailinfo = g.Key,
                                      };

                    return Json(recommend10.Take(9));
                }
            }
        }

        public IActionResult OneOnOneCoach()
        {
            var coachs = gym.LogIns.Where(l => l.LogInTypeId.Equals(3)).Select(l => new {
                coachfigure = l.LoginFigure,    
                coachname = l.LogInName,
                coachskill = l.Coach.Skills.Select(s=>s.SkillCourseCategory.CourseCategoryName),
                coachscore = l.Coach.CourseClasses.Where(c => c.CourseClassCoachId.Equals(l.LogInId) && c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore))
            });
            return Json(coachs);
        }

        public IActionResult Login(int? flag)
        {
            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                if (user.LogInTypeId == 1)
                    return RedirectToAction("List", "BackHome");
                if (user.LogInTypeId == 2)
                    return RedirectToAction("List", "PersonalArea");
                if (user.LogInTypeId == 3)
                    return RedirectToAction("List", "Coach");
            }
            return View(flag);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(LoginDictionary.SK_Logined_User);
            CUserLogin.memberName = null;
            CUserLogin.memberType = -1;
            CUserLogin.memberId = -1;
            CUserLogin.memberfigure = null;

            return RedirectToAction("Index", "Home",1);

        }
        //[HttpPost]
        //public IActionResult Login(LoginViewModel p)
        //{
        //    LogIn user = gym.LogIns.FirstOrDefault(c => c.LogInAccount.Equals(p.txtAccount) && c.LogInPassword.Equals(p.txtPassword));
        //    if (user != null)
        //    {
        //        if (user.LogInAccount.Equals(p.txtAccount) && user.LogInPassword.Equals(p.txtPassword))
        //        {
        //            string json = "";
        //            json = JsonSerializer.Serialize(user);
        //            HttpContext.Session.SetString(LoginDictionary.SK_Logined_User, json);
        //            if (user.LogInTypeId == 1)
        //                return RedirectToAction("List", "BackHome");
        //            if (user.LogInTypeId == 2)
        //                return RedirectToAction("List", "PersonalArea");
        //            if (user.LogInTypeId == 3)
        //                return RedirectToAction("List", "Coach");
        //        }
        //    }
        //    return View();
        //}

        public IActionResult Validation(LoginCreateValidationViewModel loginCreateValidation)
        {
            string flag = loginCreateValidation.InformExist();
            return Content(flag);
        }

        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(LogIn l)
        {
            gym.Add(l);
            gym.SaveChanges();
            return RedirectToAction(nameof(HomeController.Login));
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }
        public IActionResult edit()
        {
            GYMContext dbcontext = new GYMContext();
            var all_login = from l in dbcontext.LogIns
                            select l;
            List<CLoginViewModel> list = new List<CLoginViewModel>();
            foreach (LogIn log in all_login)
            {
                list.Add(new CLoginViewModel() { login = log });
            }
            return View(list);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
