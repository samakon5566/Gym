using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{
    public class BackApiController : Controller
    {
        private readonly GYMContext gym;
        public BackApiController(GYMContext context)
        {
            gym = context;
        }
        public IActionResult categorySelect()
        {
            var category = gym.CourseCategories;
            return Json(category);
        }

        public IActionResult scoreYearsSelect()
        {
            var years = gym.MemberScores.Select(s=>((DateTime)s.ClassRecord).Year).Distinct();
            return Json(years);
        }

        public IActionResult scoreCoachSelect()
        {
            var coach = gym.LogIns.Where(l => l.LogInTypeId == 3);
            return Json(coach);
        }

        public IActionResult scoreYearsCount(int year)
        {

            int[] data = new int[5];
            data[0] = new CScore().yearScoreCount(gym, year, 1);
            data[1] = new CScore().yearScoreCount(gym, year, 2);
            data[2] = new CScore().yearScoreCount(gym, year, 3);
            data[3] = new CScore().yearScoreCount(gym, year, 4);
            data[4] = new CScore().yearScoreCount(gym, year, 5);

            if (year == 0)
            {
                data[0] = new CScore().ALLScoreCount(gym, 1);
                data[1] = new CScore().ALLScoreCount(gym, 2);
                data[2] = new CScore().ALLScoreCount(gym, 3);
                data[3] = new CScore().ALLScoreCount(gym, 4);
                data[4] = new CScore().ALLScoreCount(gym, 5);
            }

            return Json(data);
        }

        public IActionResult scoreCategoryCount(int year, int categoryID)
        {
            int[] data = new int[5];

            if (year != 0 && categoryID == 0)
            {
                data[0] = new CScore().yearScoreCount(gym, year, 1);
                data[1] = new CScore().yearScoreCount(gym, year, 2);
                data[2] = new CScore().yearScoreCount(gym, year, 3);
                data[3] = new CScore().yearScoreCount(gym, year, 4);
                data[4] = new CScore().yearScoreCount(gym, year, 5);
            }

            else if (year == 0 && categoryID != 0)
            {
                data[0] = new CScore().categoryScoreCount(gym, categoryID, 1);
                data[1] = new CScore().categoryScoreCount(gym, categoryID, 2);
                data[2] = new CScore().categoryScoreCount(gym, categoryID, 3);
                data[3] = new CScore().categoryScoreCount(gym, categoryID, 4);
                data[4] = new CScore().categoryScoreCount(gym, categoryID, 5);
            }

            else if (year != 0 && categoryID != 0)
            {
                data[0] = new CScore().categoryAndYearScoreCount(gym, year, categoryID, 1);
                data[1] = new CScore().categoryAndYearScoreCount(gym, year, categoryID, 2);
                data[2] = new CScore().categoryAndYearScoreCount(gym, year, categoryID, 3);
                data[3] = new CScore().categoryAndYearScoreCount(gym, year, categoryID, 4);
                data[4] = new CScore().categoryAndYearScoreCount(gym, year, categoryID, 5);
            }

            else if (year == 0 && categoryID == 0)
            {
                data[0] = new CScore().ALLScoreCount(gym, 1);
                data[1] = new CScore().ALLScoreCount(gym, 2);
                data[2] = new CScore().ALLScoreCount(gym, 3);
                data[3] = new CScore().ALLScoreCount(gym, 4);
                data[4] = new CScore().ALLScoreCount(gym, 5);
            }

            return Json(data);
        }


        public IActionResult scoreCoachCount(int year,int coachID)
        {
            int[] data = new int[5];

            if (year != 0 && coachID == 0)
            {
                data[0] = new CScore().yearScoreCount(gym, year, 1);
                data[1] = new CScore().yearScoreCount(gym, year, 2);
                data[2] = new CScore().yearScoreCount(gym, year, 3);
                data[3] = new CScore().yearScoreCount(gym, year, 4);
                data[4] = new CScore().yearScoreCount(gym, year, 5);
            }

            else if (year == 0 && coachID != 0)
            {
                data[0] = new CScore().coachScoreCount(gym, coachID, 1);
                data[1] = new CScore().coachScoreCount(gym, coachID, 2);
                data[2] = new CScore().coachScoreCount(gym, coachID, 3);
                data[3] = new CScore().coachScoreCount(gym, coachID, 4);
                data[4] = new CScore().coachScoreCount(gym, coachID, 5);
            }

            else if (year != 0 && coachID != 0)
            {
            data[0] = new CScore().coachAndYearScoreCount(gym, year, coachID, 1);
            data[1] = new CScore().coachAndYearScoreCount(gym, year, coachID, 2);
            data[2] = new CScore().coachAndYearScoreCount(gym, year, coachID, 3);
            data[3] = new CScore().coachAndYearScoreCount(gym, year, coachID, 4);
            data[4] = new CScore().coachAndYearScoreCount(gym, year, coachID, 5);
            }
            
           else if (year == 0 && coachID==0)
            {
                data[0] = new CScore().ALLScoreCount(gym, 1);
                data[1] = new CScore().ALLScoreCount(gym, 2);
                data[2] = new CScore().ALLScoreCount(gym, 3);
                data[3] = new CScore().ALLScoreCount(gym, 4);
                data[4] = new CScore().ALLScoreCount(gym, 5);
            }

            return Json(data);
        }


        public IActionResult detailSelect(int CourseCategoryId)
        {
            var detail = gym.CourseDetails.Where(d => d.CourseCategoryId == CourseCategoryId)
                .Select(d => new { d.CourseDetailId, d.CourseDetailName }).Distinct();

            return Json(detail);
        }
        public IActionResult classSelect(int CourseDetailId)
        {
            var cclass = gym.CourseClasses.Where(c => c.CourseClassDetailId == CourseDetailId)
                .Select(c => new { c.CourseClassId, c.CourseClassName }).Distinct();
            return Json(cclass);
        }

        public IActionResult coachSelect(int SkillCourseCategoryId)
        {
            var coach = gym.Skills.Where(s => s.SkillCourseCategoryId == SkillCourseCategoryId)
                .Select(s => new { s.SkillCoachId, s.SkillCoach.CoachNavigation.LogInName }).Distinct();
            return Json(coach);
        }

        public IActionResult planSelect()
        {
            var plan = gym.DiscountPlans;
            return Json(plan);
        }

        public IActionResult lessonList(DateTime day, int ClassroomId)
        {
            var lessons = from lesson in gym.Lessons
                          orderby lesson.LessonTime
                          join cclass in gym.CourseClasses on lesson.LessonClassId equals cclass.CourseClassId
                          join classroom in gym.Classrooms on cclass.CourseClassClassroomId equals classroom.ClassroomId
                          where lesson.LessonTime.Date == day && classroom.ClassroomId == ClassroomId
                          select new CLessonViewModel()
                          {
                              LessonId = lesson.LessonId,
                              LessonTime = lesson.LessonTime,
                              CourseCategoryName = lesson.LessonClass.CourseClassDetail.CourseCategory.CourseCategoryName,
                              CourseDetailName = lesson.LessonClass.CourseClassDetail.CourseDetailName,
                              CourseClassName = lesson.LessonClass.CourseClassName,
                              ClassroomName = lesson.LessonClass.CourseClassClassroom.ClassroomName,
                              CourseClassCoach = lesson.LessonClass.CourseClassCoach.CoachNavigation.LogInName,
                              ClassroomId = lesson.LessonClass.CourseClassClassroom.ClassroomId,
                          };

            return PartialView(lessons);
        }

        public IActionResult addLessonView()
        {

            List<CLessonViewModel> list = null;
            string json = "";

            if (HttpContext.Session.Keys.Contains(LessonDictionary.lessonList))
            {
                json = HttpContext.Session.GetString(LessonDictionary.lessonList); //取出
                list = JsonSerializer.Deserialize<List<CLessonViewModel>>(json); //轉成物件

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == null)
                        list.RemoveAt(i);
                }

                if (list.Count == 0)
                {
                    return PartialView();//RedirectToAction("backLessonList", "Backstage");
                }

                ViewData["LESSON"] = JsonSerializer.Serialize(list); ;
                return PartialView(list);
            }

            return PartialView();//RedirectToAction("backLessonList", "Backstage");
        }


        public IActionResult moneyInput(int OrderClassId)
        {
            decimal detailmoney = Convert.ToDecimal(gym.CourseClasses.Where(c => c.CourseClassId == OrderClassId)
                                                                                            .Select(c => c.CourseClassDetail.CourseDetailMoney).FirstOrDefault());

            decimal DiscountPercent = gym.CourseClasses.Where(c => c.CourseClassId == OrderClassId)
                                                                .Select(c => c.CourseClassPlan.Dicount.DiscountPercent).FirstOrDefault();

            decimal money = detailmoney * DiscountPercent;

            return Json(money);

        }


        public IActionResult accountInput(string account)
        {
            int memberId = gym.LogIns.Where(l => l.LogInAccount.Contains(account)).Select(l => l.LogInId).FirstOrDefault();

            if (memberId != 0)
            {
                var member = gym.LogIns.Where(l => l.LogInAccount == account);
                return Json(member);
            }
            else
            {
                return Json("查無此帳號");
            }

        }

        public IActionResult accountAndMemberidInput(string txtAccount, string txtIdNum)
        {
            if (!string.IsNullOrEmpty(txtAccount) || !string.IsNullOrEmpty(txtIdNum))
            {
                var account = gym.LogIns.FirstOrDefault(n => n.LogInAccount == txtAccount);
                var IdNum = gym.LogIns.FirstOrDefault(n => n.LogInIdNumber == txtIdNum);
                if (account != null)
                    return Json("重複");

                if (IdNum != null)
                    return Json("重複");
            }

            return Json("OK");

        }


        public IActionResult ForgotPassword(string account, string email)
        {
            int loginID = gym.LogIns.Where(l => l.LogInAccount == account && l.LogInEmail == email)
                                                            .Select(l => l.LogInId).FirstOrDefault();

            if (loginID == 0)
            {
                return Json("沒有資料");
            }
            else
            {
                string newPassword = Guid.NewGuid().ToString();

                LogIn member = gym.LogIns.FirstOrDefault(l => l.LogInId == loginID);
                member.LogInPassword = newPassword;
                gym.SaveChanges();

                LogIn memberDetail = gym.LogIns.FirstOrDefault(l => l.LogInId == loginID);
                return Json(memberDetail);
            }
        }

        public IActionResult createMember(LogIn l)
        {
            var login = gym.LogIns.Select(l => l.LogInAccount);

            if (login.Contains(l.LogInAccount))
            {
                return Content("帳號已被使用");
            }

            gym.Add(l);
            gym.SaveChanges();
            return Content(l.LogInName);

            // return Content($"{ l.LogInName}","text/html",System.Text.Encoding.UTF8);
            //return RedirectToAction("Login", "Home");

        }


        public IActionResult editLessonToSession(string jdata)
        {
            List<CLessonViewModel> list = JsonSerializer.Deserialize<List<CLessonViewModel>>(jdata); //轉成物件

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == null)
                    list.RemoveAt(i);
            }

            string json = JsonSerializer.Serialize(list);  //轉成json
            HttpContext.Session.SetString(LessonDictionary.lessonList, jdata); //丟進Session

            return View(list);
        }

        public IActionResult addLessonCount()
        {

            List<CLessonViewModel> list = null;
            string json = "";

            if (HttpContext.Session.Keys.Contains(LessonDictionary.lessonList))
            {
                json = HttpContext.Session.GetString(LessonDictionary.lessonList); //取出
                list = JsonSerializer.Deserialize<List<CLessonViewModel>>(json); //轉成物件

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == null)
                        list.RemoveAt(i);
                }

                if (list.Count == 0)
                {
                    return Json(0);
                }

                return Json(list.Count);
            }

            return Json(0);
        }



        public IActionResult backClassLessonBtn(int classId)
        {
            var lessons = gym.Lessons.Where(l => l.LessonClassId == classId);
            ViewBag.className = gym.Lessons.Where(l => l.LessonClassId == classId).Select(l => l.LessonClass.CourseClassName).FirstOrDefault();
            return PartialView(lessons);
        }

        public IActionResult backOrderLessonBtn(int classId)
        {
            var lessons = gym.Lessons.Where(l => l.LessonClassId == classId);
            ViewBag.className = gym.Lessons.Where(l => l.LessonClassId == classId).Select(l => l.LessonClass.CourseClassName).FirstOrDefault();
            return PartialView(lessons);
        }

        public IActionResult backCoachBtn(int coachId)
        {
            var coach = from logim in gym.LogIns
                        where logim.LogInId == coachId
                        select new CLoginViewModel()
                        {
                            LogInId=logim.LogInId,
                            LogInIdNumber = logim.LogInIdNumber,
                            LogInBrithDay = logim.LogInBrithDay,
                            LogInEmail = logim.LogInEmail,
                            LogInPhone=logim.LogInPhone,
                            CoachAddress = logim.Coach.CoachAddress,
                        };
            ViewBag.coachName = gym.LogIns.Where(l => l.LogInId == coachId).Select(l => l.LogInName).FirstOrDefault();
            return PartialView(coach);
        }


        public IActionResult classpeople(int OrderClassId)
        {
            int classPeople = gym.CourseClasses.Where(c => c.CourseClassId == OrderClassId).Select(c => c.CourseClassPeople).FirstOrDefault();
            int classOrderPeople = gym.OrderCourses.Where(o => o.OrderClassId == OrderClassId).Count();
            int people = classPeople - classOrderPeople;

            if (people <= 0)
            {
                return Json("◆ 課程已額滿 ◆");
            }
            return Json("");

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

            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
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


        public IActionResult littleBell()
        {
            //現在
            DateTime dt = DateTime.Now;
            int Year = dt.Year;
            int Month = dt.Month;
            int Day = dt.Day;
            int Hour = dt.Hour;
            int min = dt.Minute;

            DateTime start = new DateTime(Year, Month, Day, Hour, min, 00);

            List<CLittleBell> littleBells = new List<CLittleBell>();

            var letter = from l in gym.CustomerLetters where ((DateTime)l.LetterTime).Date == DateTime.Today && l.LetterStatusId==2
                                 select new CLittleBell()
                                 {
                                     ID = l.LetterId,
                                     Time = (start.Subtract((DateTime)l.LetterTime)).Hours + " Hrs "+(start.Subtract((DateTime)l.LetterTime)).Minutes + " mins ago",  //兩時間天數相減
                                     Category="信件提醒",
                                     Action= "backCustomerLetterReplyEdit",
                                 };

            foreach (var item in letter)
            {
                littleBells.Add(item);
            }

            var restoration = from r in gym.EquipmentRestorations
                              where ((DateTime)r.EquipmentStayServiceDay).Date > DateTime.Today && ((DateTime)r.EquipmentStayServiceDay).Date <DateTime.Today.AddDays(30)
                              select new CLittleBell()
                              {
                                  ID=r.RestorationId,
                                  Time = ((DateTime)r.EquipmentStayServiceDay).Date.Subtract(start).Days + " days ago",
                                  Category = "維修提醒",
                                  Action = "backRestorationList",
                              };

            foreach (var item in restoration)
            {
                littleBells.Add(item);
            }

            return PartialView(littleBells);
        }

        public IActionResult classCoachName(int classID)
        {
            string coachName = gym.CourseClasses.Where(c => c.CourseClassId == classID).Select(c => c.CourseClassCoach.CoachNavigation.LogInName).FirstOrDefault();
            return Json(coachName);
        }

        public IActionResult detailTable(int course) 
        {
            if (course==0)
            {
                var detailAll = from detail in gym.CourseDetails
                                orderby detail.CourseCategoryId descending
                                join category in gym.CourseCategories on detail.CourseCategoryId equals category.CourseCategoryId
                                select new { detail, category };

                List<CCourseDetailViewmodel> list = new List<CCourseDetailViewmodel>();

                foreach (var item in detailAll)
                {
                    list.Add(new CCourseDetailViewmodel() { coursedetail = item.detail, coursecategory = item.category });
                }
                return PartialView(list);
            }
            else if (course==1)
            {
                var detailAll = from detail in gym.CourseDetails where detail.CourseCategory.CourseCategoryId !=4
                                orderby detail.CourseCategoryId descending
                                join category in gym.CourseCategories on detail.CourseCategoryId equals category.CourseCategoryId
                                select new { detail, category };

                List<CCourseDetailViewmodel> list = new List<CCourseDetailViewmodel>();

                foreach (var item in detailAll)
                {
                    list.Add(new CCourseDetailViewmodel() { coursedetail = item.detail, coursecategory = item.category });
                }
                return PartialView(list);
            }
            else
            {
                var detailAll = from detail in gym.CourseDetails
                                where detail.CourseCategory.CourseCategoryId == 4
                                orderby detail.CourseCategoryId descending
                                join category in gym.CourseCategories on detail.CourseCategoryId equals category.CourseCategoryId
                                select new { detail, category };

                List<CCourseDetailViewmodel> list = new List<CCourseDetailViewmodel>();

                foreach (var item in detailAll)
                {
                    list.Add(new CCourseDetailViewmodel() { coursedetail = item.detail, coursecategory = item.category });
                }
                return PartialView(list);
            }

        }
    }
}
