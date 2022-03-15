using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using prjGymEndTerm.ViewModels.GroupCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace prjGymEndTerm.Controllers
{
    public class GroupCourseController : Controller
    {
        private readonly GYMContext _gymcontext;

        public GroupCourseController(GYMContext gymcontext)
        {
            _gymcontext = gymcontext;
        }
        /// <summary>
        /// 團體課程介紹controller
        /// </summary>
        /// <returns></returns>
        public IActionResult 課程介紹團體課()
        {
            return View();
        }

        /// <summary>
        /// 課程有氧介紹controller
        /// </summary>
        /// <returns></returns>
        
        public IActionResult 課程介紹有氧()
        {
            //CCourseDetailViewmodel CourseDetail = new CCourseDetailViewmodel();

            var Aerobic = _gymcontext.CourseDetails.Where(c => c.CourseCategory.CourseCategoryId == 1);
            List<CCourseDetailViewmodel> list = new List<CCourseDetailViewmodel>();
            foreach (var item in Aerobic)
            {
                list.Add(new CCourseDetailViewmodel() { coursedetail =  item});
            }
            ViewBag.count = ((list.Count() * 400) + 1500) + "px";

            return View(list);
        }

        /// <summary>
        /// 課程拳擊介紹controller
        /// </summary>
        /// <returns></returns>
        public IActionResult 課程介紹拳擊()
        {
            var Aerobic = _gymcontext.CourseDetails.Where(c => c.CourseCategory.CourseCategoryId == 2);

            List<CCourseDetailViewmodel> list = new List<CCourseDetailViewmodel>();
            foreach (var item in Aerobic)
            {
                list.Add(new CCourseDetailViewmodel() { coursedetail = item });
            }
            ViewBag.count = ((list.Count() * 400) + 1500) + "px";

            return View(list);
        }
        /// <summary>
        /// 課程瑜珈介紹controller
        /// </summary>
        /// <returns></returns>
        public IActionResult 課程介紹瑜珈()
        {
            var Aerobic = _gymcontext.CourseDetails.Where(c => c.CourseCategory.CourseCategoryId == 3);

            List<CCourseDetailViewmodel> list = new List<CCourseDetailViewmodel>();
            foreach (var item in Aerobic)
            {
                list.Add(new CCourseDetailViewmodel() { coursedetail = item });
            }
            ViewBag.count = ((list.Count() * 400) + 1500) + "px";

            return View(list);
        }
        /// <summary>
        /// 課程重訓介紹controller
        /// </summary>
        /// <returns></returns>
        public IActionResult 課程介紹重訓()
        {
            return View();
        }
        /// <summary>
        /// 課程飛輪介紹controller
        /// </summary>
        /// <returns></returns>
        public IActionResult 課程介紹飛輪()
        {
            var Aerobic = _gymcontext.CourseDetails.Where(c => c.CourseCategory.CourseCategoryId == 5);
            List<CCourseDetailViewmodel> list = new List<CCourseDetailViewmodel>();
            foreach (var item in Aerobic)
            {
                list.Add(new CCourseDetailViewmodel() { coursedetail = item });
            }
            ViewBag.count = ((list.Count() * 400) + 1500) + "px";

            return View(list);
        }
        /// <summary>
        /// 課程TRX介紹controller
        /// </summary>
        /// <returns></returns>
        public IActionResult 課程介紹TRX()
        {
            var Aerobic = _gymcontext.CourseDetails.Where(c => c.CourseCategory.CourseCategoryId == 6);

            List<CCourseDetailViewmodel> list = new List<CCourseDetailViewmodel>();
            foreach (var item in Aerobic)
            {
                list.Add(new CCourseDetailViewmodel() { coursedetail = item });
            }
            ViewBag.count = ((list.Count() * 400) + 1500) + "px";

            return View(list);
        }
        /// <summary>
        /// 授課教練介紹controller
        /// </summary>
        /// <return s></returns>
        public IActionResult 授課教練介紹()
        {
            var coachcount = _gymcontext.LogIns.Where(l => l.LogInTypeId.Equals(3)).Select(l => l.LogInId).Count();
            return View(coachcount);
        }

        public IActionResult CoachComment(int id)
        {
            var CoachJson = _gymcontext.MemberScores.Where(m => m.CourseClass.CourseClassCoachId.Equals(id) && m.CourseClass.Lessons.All(l=>l.LessonTime< DateTime.UtcNow))
                .OrderByDescending(m=>m.ClassRecord)
                .Select(m => new
                {
                    memberfigure = m.Member.LoginFigure,
                    membername = m.Member.LogInName,
                    membercomment = m.Classcomment,
                    memberRecord = (Convert.ToDateTime(m.ClassRecord)),
                });

            ViewBag.coachJson = JsonConvert.SerializeObject(CoachJson.ToList());
            return Json(CoachJson);
        }

        public IActionResult CoachFilterShow(int? id) 
        {
            if(id == null)
            {
                var CoachJson = from l in _gymcontext.LogIns.Where(l => l.LogInTypeId.Equals(3))
                                select new
                                {
                                    coachID = l.LogInId,
                                    //todo 圖片
                                    coachfigure = l.LoginFigure,
                                    coachname = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l=>l.LessonTime < DateTime.UtcNow)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    coachbackground = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.UtcNow)).Select(c => c.MemberScores.Count())
                                };
                ViewBag.coachJson = JsonConvert.SerializeObject(CoachJson.ToList());
                return Json(CoachJson);
            }
            else
            {
                var CoachJson = from l in _gymcontext.LogIns.Where(l => l.LogInTypeId.Equals(3) && l.Coach.Skills.Any(s => s.SkillCourseCategoryId.Equals(id)))
                                select new
                                {
                                    coachID = l.LogInId,
                                    //todo 圖片
                                    coachfigure = l.LoginFigure,
                                    coachname = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.UtcNow)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    coachbackground = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.UtcNow)).Select(c => c.MemberScores.Count())
                                };
                ViewBag.coachJson = JsonConvert.SerializeObject(CoachJson.ToList());
                return Json(CoachJson);
            }
        }

        public IActionResult CoachFilter(string flag,int[] flag2,CCoachMutiFilterViewModel filterVM)
        {
            List<CCoachDisplayViewModel> dvlist = filterVM.isWhichFiltWay(flag, flag2, _gymcontext);
            return Json(dvlist);
        }

        /// <summary>
        /// 課程
        /// </summary>
        /// <returns></returns>
        public IActionResult 課程與選購()
        {            
            return View();
        }
        public IActionResult InitailzePriceRange()
        {
            var moneyrange = _gymcontext.CourseDetails.Select(d => d.CourseDetailMoney);
            return Json(moneyrange.Distinct());
        }
        public IActionResult ShowcCorseDetail(int id)
        {
            var Details = _gymcontext.CourseDetails.Where(c => c.CourseCategoryId.Equals(id)).Select(c =>new { c.CourseDetailName ,c.CourseDetailId});
            return Json(Details);
        }

        public IActionResult Showclass(List<string> id,string keyword,int[] moneyrange)
        {
            int moneyrangecount = moneyrange.Length;
            if (moneyrangecount != 0)
            {
                if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
                {
                    LogIn user = System.Text.Json.JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                    var courseorder = _gymcontext.OrderCourses.Where(o => o.OrderMemberId.Equals(user.LogInId)).Select(o => o.OrderClassId);
                    if (string.IsNullOrEmpty(keyword))
                    {
                        if (id.FirstOrDefault() != null)
                        {
                            var events = _gymcontext.CourseClasses.Where(c => !courseorder.Contains(c.CourseClassId) && c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && id.Contains(c.CourseClassDetail.CourseDetailName) && c.Lessons.All(c => c.LessonTime > DateTime.UtcNow)).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                        else
                        {
                            var events = _gymcontext.CourseClasses.Where(c => !courseorder.Contains(c.CourseClassId) && c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && c.Lessons.All(l => l.LessonTime > DateTime.UtcNow)).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                    }
                    else
                    {
                        if (id.FirstOrDefault() != null)
                        {
                            var events = _gymcontext.CourseClasses.Where(c => !courseorder.Contains(c.CourseClassId) && c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && id.Contains(c.CourseClassDetail.CourseDetailName) && c.Lessons.All(c => c.LessonTime > DateTime.UtcNow) && (c.CourseClassName.Contains(keyword)||c.CourseClassCoach.CoachNavigation.LogInName.Contains(keyword))).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                        else
                        {
                            var events = _gymcontext.CourseClasses.Where(c => !courseorder.Contains(c.CourseClassId) && c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && c.Lessons.All(l => l.LessonTime > DateTime.UtcNow) && (c.CourseClassName.Contains(keyword) || c.CourseClassCoach.CoachNavigation.LogInName.Contains(keyword))).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                    }

                }
                else
                {
                    if (string.IsNullOrEmpty(keyword))
                    {
                        if (id.FirstOrDefault() != null)
                        {
                            var events = _gymcontext.CourseClasses.Where(c => c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && id.Contains(c.CourseClassDetail.CourseDetailName) && c.Lessons.All(c => c.LessonTime > DateTime.UtcNow)).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                        else
                        {
                            var events = _gymcontext.CourseClasses.Where(c => c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && c.Lessons.All(l => l.LessonTime > DateTime.UtcNow)).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                    }
                    else
                    {
                        if (id.FirstOrDefault() != null)
                        {
                            var events = _gymcontext.CourseClasses.Where(c => c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && id.Contains(c.CourseClassDetail.CourseDetailName) && c.Lessons.All(c => c.LessonTime > DateTime.UtcNow) && (c.CourseClassName.Contains(keyword) || c.CourseClassCoach.CoachNavigation.LogInName.Contains(keyword))).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                        else
                        {
                            var events = _gymcontext.CourseClasses.Where(c => c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && c.Lessons.All(l => l.LessonTime > DateTime.UtcNow) && (c.CourseClassName.Contains(keyword) || c.CourseClassCoach.CoachNavigation.LogInName.Contains(keyword))).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                    }
                }
            }
            else
            {
                if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
                {
                    LogIn user = System.Text.Json.JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                    var courseorder = _gymcontext.OrderCourses.Where(o => o.OrderMemberId.Equals(user.LogInId)).Select(o => o.OrderClassId);
                    if (string.IsNullOrEmpty(keyword))
                    {
                        if (id.FirstOrDefault() != null)
                        {
                            var events = _gymcontext.CourseClasses.Where(c => !courseorder.Contains(c.CourseClassId) && c.CourseClassDetail.CourseDetailMoney >= 2000 && c.CourseClassDetail.CourseDetailMoney <= 6000 && id.Contains(c.CourseClassDetail.CourseDetailName) && c.Lessons.All(c => c.LessonTime > DateTime.UtcNow)).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                        else
                        {
                            var events = _gymcontext.CourseClasses.Where(c => !courseorder.Contains(c.CourseClassId) && c.CourseClassDetail.CourseDetailMoney >= 2000 && c.CourseClassDetail.CourseDetailMoney <= 6000 && c.Lessons.All(l => l.LessonTime > DateTime.UtcNow)).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                    }
                    else
                    {
                        if (id.FirstOrDefault() != null)
                        {
                            var events = _gymcontext.CourseClasses.Where(c => !courseorder.Contains(c.CourseClassId) && c.CourseClassDetail.CourseDetailMoney >= 2000 && c.CourseClassDetail.CourseDetailMoney <= 6000 && id.Contains(c.CourseClassDetail.CourseDetailName) && c.Lessons.All(c => c.LessonTime > DateTime.UtcNow) &&( c.CourseClassName.Contains(keyword) || c.CourseClassCoach.CoachNavigation.LogInName.Contains(keyword))).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                        else
                        {
                            var events = _gymcontext.CourseClasses.Where(c => !courseorder.Contains(c.CourseClassId) && c.CourseClassDetail.CourseDetailMoney >= 2000 && c.CourseClassDetail.CourseDetailMoney <= 6000 && c.Lessons.All(l => l.LessonTime > DateTime.UtcNow) && (c.CourseClassName.Contains(keyword) || c.CourseClassCoach.CoachNavigation.LogInName.Contains(keyword))).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                    }

                }
                else
                {
                    if (string.IsNullOrEmpty(keyword))
                    {
                        if (id.FirstOrDefault() != null)
                        {
                            var events = _gymcontext.CourseClasses.Where(c => c.CourseClassDetail.CourseDetailMoney >= 2000 && c.CourseClassDetail.CourseDetailMoney <= 6000 && id.Contains(c.CourseClassDetail.CourseDetailName) && c.Lessons.All(c => c.LessonTime > DateTime.UtcNow)).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                        else
                        {
                            var events = _gymcontext.CourseClasses.Where(c => c.CourseClassDetail.CourseDetailMoney >= 2000 && c.CourseClassDetail.CourseDetailMoney <= 6000 && c.Lessons.All(l => l.LessonTime > DateTime.UtcNow)).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                    }
                    else
                    {
                        if (id.FirstOrDefault() != null)
                        {
                            var events = _gymcontext.CourseClasses.Where(c => c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && id.Contains(c.CourseClassDetail.CourseDetailName) && c.Lessons.All(c => c.LessonTime > DateTime.UtcNow) && (c.CourseClassName.Contains(keyword) || c.CourseClassCoach.CoachNavigation.LogInName.Contains(keyword))).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                        else
                        {
                            var events = _gymcontext.CourseClasses.Where(c => c.CourseClassDetail.CourseDetailMoney >= moneyrange.FirstOrDefault() && c.CourseClassDetail.CourseDetailMoney <= moneyrange[1] && c.Lessons.All(l => l.LessonTime > DateTime.UtcNow) &&( c.CourseClassName.Contains(keyword) || c.CourseClassCoach.CoachNavigation.LogInName.Contains(keyword))).
                            Select(c => new
                            {
                                id = c.CourseClassId,
                                start = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime).Take(1),
                                end = c.Lessons.Where(a => a.LessonClassId.Equals(c.CourseClassId)).Select(a => a.LessonTime.AddHours(1)).Take(1),
                                title = c.CourseClassName,
                                category = c.CourseClassDetail.CourseCategoryId
                            });
                            return Json(events);
                        }
                    }
                }
            }


        }


        public IActionResult ShowLessons(string name)
        {
            //建立課表內畫面
            var SelectedClass = _gymcontext.CourseClasses.Where(c => c.CourseClassName.Equals(name)).Select(c => new
            {
                detailname = c.CourseClassDetail.CourseDetailName,
                coach = c.CourseClassCoach.CoachNavigation.LogInName,
                classpictrue = c.CourseClassDetail.CourseDetailPicture,
                classID = c.CourseClassId,                 
                classname = c.CourseClassName,
                actuallymoney = Convert.ToDecimal(c.CourseClassDetail.CourseDetailMoney) * c.CourseClassPlan.Dicount.DiscountPercent,
                money = c.CourseClassDetail.CourseDetailMoney,
                dicount = c.CourseClassPlan.DiscountPlan1,
                lesson = c.Lessons.Where(l=>l.LessonClassId.Equals(c.CourseClassId)).Select(l=>l.LessonTime),
                vacancy = c.CourseClassPeople,
                classpeople = c.CourseClassPeople - c.OrderCourses.Count
            });
            return Json(SelectedClass);
        }
                   




    }
}
