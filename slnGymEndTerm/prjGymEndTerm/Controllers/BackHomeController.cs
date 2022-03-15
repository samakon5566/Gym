using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{
    public class BackHomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly GYMContext gym;
        public BackHomeController(IWebHostEnvironment p, GYMContext context)
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

                ViewBag.LogInName = user.LogInName;
                ViewBag.LogInTypeId = user.LogInTypeId;
                ViewBag.LogInId = user.LogInId;

                return true;
            }
            CUserLogin.memberName = null;
            CUserLogin.memberType = -1;
            CUserLogin.memberId = -1;
            return false;
        }

        public IActionResult List()
        {
            if (HasSessino())
            {
                CBackHome backHome = new CBackHome
                {
                    maleCount = memberCount("male"),
                    femaleCount = memberCount("female"),
                    memberTotal = memberCount("male") + memberCount("female"),

                    category1Count = classCount(1),  //有氧
                    category2Count = classCount(2),  //拳擊
                    category3Count = classCount(3),  //瑜珈
                    category4Count = classCount(4),  //重訓
                    category5Count = classCount(5),  //飛輪
                    category6Count = classCount(6),  //TRX
                    classTotal = classCount(1)+ classCount(2)+ classCount(3)+ classCount(4)+ classCount(5)+ classCount(6),

                    category1Money = Convert.ToInt32(classMoney(1)),
                    category2Money = Convert.ToInt32(classMoney(2)),
                    category3Money = Convert.ToInt32(classMoney(3)),
                    category4Money = Convert.ToInt32(classMoney(4)),
                    category5Money = Convert.ToInt32(classMoney(5)),
                    category6Money = Convert.ToInt32(classMoney(6)),
                    moneyTotal = Convert.ToInt32(classMoney(1)) + Convert.ToInt32(classMoney(2)) + Convert.ToInt32(classMoney(3)) +
                                                Convert.ToInt32(classMoney(4)) + Convert.ToInt32(classMoney(5)) + Convert.ToInt32(classMoney(6)),

                    todayMemberCount = gym.LogIns.Where(l => l.LogInTypeId == 2 && l.LogInRegisterTime.Date == DateTime.Now.Date).Count(),
                    todayOrderCount = gym.OrderCourses.Where(o => o.OrderTime.Date == DateTime.Now.Date).Count(),
                    todayClassMoney = Convert.ToInt32(todayClassMoney())
                };
                return View(backHome);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        public IActionResult Edit() 
        {
            if (HasSessino())
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));

                LogIn staff = gym.LogIns.FirstOrDefault(l => l.LogInId == user.LogInId);               
                return View(new CLoginViewModel() {login= staff });
            }
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public IActionResult Edit(CLoginViewModel loginVM)
        {
            LogIn staff = gym.LogIns.FirstOrDefault(l => l.LogInId == loginVM.LogInId);

            if (staff != null)
            {
                staff.LogInName = loginVM.LogInName;
                staff.LogInGender = loginVM.LogInGender;
                staff.LogInBrithDay = loginVM.LogInBrithDay;
                staff.LogInPhone = loginVM.LogInPhone;
                staff.LogInEmail = loginVM.LogInEmail;
                //staff.LogInPassword = loginVM.LogInPassword;
                gym.SaveChanges();
            }

            return RedirectToAction("Login", "Home");
        }

        public IActionResult EditPassword(CLoginViewModel loginVM)
        {
            LogIn staff = gym.LogIns.FirstOrDefault(l => l.LogInId == loginVM.LogInId);

            if (staff != null)
            {
                staff.LogInPassword = loginVM.LogInPassword;
                gym.SaveChanges();
            }
            return RedirectToAction("Login", "Home");
        }

        public int memberCount(string gender)
        {
            int count = 0;
            var memberCount = from login in gym.LogIns
                              where login.LogInTypeId == 2 && login.LogInGender == gender && login.LogInRegisterTime.Year==DateTime.Now.Year 
                              && login.LogInRegisterTime.Month==DateTime.Now.Month
                              select new { login };

            count = memberCount.Count();
            return count;
        }

        public int classCount( int CourseCategory_ID)
        {
            int count = 0;

            var classCount = from cclass in gym.CourseClasses
                             where cclass.CourseClassDetail.CourseCategoryId == CourseCategory_ID && cclass.Lessons.Min(l=>l.LessonTime).Year==DateTime.Now.Year
                             && cclass.Lessons.Min(l => l.LessonTime).Month== DateTime.Now.Month
                             select new { cclass };

            count = classCount.Count();
            return count;
        }

        public decimal classMoney(int CourseCategory_ID)
        {
            decimal money = 0;

            var classMoney = from order in gym.OrderCourses
                             join cclass in gym.CourseClasses on order.OrderClassId equals cclass.CourseClassId
                             join detail in gym.CourseDetails on cclass.CourseClassDetailId equals detail.CourseDetailId
                             join dicount in gym.Dicounts on cclass.CourseClassPlan.Dicount.DicountId equals dicount.DicountId
                             where order.OrderClass.CourseClassDetail.CourseCategoryId == CourseCategory_ID && order.OrderTime.Year==DateTime.Now.Year
                             && order.OrderTime.Month== DateTime.Now.Month
                             select new { order, cclass, detail, dicount };

            foreach (var item in classMoney.ToList())
            {
                money += Convert.ToDecimal(item.detail.CourseDetailMoney) * Convert.ToDecimal(item.dicount.DiscountPercent);
            }

            return money;
        }

        public decimal todayClassMoney()
        {
            decimal todayMoney = 0;
            var todayClassMoney=from order in gym.OrderCourses
                                join cclass in gym.CourseClasses on order.OrderClassId equals cclass.CourseClassId
                                join detail in gym.CourseDetails on cclass.CourseClassDetailId equals detail.CourseDetailId
                                join dicount in gym.Dicounts on cclass.CourseClassPlan.Dicount.DicountId equals dicount.DicountId
                                where order.OrderTime.Date == DateTime.Now.Date
                                select new { order, cclass, detail, dicount };

            foreach (var item in todayClassMoney.ToList())
            {
                todayMoney += Convert.ToDecimal(item.detail.CourseDetailMoney) * Convert.ToDecimal(item.dicount.DiscountPercent);
            }

            return todayMoney;
        }
    }
}
