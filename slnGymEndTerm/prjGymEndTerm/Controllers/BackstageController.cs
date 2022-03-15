using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjAspCoreDemo.ViewModels;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace prjGymEndTerm.Controllers
{
    public class BackstageController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly GYMContext gym;
        public BackstageController(IWebHostEnvironment p, GYMContext context)
        {
            _environment = p;
            gym = context;
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult errorView(string msg, string url)
        {
            ViewBag.error = msg;
            ViewBag.url = url;
            return View();
        }

        //--------------------報表管理--------------------//

        /// <summary>
        /// 報表分析
        /// </summary>
        /// <returns></returns>
        public IActionResult backReport()
        {
            return View();
        }


        //--------------------客服管理--------------------//

        /// <summary>
        /// 客服信件
        /// </summary>
        /// <returns></returns>
        public IActionResult backCustomerLetterList()
        {

            List<CCustomerLetterViewModel> list = new List<CCustomerLetterViewModel>();

            var letter = from cl in gym.CustomerLetters
                         orderby cl.LetterId descending
                         join s in gym.LetterStatuses on cl.LetterStatusId equals s.LetterStatusId
                         join l in gym.LogIns on cl.LetterManergerId equals l.LogInId
                         into joined
                         from loginJoin in joined.DefaultIfEmpty()
                         select new { cl, s, loginJoin };

            foreach (var item in letter)
            {
                list.Add(new CCustomerLetterViewModel() { customerLetter = item.cl, status = item.s, login = item.loginJoin });
            }

            return View(list);
        }

        /// <summary>
        /// 回覆信件
        /// </summary>
        /// <returns></returns>
        public IActionResult backCustomerLetterReplyEdit(int id)
        {
            CustomerLetter customerLetter = gym.CustomerLetters.FirstOrDefault(l => l.LetterId == id);

            if (customerLetter == null)
            {
                return RedirectToAction("backCustomerLetterList");
            }

            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                ViewBag.name = user.LogInName;
            }

            return View(new CCustomerLetterViewModel() { customerLetter = customerLetter });
        }

        /// <summary>
        /// 回覆信件POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backCustomerLetterReplyEdit(CCustomerLetterViewModel ccl)
        {
            CustomerLetter customerLetter = gym.CustomerLetters.FirstOrDefault(c => c.LetterId == ccl.LetterId);

            if (customerLetter != null)
            {
                customerLetter.LetterManergerContent = ccl.LetterManergerContent;
                customerLetter.LetterManergerId = gym.LogIns.Where(l => l.LogInName == ccl.LetterManagerName).Select(l => l.LogInId).FirstOrDefault();
                customerLetter.LetterStatusId = ccl.LetterStatusId;
                gym.SaveChanges();
            }

            return RedirectToAction("backCustomerLetterList");
        }



        //--------------------評論管理--------------------//

        /// <summary>
        /// 評論管理
        /// </summary>
        /// <returns></returns>
        public IActionResult backScoreList()
        {

            var list = from scores in gym.MemberScores
                       select new CSorceViewModel()
                       {
                           LogInName = scores.Member.LogInName,
                           CourseCategoryName = scores.CourseClass.CourseClassDetail.CourseCategory.CourseCategoryName,
                           CourseClassName = scores.CourseClass.CourseClassName,
                           CoachName = scores.CourseClass.CourseClassCoach.CoachNavigation.LogInName,
                           Classcomment = scores.Classcomment,
                           ClassScore = scores.ClassScore,
                           ClassRecord = scores.ClassRecord,
                           ScoreId=scores.ScoreId
                       };

            return View(list);
        }

        /// <summary>
        /// 評論刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backScoreDelete(int id)
        {
            MemberScore score = gym.MemberScores.FirstOrDefault(s => s.ScoreId == id);

            if (score != null)
            {
                gym.Remove(score);
                gym.SaveChanges();
            }

            return RedirectToAction("backScoreList");
        }

        /// <summary>
        ///  評論分析
        /// </summary>
        /// <returns></returns>
        public IActionResult backScoreAnalysis()
        {
            var scores = from s in gym.MemberScores
                         where s.ClassScore == 5
                         group s by s.CourseClass.CourseClassCoachId
                       into g
                         select new { CoachId = g.Key, count = g.Count() };

            scores = scores.OrderByDescending(g => g.count).Take(5); //id + count

            CScore Cscore = new CScore();
            Cscore.coachName = new List<string>();
            Cscore.coachPicture = new List<string>();
            Cscore.coachScore5Count = new List<int>();

            foreach (var item in scores.ToList())
            {
                var coach = from l in gym.LogIns where l.LogInId == item.CoachId select new { l.LogInName, l.LoginFigure };

                foreach (var i in coach)
                {
                    Cscore.coachName.Add(i.LogInName);
                    Cscore.coachPicture.Add(i.LoginFigure);
                }
                Cscore.coachScore5Count.Add(item.count);

                Cscore.score1Count = new CScore().scoreCount(gym, 1);
                Cscore.score2Count = new CScore().scoreCount(gym, 2);
                Cscore.score3Count = new CScore().scoreCount(gym, 3);
                Cscore.score4Count = new CScore().scoreCount(gym, 4);
                Cscore.score5Count = new CScore().scoreCount(gym, 5);
            };

            return View(Cscore);
        }



        //--------------------人員管理--------------------//

        //會員
        /// <summary>
        /// 會員管理
        /// </summary>
        /// <returns></returns>
        public IActionResult backMemberList()
        {
            List<CLoginViewModel> list = new List<CLoginViewModel>();

            var memberList = gym.LogIns.Where(l => l.LogInType.LoginTypeId == 2).OrderByDescending(l => l.LogInRegisterTime);

            foreach (LogIn l in memberList)
            {
                list.Add(new CLoginViewModel() { login = l });
            }

            return View(list);
        }

        /// <summary>
        /// 新增會員
        /// </summary>
        /// <returns></returns>
        public IActionResult backMemberCreate()
        {
            return View();
        }

        /// <summary>
        /// 新增會員POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backMemberCreate(LogIn l)
        {
            gym.Add(l);
            gym.SaveChanges();

            return RedirectToAction("backMemberList");
        }


        /// <summary>
        /// 會員修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backMemberEdit(int id)
        {
            LogIn member = gym.LogIns.FirstOrDefault(l => l.LogInId == id);

            if (member == null)
            {
                return RedirectToAction("backMemberList");
            }
            return View(new CLoginViewModel() { login = member });
        }

        /// <summary>
        /// 會員修改POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backMemberEdit(CLoginViewModel lc)
        {
            LogIn member = gym.LogIns.FirstOrDefault(l => l.LogInId == lc.LogInId);

            if (member != null)
            {
                member.LogInName = lc.LogInName;
                member.LogInBrithDay = lc.LogInBrithDay;
                member.LogInPhone = lc.LogInPhone;
                member.LogInEmail = lc.LogInEmail;
                gym.SaveChanges();
            }

            return RedirectToAction("backMemberList");
        }

        /// <summary>
        /// 會員刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backMemberDelete(int id)
        {
            try
            {
                LogIn member = gym.LogIns.FirstOrDefault(l => l.LogInId == id);

                if (member != null)
                {
                    gym.Remove(member);
                    gym.SaveChanges();
                }
            }
            catch
            {
                return RedirectToAction("errorView", new { msg = "該會員已有訂單成立紀錄，無法刪除此會員資料。", url = "~/Backstage/backMemberList" });
            }

            return RedirectToAction("backMemberList");
        }


        //教練
        /// <summary>
        /// 教練管理
        /// </summary>
        /// <returns></returns>
        public IActionResult backCoachList()
        {
            var coachs = from logon in gym.LogIns
                         where logon.LogInTypeId == 3
                         select new CLoginViewModel()
                         {
                             LogInId = logon.LogInId,
                             LogInName = logon.LogInName,
                             LogInGender = logon.LogInGender,
                             LogInPhone = logon.LogInPhone,
                             LoginFigures = logon.LoginFigure,
                             CoachExperience = logon.Coach.CoachExperience + DateTime.Today.Year - logon.LogInRegisterTime.Year,
                             coachSkillCategory = gym.Skills.Where(s => s.SkillCoachId == logon.LogInId).Select(s => s.SkillCourseCategory.CourseCategoryName).ToList(),
                             CoachBackground = logon.Coach.CoachBackground,
                         };

            return View(coachs);

        }

        /// <summary>
        /// 新增教練
        /// </summary>
        /// <returns></returns>
        public IActionResult backCoachCreate()
        {
            return View();
        }

        /// <summary>
        /// 新增教練POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backCoachCreate(CLoginViewModel l)
        {
            if (l.LoginFigure != null)
            {
                string figureName = l.LoginFigure.FileName;
                l.LoginFigures = figureName;
                l.LoginFigure.CopyTo(new FileStream(_environment.WebRootPath + @"\img\LoginFigure\" + figureName, FileMode.Create));
            }

            gym.Add(l.login);
            gym.SaveChanges();
            Coach coach = new Coach()
            {
                CoachId = l.login.LogInId,
                CoachAddress = l.CoachAddress,
                CoachExperience = l.CoachExperience,
                CoachBackground = l.CoachBackground
            };

            gym.Add(coach);

            foreach (var categoryID in l.skillAry)
            {
                Skill skill = new Skill()
                {
                    SkillCoachId = l.login.LogInId,
                    SkillCourseCategoryId = categoryID
                };
                gym.Add(skill);
            }

            gym.SaveChanges();

            return RedirectToAction("backCoachList");
        }

        /// <summary>
        /// 教練修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backCoachEdit(int id)
        {
            LogIn coach = gym.LogIns.FirstOrDefault(l => l.LogInId == id);

            if (coach == null)
            {
                return RedirectToAction("backCoachList");
            }
            return View(new CLoginViewModel() { login = coach });
        }

        /// <summary>
        /// 教練修改POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backCoachEdit(CLoginViewModel lc)
        {
            LogIn coach = gym.LogIns.FirstOrDefault(l => l.LogInId == lc.LogInId);

            if (coach != null)
            {
                coach.LogInName = lc.LogInName;
                coach.LogInBrithDay = lc.LogInBrithDay;
                coach.LogInPhone = lc.LogInPhone;
                coach.LogInEmail = lc.LogInEmail;
                gym.SaveChanges();
            }

            return RedirectToAction("backCoachList");
        }

        /// <summary>
        /// 教練刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backCoachDelete(int id)
        {
            try
            {
                var skills = gym.Skills.Where(s => s.SkillCoachId == id);
                foreach (var skill in skills)
                {
                    gym.Remove(skill);
                }

                Coach coach = gym.Coaches.FirstOrDefault(c => c.CoachId == id);
                gym.Remove(coach);

                LogIn coachlogin = gym.LogIns.FirstOrDefault(l => l.LogInId == id);

                if (coachlogin != null)
                {
                    gym.Remove(coachlogin);
                    gym.SaveChanges();
                }
            }
            catch
            {
                return RedirectToAction("errorView", new { msg = "該教練已有開課紀錄，無法刪除此教練資料。", url = "~/Backstage/backCoachList" });
            }

            return RedirectToAction("backCoachList");
        }


        //員工
        /// <summary>
        /// 員工管理
        /// </summary>
        /// <returns></returns>
        public IActionResult backStaffList(CKeywordViewModel kvm)
        {
            List<CLoginViewModel> list = new List<CLoginViewModel>();

            var staffList = gym.LogIns.Where(l => l.LogInType.LoginTypeId == 1);

            foreach (var item in staffList)
            {
                list.Add(new CLoginViewModel() { login = item });
            }

            return View(list);
        }

        /// <summary>
        /// 新增員工
        /// </summary>
        /// <returns></returns>
        public IActionResult backStaffCreate()
        {
            return View();
        }

        /// <summary>
        /// 新增教練POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backStaffCreate(LogIn l)
        {
            gym.Add(l);
            gym.SaveChanges();

            return RedirectToAction("backStaffList");
        }

        /// <summary>
        /// 員工修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backStaffEdit(int id)
        {
            LogIn Staff = gym.LogIns.FirstOrDefault(l => l.LogInId == id);

            if (Staff == null)
            {
                return RedirectToAction("backStaffList");
            }
            return View(new CLoginViewModel() { login = Staff });
        }

        /// <summary>
        /// 員工修改POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backStaffEdit(CLoginViewModel lc)
        {
            LogIn Staff = gym.LogIns.FirstOrDefault(l => l.LogInId == lc.LogInId);

            if (Staff != null)
            {
                Staff.LogInName = lc.LogInName;
                Staff.LogInBrithDay = lc.LogInBrithDay;
                Staff.LogInPhone = lc.LogInPhone;
                Staff.LogInEmail = lc.LogInEmail;
                gym.SaveChanges();
            }

            return RedirectToAction("backStaffList");
        }

        /// <summary>
        /// 員工刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backStaffDelete(int id)
        {
            try
            {
                LogIn Staff = gym.LogIns.FirstOrDefault(l => l.LogInId == id);

                if (Staff != null)
                {
                    gym.Remove(Staff);
                    gym.SaveChanges();
                }
            }
            catch
            {
                return RedirectToAction("errorView", new { msg = "該員工已有異動資料紀錄，無法刪除此員工資料。", url = "~/Backstage/backStaffList" });
            }

            return RedirectToAction("backStaffList");
        }


        //--------------------公告管理--------------------//


        /// <summary>
        /// 公告管理
        /// </summary>
        /// <returns></returns>
        public IActionResult backNewsList()
        {

            List<CNewsViewModel> list = new List<CNewsViewModel>();

            var news = from n in gym.News
                       orderby n.NewsTime descending
                       join l in gym.LogIns on n.NewsManagerId equals l.LogInId
                       join t in gym.NewsTypes on n.NewsTypeId equals t.NewsTypeId
                       select new { n, l, t };

            foreach (var item in news)
            {
                list.Add(new CNewsViewModel() { news = item.n, login = item.l, newsType = item.t });
            }

            return View(list);
        }


        /// <summary>
        /// 新增公告
        /// </summary>
        /// <returns></returns>
        public IActionResult backNewsCreate()
        {
            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                ViewBag.name = user.LogInName;
            }
            return View();
        }

        /// <summary>
        /// 新增公告POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backNewsCreate(CNewsViewModel cn)
        {
            if (cn.NewsFigure != null)
            {
                string figureName = cn.NewsFigure.FileName;
                cn.news.NewsFigure = figureName;
                cn.NewsFigure.CopyTo(new FileStream(_environment.WebRootPath + @"\img\news\" + figureName, FileMode.Create));
            }
            cn.NewsManagerId = gym.LogIns.Where(l => l.LogInName == cn.NewsManagerName).Select(l => l.LogInId).FirstOrDefault();
            cn.NewsContent = cn.NewsContent.Trim();

            gym.Add(cn.news);
            gym.SaveChanges();

            return RedirectToAction("backNewsList");
        }

        /// <summary>
        /// 公告修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backNewsEdit(int id)
        {
            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
            {
                LogIn user = JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                ViewBag.name = user.LogInName;
            }

            News news = gym.News.FirstOrDefault(n => n.NewsId == id);

            if (news == null)
            {
                return RedirectToAction("backNewsList");
            }
            return View(new CNewsViewModel() { news = news });
        }

        /// <summary>
        /// 公告修改POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backNewsEdit(CNewsViewModel cn)
        {
            News news = gym.News.FirstOrDefault(n => n.NewsId == cn.NewsId);

            if (news != null)
            {
                if (cn.NewsFigure != null)
                {
                    string figureName = cn.NewsFigure.FileName;
                    news.NewsFigure = figureName;
                    cn.NewsFigure.CopyTo(new FileStream(_environment.WebRootPath + @"\img\news\" + figureName, FileMode.Create));
                }
                news.NewsTypeId = cn.NewsTypeId;
                news.NewsTitle = cn.NewsTitle;
                news.NewsContent = cn.NewsContent;
                news.NewsTime = cn.NewsTime;
                news.NewsManagerId = gym.LogIns.Where(l => l.LogInName == cn.NewsManagerName).Select(l => l.LogInId).FirstOrDefault();

                gym.SaveChanges();
            }

            return RedirectToAction("backNewsList");
        }

        /// <summary>
        /// 公告刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backNewsDelete(int id)
        {
            News news = gym.News.FirstOrDefault(n => n.NewsId == id);

            if (news != null)
            {
                gym.Remove(news);
                gym.SaveChanges();
            }

            return RedirectToAction("backNewsList");
        }






        //--------------------訂單管理--------------------//

        /// <summary>
        /// 訂單管理
        /// </summary>
        /// <returns></returns>
        public IActionResult backOrderList()
        {
            List<COrderCourseViewModel> list = new List<COrderCourseViewModel>();

            var orderList = from order in gym.OrderCourses
                            orderby order.OrderTime descending
                            join login in gym.LogIns on order.OrderMemberId equals login.LogInId
                            join cClass in gym.CourseClasses on order.OrderClassId equals cClass.CourseClassId
                            join cDetail in gym.CourseDetails on cClass.CourseClassDetailId equals cDetail.CourseDetailId
                            join pay in gym.Payments on order.OrderPaymentId equals pay.PaymentId
                            join status in gym.OrderStatuses on order.OrderStatusId equals status.StatusId
                            join dicount in gym.Dicounts on cClass.CourseClassPlan.Dicount.DicountId equals dicount.DicountId
                            join plan in gym.DiscountPlans on cClass.CourseClassPlan.DiscountPlanId equals plan.DiscountPlanId
                            join reason in gym.RefundReasons on order.OrderReasonId equals reason.ReasonId into joined
                            from joinReason in joined.DefaultIfEmpty()
                            select new { order, login, cClass, cDetail, pay, status, plan, joinReason, dicount };


            foreach (var item in orderList)
            {
                list.Add(new COrderCourseViewModel()
                {
                    orderCourse = item.order,
                    login = item.login,
                    courseclass = item.cClass,
                    courseDetail = item.cDetail,
                    dicount = item.dicount,
                    payment = item.pay,
                    orderStatus = item.status,
                    discountPlan = item.plan,
                    refundReason = item.joinReason
                });
            }
            return View(list);
        }

        //Include寫法
        public IActionResult backOrderListInclude()
        {
            var orders = gym.OrderCourses.Include(o => o.OrderClass).Include(o => o.OrderMember)
                .Include(o => o.OrderPayment).Include(o => o.OrderStatus).Include(o => o.OrderReason)
                .Select(o => new COrderIncludeViewModel() { orderCourse = o });

            return View(orders);
        }


        /// <summary>
        /// 新增訂單
        /// </summary>
        /// <returns></returns>
        public IActionResult backOrderCreate()
        {
            return View();
        }

        /// <summary>
        /// 新增訂單POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backOrderCreate(OrderCourse order)
        {

            gym.Add(order);

            //同時新增MemberLesson
            var lessons = gym.Lessons.Where(l => l.LessonClassId == order.OrderClassId).Select(l => l.LessonId);
            foreach (var lessonid in lessons)
            {
                MemberLesson memberLesson = new MemberLesson()
                {
                    MemberLessonMemberId = order.OrderMemberId,
                    MemberLessonLessonId = lessonid
                };

                gym.Add(memberLesson);
            }

            gym.SaveChanges();

            return RedirectToAction("backOrderList");
        }


        /// <summary>
        /// 訂單修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backOrderEdit(int id)
        {

            COrderCourseViewModel orderCV = gym.OrderCourses.Where(e => e.OrderId == id).Select(e => new COrderCourseViewModel()
            {
                OrderId = e.OrderId,
                OrderClassId = e.OrderClassId,
                LogInName = e.OrderMember.LogInName,
                CourseClassName = e.OrderClass.CourseClassName,
                PaymentName = e.OrderPayment.PaymentName,
                classMoney = Convert.ToInt32(Convert.ToDecimal(e.OrderClass.CourseClassDetail.CourseDetailMoney) * e.OrderClass.CourseClassPlan.Dicount.DiscountPercent),
                OrderTime = e.OrderTime,
                OrderStatusId = e.OrderStatusId,
                OrderReasonId = e.OrderReasonId,
                OrderReasonMoney = e.OrderReasonMoney,
                OrderReviseTime = e.OrderReviseTime
            }).FirstOrDefault();

            if (orderCV == null)
            {
                return RedirectToAction("backOrderList");
            }
            return View(orderCV);
        }


        /// <summary>
        /// 訂單修改POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backOrderEdit(COrderCourseViewModel co)
        {
            OrderCourse order = gym.OrderCourses.FirstOrDefault(o => o.OrderId == co.OrderId);

            if (order != null)
            {
                //order.OrderPaymentId = co.OrderPaymentId;
                order.OrderReasonId = co.OrderReasonId;
                order.OrderPaymentId = co.OrderPaymentId;
                order.OrderReasonMoney = co.OrderReasonMoney;
                order.OrderStatusId = co.OrderStatusId;
                order.OrderReviseTime = co.OrderReviseTime;

                gym.SaveChanges();
            }

            return RedirectToAction("backOrderList");
        }

        /// <summary>
        /// 訂單刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backOrderDelete(int id)
        {
            OrderCourse order = gym.OrderCourses.FirstOrDefault(o => o.OrderId == id);

            if (order != null)
            {
                gym.Remove(order);
                gym.SaveChanges();
            }

            return RedirectToAction("backOrderList");
        }


        //--------------------設備管理--------------------//

        //設備

        /// <summary>
        /// 設備管理
        /// </summary>
        /// <returns></returns>
        public IActionResult backEquipmentList()
        {
            List<CEquipmentViewModel> list = new List<CEquipmentViewModel>();

            var equipmentList = from equipment in gym.Equipment
                                orderby equipment.EquipmentId
                                join equipmentCategory in gym.EquipmentCategories on equipment.EquipmentCategoryId equals equipmentCategory.EquipmentCategoryId
                                join classroom in gym.Classrooms on equipment.EquipmentClassroomId equals classroom.ClassroomId
                                join company in gym.Companies on equipment.EquipmentCompanyId equals company.CompanyId
                                select new { equipment, equipmentCategory, classroom, company };


            var q = gym.Equipment.Select(e => new CEquipmentViewModel() { ClassroomName = e.EquipmentClassroom.ClassroomName });

            foreach (var item in equipmentList)
            {
                list.Add(new CEquipmentViewModel()
                {
                    equipment = item.equipment,
                    equipmentCategory = item.equipmentCategory,
                    classroom = item.classroom,
                    company = item.company
                });
            }

            return View(list);
        }


        /// <summary>
        /// 設備_下拉選單
        /// </summary>
        public void equipmentSelect()
        {
            var equipments = gym.EquipmentCategories;
            var equipmentCompanys = gym.Companies;

            List<SelectListItem> category = new List<SelectListItem>();
            List<SelectListItem> company = new List<SelectListItem>();

            foreach (var equipment in equipments)
            {
                category.Add(new SelectListItem()
                {
                    Text = equipment.EquipmentCategoryName,
                    Value = equipment.EquipmentCategoryId.ToString()
                });
            }

            foreach (var eCompany in equipmentCompanys)
            {
                company.Add(new SelectListItem()
                {
                    Text = eCompany.CompanyName,
                    Value = eCompany.CompanyId.ToString()
                });
            }

            ViewBag.categoryItems = category;
            ViewBag.companyItems = company;
        }


        /// <summary>
        /// 新增設備
        /// </summary>
        /// <returns></returns>
        public IActionResult backEquipmentCreate()
        {

            equipmentSelect();
            return View();
        }

        /// <summary>
        /// 新增設備POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backEquipmentCreate(Equipment e)
        {

            gym.Add(e);
            gym.SaveChanges();

            //進貨同步新增維修清單
            EquipmentRestoration restoration = new EquipmentRestoration
            {
                EquipmentId = e.EquipmentId,
                EquipmentStayServiceDay = e.EquipmentDay.AddYears(e.EquipmentCycle)
            };
            gym.Add(restoration);
            gym.SaveChanges();

            return RedirectToAction("backEquipmentList");
        }

        /// <summary>
        /// 設備修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backEquipmentEdit(int id)
        {
            equipmentSelect();
            Equipment equipment = gym.Equipment.FirstOrDefault(e => e.EquipmentId == id);

            if (equipment == null)
            {
                return RedirectToAction("backEquipmentList");
            }
            return View(new CEquipmentViewModel() { equipment = equipment });
        }

        /// <summary>
        /// 設備修改POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backEquipmentEdit(CEquipmentViewModel ce)
        {
            Equipment equipment = gym.Equipment.FirstOrDefault(e => e.EquipmentId == ce.EquipmentId);
            EquipmentRestoration restoration = gym.EquipmentRestorations.FirstOrDefault(e => e.EquipmentId == ce.EquipmentId);

            if (equipment != null)
            {
                equipment.EquipmentCategoryId = ce.EquipmentCategoryId;
                equipment.EquipmentCompanyId = ce.EquipmentCompanyId;
                equipment.EquipmentCycle = ce.EquipmentCycle;
                equipment.EquipmentClassroomId = ce.EquipmentClassroomId;
                equipment.EquipmentDay = ce.equipment.EquipmentDay;

                //維修清單同步修改
                restoration.EquipmentStayServiceDay = ce.EquipmentDay.AddYears(ce.EquipmentCycle);

                gym.SaveChanges();
            }

            return RedirectToAction("backEquipmentList");
        }

        /// <summary>
        /// 設備刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backEquipmentDelete(int id)
        {
            var restorations = gym.EquipmentRestorations.Where(e => e.EquipmentId == id).Select(e => e.RestorationId);
            List<int> restorationsAry = new List<int>();

            foreach (var item in restorations)
            {
                restorationsAry.Add(item);
            }

            foreach (var RestorationId in restorationsAry)
            {
                //刪除維修紀錄
                EquipmentRestoration restoration = gym.EquipmentRestorations.FirstOrDefault(e => e.RestorationId == RestorationId);
                if (restoration != null)
                {
                    gym.Remove(restoration);
                    gym.SaveChanges();
                }
            }

            Equipment equipment = gym.Equipment.FirstOrDefault(e => e.EquipmentId == id);

            if (equipment != null)
            {
                gym.Remove(equipment);
                gym.SaveChanges();
            }

            return RedirectToAction("backEquipmentList");
        }



        //維修
        /// <summary>
        /// 維修清單
        /// </summary>
        /// <returns></returns>
        public IActionResult backRestorationList()
        {
            List<CEquipmentRestorationViewModel> list = new List<CEquipmentRestorationViewModel>();

            var restorationList = from restoration in gym.EquipmentRestorations
                                  orderby restoration.EquipmentStayServiceDay
                                  join equipment in gym.Equipment on restoration.EquipmentId equals equipment.EquipmentId
                                  join equipmentCategory in gym.EquipmentCategories on equipment.EquipmentCategoryId equals equipmentCategory.EquipmentCategoryId
                                  join classroom in gym.Classrooms on equipment.EquipmentClassroomId equals classroom.ClassroomId
                                  join company in gym.Companies on equipment.EquipmentCompanyId equals company.CompanyId
                                  select new { restoration, equipment, equipmentCategory, classroom, company };

            foreach (var item in restorationList)
            {
                list.Add(new CEquipmentRestorationViewModel()
                {
                    restoration = item.restoration,
                    equipment = item.equipment,
                    equipmentCategory = item.equipmentCategory,
                    classroom = item.classroom,
                    company = item.company
                });
            }
            return View(list);
        }


        /// <summary>
        /// 維修按鈕(維修日期:當日)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backRestorationDay(int id)
        {

            var restorationList = from restoration in gym.EquipmentRestorations
                                  join equipment in gym.Equipment on restoration.EquipmentId equals equipment.EquipmentId
                                  where restoration.RestorationId == id
                                  select new { restoration, equipment };

            if (restorationList != null)
            {
                foreach (var item in restorationList.ToList())
                {
                    item.restoration.EquipmentServiceDay = DateTime.Now;

                    //待維修日期一併修改
                    item.restoration.EquipmentStayServiceDay = (DateTime.Now).AddYears(item.equipment.EquipmentCycle);
                    gym.SaveChanges();
                    return Json("OK");
                }
            }

            return Json("");
            //return RedirectToAction("backRestorationList");
        }



        /// <summary>
        /// 維修複選
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backRestorationDayCheck(CEquipmentRestorationViewModel cEquipment)
        {
            int[] idAry = cEquipment.idAry;

            if (idAry == null)
            {
                return RedirectToAction("backRestorationList");
            }
            int count = idAry.Count();

            for (int i = 0; i < count; i++)
            {
                int id = idAry[i];

                var restorationList = from restoration in gym.EquipmentRestorations
                                      join equipment in gym.Equipment on restoration.EquipmentId equals equipment.EquipmentId
                                      where restoration.RestorationId == id
                                      select new { restoration, equipment };


                if (restorationList != null)
                {
                    foreach (var item in restorationList.ToList())
                    {
                        item.restoration.EquipmentServiceDay = DateTime.Now;

                        //待維修日期一併修改
                        item.restoration.EquipmentStayServiceDay = (DateTime.Now).AddYears(item.equipment.EquipmentCycle);
                        gym.SaveChanges();                        
                    }
                }
            }
            return Json("OK");
            //return RedirectToAction("backRestorationList");
        }


        /// <summary>
        /// 維修刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backRestorationDelete(int id)
        {
            EquipmentRestoration restoration = gym.EquipmentRestorations.FirstOrDefault(r => r.RestorationId == id);

            if (restoration != null)
            {
                gym.Remove(restoration);
                gym.SaveChanges();
            }

            return RedirectToAction("backRestorationList");
        }



        //廠商
        /// <summary>
        /// 廠商管理
        /// </summary>
        /// <returns></returns>
        public IActionResult backCompanyList(CKeywordViewModel kvm)
        {
            string keyword = kvm.txtKeyword;

            IEnumerable<Company> companies = null;

            if (string.IsNullOrEmpty(keyword))
            {
                companies = gym.Companies;
            }
            else
            {
                companies = gym.Companies.Where(c => c.CompanyName.Contains(keyword) || c.CompanyTaxId.ToString().Contains(keyword));
            }

            List<CCompanyViewModel> list = new List<CCompanyViewModel>();

            foreach (var c in companies)
            {
                list.Add(new CCompanyViewModel() { company = c });
            }
            return View(list);
        }

        /// <summary>
        /// 新增廠商
        /// </summary>
        /// <returns></returns>
        public IActionResult backCompanyCreate()
        {
            return View();
        }

        /// <summary>
        /// 新增廠商POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backCompanyCreate(Company ｃ)
        {
            gym.Add(ｃ);
            gym.SaveChanges();

            return RedirectToAction("backCompanyList");
        }

        /// <summary>
        /// 廠商修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backCompanyEdit(int id)
        {
            Company company = gym.Companies.FirstOrDefault(c => c.CompanyId == id);

            if (company == null)
            {
                return RedirectToAction("backCompanyList");
            }
            return View(new CCompanyViewModel() { company = company });
        }

        /// <summary>
        /// 廠商修改POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backCompanyEdit(CCompanyViewModel cc)
        {
            Company company = gym.Companies.FirstOrDefault(c => c.CompanyId == cc.CompanyId);

            if (company != null)
            {
                company.CompanyName = cc.CompanyName;
                company.CompanyTaxId = cc.CompanyTaxId;
                company.ComapnyPhone = cc.ComapnyPhone;

                gym.SaveChanges();
            }

            return RedirectToAction("backCompanyList");
        }

        /// <summary>
        /// 廠商刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backCompanyDelete(int id)
        {
            Company company = gym.Companies.FirstOrDefault(c => c.CompanyId == id);

            if (company != null)
            {
                gym.Remove(company);
                gym.SaveChanges();
            }

            return RedirectToAction("backCompanyList");
        }



        //--------------------課程管理--------------------//


        //課程分類

        /// <summary>
        /// 課程分類(detail)
        /// </summary>
        /// <returns></returns>
        public IActionResult backDetailList()
        {

            // var detailAll = gym.CourseDetails.Include(c => c.CourseCategory).OrderByDescending(c => c.CourseCategoryId).Select(c => new CCourseDetailViewmodel() { coursedetail = c });
            var detailAll = from detail in gym.CourseDetails
                            orderby detail.CourseCategoryId descending
                            join category in gym.CourseCategories on detail.CourseCategoryId equals category.CourseCategoryId
                            select new { detail, category };

            List<CCourseDetailViewmodel> list = new List<CCourseDetailViewmodel>();

            foreach (var item in detailAll)
            {
                list.Add(new CCourseDetailViewmodel() { coursedetail = item.detail, coursecategory = item.category });
            }

            return View(list);
        }

        /// <summary>
        /// 新增課程分類
        /// </summary>
        /// <returns></returns>
        public IActionResult backCourseDetailCreate()
        {
            return View();
        }

        /// <summary>
        /// 新增課程分類POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backCourseDetailCreate(CCourseDetailViewmodel cd)
        {
            if (cd.DetailPicture != null)
            {
                string figureName = cd.DetailPicture.FileName;
                cd.coursedetail.CourseDetailPicture = figureName;
                cd.DetailPicture.CopyTo(new FileStream(_environment.WebRootPath + @"\img\CourseDetail\" + figureName, FileMode.Create));
            }

            gym.Add(cd.coursedetail);
            gym.SaveChanges();


            return RedirectToAction("backDetailList");
        }


        /// <summary>
        /// 課程分類修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backCourseDetailEdit(int id)
        {
            CourseDetail courseDetail = gym.CourseDetails.FirstOrDefault(c => c.CourseDetailId == id);

            if (courseDetail == null)
            {
                return RedirectToAction("backDetailList");
            }
            return View(new CCourseDetailViewmodel() { coursedetail = courseDetail });
        }

        /// <summary>
        /// 課程分類修改POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backCourseDetailEdit(CCourseDetailViewmodel cd)
        {
            CourseDetail courseDetail = gym.CourseDetails.FirstOrDefault(c => c.CourseDetailId == cd.CourseDetailId);

            if (courseDetail != null)
            {
                if (cd.DetailPicture != null)
                {
                    string figureName = cd.DetailPicture.FileName;
                    courseDetail.CourseDetailPicture = figureName;
                    cd.DetailPicture.CopyTo(new FileStream(_environment.WebRootPath + @"\img\CourseDetail\" + figureName, FileMode.Create));
                }

                courseDetail.CourseCategoryId = cd.CourseCategoryId;
                courseDetail.CourseDetailName = cd.CourseDetailName;
                courseDetail.CourseDetailIntroduce = cd.CourseDetailIntroduce;
                courseDetail.CourseDetailMoney = cd.CourseDetailMoney;
                courseDetail.CourseDetailCal = cd.CourseDetailCal;

                gym.SaveChanges();
            }

            return RedirectToAction("backDetailList");
        }

        /// <summary>
        /// 課程分類刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backCourseDetailDelete(int id)
        {
            try
            {
                CourseDetail courseDetail = gym.CourseDetails.FirstOrDefault(c => c.CourseDetailId == id);

                if (courseDetail != null)
                {
                    gym.Remove(courseDetail);
                    gym.SaveChanges();
                }
            }
            catch
            {
                return RedirectToAction("errorView", new { msg = "該課程分類已有開課紀錄，無法刪除此課程分類。", url = "~/Backstage/backDetailList" });
            }


            return RedirectToAction("backDetailList");
        }


        //課程總覽

        /// <summary>
        /// 課程總覽(class)
        /// </summary>
        /// <returns></returns>
        public IActionResult backClassList()
        {

            //var classAll = gym.CourseClasses.Include(c => c.CourseClassDetail.CourseCategory).Include(c => c.CourseClassCoach)
            //    .Include(c => c.CourseClassClassroom).Include(c => c.CourseClassPlan).Include(c => c.CourseClassCoach.CoachNavigation)
            //    .OrderByDescending(c=>c.CourseClassId).Select(c => new CCourseClassIncludeViewmodel() { courseclass = c  });

            var classAll = (from cclass in gym.CourseClasses
                            orderby cclass.CourseClassId descending
                            select new CCourseClassViewmodel()
                            {
                                CourseClassId = cclass.CourseClassId,
                                CourseCategoryName = cclass.CourseClassDetail.CourseCategory.CourseCategoryName,
                                CourseDetailName = cclass.CourseClassDetail.CourseDetailName,
                                CourseClassName = cclass.CourseClassName,
                                CourseClassCoach = cclass.CourseClassCoach.CoachNavigation.LogInName,
                                CourseClassPeople = cclass.CourseClassPeople,
                                ClassroomName = cclass.CourseClassClassroom.ClassroomName,
                                DiscountPlanName = cclass.CourseClassPlan.DiscountPlan1,
                                NumberOfApplicants = gym.OrderCourses.Where(o => o.OrderClassId == cclass.CourseClassId).Count()
                            });

            return View(classAll);
        }


        /// <summary>
        /// 新增課程
        /// </summary>
        /// <returns></returns>
        public IActionResult backCourseClassCreate()
        {
            return View();
        }

        /// <summary>
        /// 新增課程POST
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backCourseClassCreate(CourseClass cclass)
        {

            gym.Add(cclass);
            gym.SaveChanges();

            return RedirectToAction("backClassList");
        }


        /// <summary>
        /// 課程修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backCourseClassEdit(int id)
        {
            CourseClass courseClass = gym.CourseClasses.FirstOrDefault(c => c.CourseClassId == id);

            if (courseClass == null)
            {
                return RedirectToAction("backClassList");
            }
            return View(courseClass);
        }

        /// <summary>
        /// 課程修改POST
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult backCourseClassEdit(CourseClass cc)
        {
            CourseClass courseClass = gym.CourseClasses.FirstOrDefault(c => c.CourseClassId == cc.CourseClassId);

            if (courseClass != null)
            {
                courseClass.CourseClassDetailId = cc.CourseClassDetailId;
                courseClass.CourseClassName = cc.CourseClassName;
                courseClass.CourseClassCoachId = cc.CourseClassCoachId;
                courseClass.CourseClassPeople = cc.CourseClassPeople;
                courseClass.CourseClassClassroomId = cc.CourseClassClassroomId;
                courseClass.CourseClassPlanId = cc.CourseClassPlanId;

                gym.SaveChanges();
            }

            return RedirectToAction("backClassList");
        }

        /// <summary>
        /// 課程刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult backCourseClassDelete(int id)
        {
            try
            {
                CourseClass courseClass = gym.CourseClasses.FirstOrDefault(c => c.CourseClassId == id);

                if (courseClass != null)
                {
                    gym.Remove(courseClass);
                    gym.SaveChanges();
                }
            }
            catch
            {
                return RedirectToAction("errorView", new { msg = "該課程已有安排課程時段，無法刪除此課程資料。", url = "~/Backstage/backClassList" });
            }


            return RedirectToAction("backClassList");
        }




        /// <summary>
        /// 課程安排
        /// </summary>
        /// <returns></returns>
        public IActionResult backLessonList()
        {
            List<CLessonViewModel> list = new List<CLessonViewModel>();
            string json = "";

            if (HttpContext.Session.Keys.Contains(LessonDictionary.lessonList))
            {
                json = HttpContext.Session.GetString(LessonDictionary.lessonList);  //取得Session
                list = JsonSerializer.Deserialize<List<CLessonViewModel>>(json);   //變成物件

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == null)
                        list.RemoveAt(i);
                }

                ViewBag.lessonCount = list.Count();
            }
            else
            {
                ViewBag.lessonCount = 0;
            }
            return View();
        }


        /// <summary>
        /// 新增lesson丟入Session
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult addLesson(CLessonViewModel l)
        {
            var lesson = gym.Lessons.FirstOrDefault(l => l.LessonClassId == l.LessonClassId);
            if (lesson == null)
            {
                return RedirectToAction(nameof(BackstageController.backLessonList));
            }

            //刪除lesson會留null 此處再次移除
            List<CLessonViewModel> list = new List<CLessonViewModel>();
            string json = "";

            if (HttpContext.Session.Keys.Contains(LessonDictionary.lessonList))
            {
                json = HttpContext.Session.GetString(LessonDictionary.lessonList);  //取得Session
                list = JsonSerializer.Deserialize<List<CLessonViewModel>>(json);   //變成物件

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == null)
                        list.RemoveAt(i);
                }

            }
            else
            {
                list = new List<CLessonViewModel>();
            }


            //課堂數判斷衝突
            int classLessonCount = gym.Lessons.Where(lesson => lesson.LessonClassId == l.LessonClassId).Select(lesson => lesson.LessonTime).Count();

            int sessionLessonCount = 0;
            if (HttpContext.Session.Keys.Contains(LessonDictionary.lessonList))
            {
                json = HttpContext.Session.GetString(LessonDictionary.lessonList);  //取得Session
                list = JsonSerializer.Deserialize<List<CLessonViewModel>>(json);   //變成物件
                var sessionByClassLessionTime = from sessionList in list where sessionList.LessonClassId == l.LessonClassId select sessionList.LessonTime;
                sessionLessonCount = sessionByClassLessionTime.Count();
            }

            int addLessonCount = l.time.Count();
            int totalLessonCount = classLessonCount + sessionLessonCount + addLessonCount;

            if (totalLessonCount > 10)
            {
                return Content("該班課堂已排滿，如需異動請先刪除原資料。");
            }

            //教練判斷衝突
            int coachID = gym.CourseClasses.Where(c => c.CourseClassId == l.LessonClassId).Select(c => c.CourseClassCoachId).FirstOrDefault();
            var coachLessonByOneday_Hours = from lessons in gym.Lessons
                                            where lessons.LessonTime.Date == DateTime.Parse(l.date).Date && lessons.LessonClass.CourseClassCoachId == coachID
                                            select lessons.LessonTime.Hour; //10.19

            bool coachAns = coachLessonByOneday_Hours.ToList().Intersect(l.time).Count() > 0;
            if (coachAns)
            {
                return Content("本課教練此時段已安排其他課程");
            }

            //教室判斷衝突
            var classroomLessonByOneday_Hours = from lessons in gym.Lessons
                                                where lessons.LessonTime.Date == DateTime.Parse(l.date).Date && lessons.LessonClass.CourseClassClassroom.ClassroomId == l.ClassroomId
                                                select lessons.LessonTime.Hour;

            bool classroomAns = classroomLessonByOneday_Hours.ToList().Intersect(l.time).Count() > 0;
            if (classroomAns)
            {
                return Content("該教室已安排其他課程，請選擇別的時段");
            }

            //勾選時段判斷衝突(與暫存時段相同)
            if (HttpContext.Session.Keys.Contains(LessonDictionary.lessonList))
            {
               // List<int> sessionLesson = new List<int>();
                List<string> sessionLesson = new List<string>();

                json = HttpContext.Session.GetString(LessonDictionary.lessonList);  //取得Session
                list = JsonSerializer.Deserialize<List<CLessonViewModel>>(json);   //變成物件
                var sessionByClassLessionTime = from sessionList in list where sessionList.LessonClassId == l.LessonClassId select sessionList.LessonTime;
                foreach (var item in sessionByClassLessionTime)
                {
                    sessionLesson.Add(item.ToString());
                }

                List<string> addLesson = new List<string>();

                int addYear = int.Parse(l.date.Substring(0, 4));
                int addMonth = int.Parse(l.date.Substring(5, 2));
                int addDay = int.Parse(l.date.Substring(8, 2));
                foreach (var item in l.time)
                {
                    addLesson.Add((new DateTime(addYear, addMonth, addDay, item, 00, 00)).ToString());
                }

                bool sessionAns = sessionLesson.Intersect(addLesson).Count() > 0;

                if (sessionAns)
                {
                    return Content("該課程時段已被勾選，請勿重複新增");
                }

            }


            //新增lesson
            int Year = int.Parse(l.date.Substring(0, 4));
            int Month = int.Parse(l.date.Substring(5, 2));
            int Day = int.Parse(l.date.Substring(8, 2));

            foreach (var t in l.time)
            {
                CLessonViewModel lessons = new CLessonViewModel()
                {
                    LessonClassId = l.LessonClassId,
                    ClassroomId = l.ClassroomId,
                    LessonTime = new DateTime(Year, Month, Day, t, 00, 00),

                    CourseCategoryName = gym.CourseCategories.Where(c => c.CourseCategoryId == int.Parse(l.CourseCategoryName)).Select(c => c.CourseCategoryName).FirstOrDefault(),
                    CourseDetailName = gym.CourseDetails.Where(d => d.CourseDetailId == int.Parse(l.CourseDetailName)).Select(d => d.CourseDetailName).FirstOrDefault(),
                    CourseClassName = gym.CourseClasses.Where(c => c.CourseClassId == l.LessonClassId).Select(c => c.CourseClassName).FirstOrDefault(),
                    CourseClassCoach = gym.CourseClasses.Where(c => c.CourseClassId == l.LessonClassId).Select(c => c.CourseClassCoach.CoachNavigation.LogInName).FirstOrDefault(),
                    ClassroomName = gym.Classrooms.Where(c => c.ClassroomId == l.ClassroomId).Select(c => c.ClassroomName).FirstOrDefault(),
                };

                list.Add(lessons);

            }

            json = JsonSerializer.Serialize(list);  //轉成json
            HttpContext.Session.SetString(LessonDictionary.lessonList, json); //丟進Session
            int count = list.Count();
            //return RedirectToAction(nameof(BackstageController.backLessonList));
            return Content(count.ToString());

        }

        /// <summary>
        /// 檢視課堂新增(session)
        /// </summary>
        /// <returns></returns>
        public IActionResult addLessonView()
        {

            List<CLessonViewModel> list = null;
            string json = "";

            if (HttpContext.Session.Keys.Contains(LessonDictionary.lessonList))
            {
                json = HttpContext.Session.GetString(LessonDictionary.lessonList); //取出
                list = JsonSerializer.Deserialize<List<CLessonViewModel>>(json); //轉成物件
            }

            if (list == null)
            {
                return RedirectToAction(nameof(BackstageController.backLessonList));
            }
            else
            {
                return View(list);
            }
        }

        /// <summary>
        /// 清除(session)課堂新增
        /// </summary>
        /// <returns></returns>
        public IActionResult cleanLessonView()
        {
            HttpContext.Session.Remove(LessonDictionary.lessonList);
            return RedirectToAction(nameof(BackstageController.backLessonList));

        }


        /// <summary>
        /// 新增課堂
        /// </summary>
        /// <returns></returns>
        public IActionResult backLessonCreate()
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

                foreach (var lessonViewModel in list)
                {
                    Lesson lesson = new Lesson()
                    {
                        LessonClassId = lessonViewModel.LessonClassId,
                        LessonTime = lessonViewModel.LessonTime
                    };

                    gym.Add(lesson);
                    gym.SaveChanges();
                }
            }
            HttpContext.Session.Remove(LessonDictionary.lessonList);
            return RedirectToAction(nameof(BackstageController.backLessonList));
        }
    }
}
