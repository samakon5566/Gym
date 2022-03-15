using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjAspCoreDemo.ViewModels;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using prjGymEndTerm.ViewModels.CoachArea;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{
    public class CoachController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly GYMContext gym;
        public CoachController(IWebHostEnvironment p, GYMContext context)
        {
            _environment = p;
            gym = context;
        }
        public int HasSessino()
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

            ViewBag.LogInName = "";
            ViewBag.LogInTypeId = -1;
            ViewBag.LogInId = -1;
            return 0;
        }
        public IActionResult List()
        {
            if (HasSessino()!=0)
            {
                return View();
            }

            return RedirectToAction("Login","Home");
        }
        public IActionResult Course_List()
        {
            if (HasSessino() != 0)
            {
                ViewBag.CourseName = CUserLogin.memberName;
                return View();
            }
          
            return RedirectToAction("Login", "Home");
        }

        public IActionResult Coach_Edit()
        {
            if (HasSessino() != 0)
            {
                LogIn l = gym.LogIns.FirstOrDefault(l => l.LogInId ==CUserLogin.memberId);
                Coach c = gym.Coaches.FirstOrDefault(l => l.CoachId == CUserLogin.memberId);
                CCoachEditViewModel coach = new CCoachEditViewModel();
                coach.login = l;
                coach.coach = c;

                return View(coach);
            }
       
            return RedirectToAction("Login", "Home");
        }
        [HttpPost]
        public IActionResult Coach_Edit(CCoachEditViewModel p)
        {
            LogIn l = gym.LogIns.FirstOrDefault(l => l.LogInId == p.LogInId);
            Coach c = gym.Coaches.FirstOrDefault(c=> c.CoachId == p.LogInId);

            if (l != null )
            {
                if (p.LoginFigure != null)
                {
                    string figureName = p.LoginFigure.FileName;
                    l.LoginFigure = figureName;
                    p.LoginFigure.CopyTo(new FileStream(_environment.WebRootPath + @"\img\LoginFigure\" + figureName, FileMode.Create));
                }

                l.LogInName = p.LogInName;
                l.LogInIdNumber = p.LogInIdNumber;
                l.LogInGender= p.LogInGender;
                l.LogInBrithDay= p.LogInBrithDay;
                l.LogInPhone= p.LogInPhone;
                l.LogInEmail= p.LogInEmail;
                
                gym.SaveChanges();
            }

            return RedirectToAction("Login", "Home");
        }
        public IActionResult Student_List(CKeywordViewModel kvm)
        {
            if (HasSessino() != 0)
            {
                string keyword = kvm.txtKeyword;
                IEnumerable<LogIn> l = null;
                if (string.IsNullOrEmpty(keyword))
                {
                    l = gym.LogIns.Where(l => l.LogInTypeId == 2);
                }
                else
                {
                    l = gym.LogIns.Where(l => l.LogInId == int.Parse(keyword));
                }
                List<CoachArea_StudentViewModel> list = new List<CoachArea_StudentViewModel>();
                foreach (LogIn p in l)
                {
                    list.Add(new CoachArea_StudentViewModel() { login = p });
                }
                return View(list);
            }

            return RedirectToAction("Login", "Home");
        }
        public IActionResult Student_Course(int id)
        {
            if (HasSessino() != 0)
            {
                ViewBag.MemberName = gym.LogIns.FirstOrDefault(l => l.LogInId == id).LogInName;
                ViewBag.id = id;
                var order = gym.OrderCourses.Include(o => o.OrderClass)
                    .Include(o => o.OrderClass.CourseClassDetail)
                    .Include(o => o.OrderClass.CourseClassDetail.CourseCategory)
                    .Where(o => o.OrderMemberId == id);

                List<CStudentCourseViewModel> list = new List<CStudentCourseViewModel>();

                //List<int> test = new List<int>();
                //test = order;
                foreach (var o in order)
                {
                    list.Add(new CStudentCourseViewModel() { orderCourse = o });
                }
                foreach (var course in list)
                {
                    int classId = course.orderCourse.OrderClassId;
                    DateTime FirstCoures = gym.Lessons.Where(l => l.LessonClassId == classId).Min(l => l.LessonTime);
                    course.Lesson_Time = FirstCoures.ToString("yyyy/MM/dd");
                }
                return View(list);
            }

            return RedirectToAction("Login", "Home");
        }

        public IActionResult Comment_Index()
        {
            if (HasSessino() != 0)
            {
                return View();
            }

            return RedirectToAction("Login", "Home");
        }
        public IActionResult Comment_List(int CourseCategory_ID=0,int CourseClass_ID=0)
        {
            IEnumerable<MemberScore> score = null;
            if(CourseCategory_ID == 0 && CourseClass_ID == 0)
            {
                score = gym.MemberScores.Include(ms => ms.CourseClass).Include(ms => ms.Member)
                    .Include(ms=>ms.CourseClass.CourseClassCoach).Include(ms=>ms.CourseClass.CourseClassCoach.CoachNavigation)
                    .Where(ms=>ms.CourseClass.CourseClassCoachId== CUserLogin.memberId);
            }
            else
            {
                if (CourseClass_ID == 0)
                {
                    score = gym.MemberScores.Include(ms => ms.CourseClass).Include(ms => ms.Member)
                         .Include(ms => ms.CourseClass.CourseClassCoach).Include(ms => ms.CourseClass.CourseClassCoach.CoachNavigation)
                        .Where(ms => ms.CourseClass.CourseClassDetail.CourseCategory.CourseCategoryId == CourseCategory_ID
                        && ms.CourseClass.CourseClassCoachId == CUserLogin.memberId
                        );
                }
                else
                {
                    score = gym.MemberScores.Include(ms => ms.CourseClass).Include(ms => ms.Member)
                         .Include(ms => ms.CourseClass.CourseClassCoach).Include(ms => ms.CourseClass.CourseClassCoach.CoachNavigation)
                        .Where(ms => ms.CourseClass.CourseClassId == CourseClass_ID &&
                        ms.CourseClass.CourseClassDetail.CourseCategory.CourseCategoryId == CourseCategory_ID &&
                        ms.CourseClass.CourseClassCoachId == CUserLogin.memberId
                        );
                }
            }
            List<CoachCommentListViewModel> list = new List<CoachCommentListViewModel>();

            foreach (var s in score)
            {
                list.Add(new CoachCommentListViewModel() { score = s });
            }
            return PartialView(list);

        }

        public IActionResult Video_List()
        {
            if (HasSessino() != 0)
            {
                return View();
            }

            return RedirectToAction("Login", "Home");
        }
        public IActionResult _Video_List(int FitnessVideo_ID=0)
        {
            IEnumerable<FitnessVideo> video = null;
            if(FitnessVideo_ID ==0)
                video = gym.FitnessVideos.Include(fv=>fv.FitnessVideoCourseCategory);
            else
                video = gym.FitnessVideos.Include(fv => fv.FitnessVideoCourseCategory)
                    .Where(fv=>fv.FitnessVideoCourseCategoryId== FitnessVideo_ID);

            List<CCoachVideoListViewModel> list = new List<CCoachVideoListViewModel>();

            foreach (var v in video)
            {
                list.Add(new CCoachVideoListViewModel() { video = v });
            }
            return PartialView(list);
        }
        public IActionResult Video_Create()
        {
            return View();
        }
        public IActionResult ChatIndex()
        {
            if (HasSessino() != 0)
            {
                ViewBag.TypeId = CUserLogin.memberType;
                return View();
            }
            return RedirectToAction("Login", "Home");
        }
        public IActionResult GroupChat()
        {
            if (HasSessino() != 0) {
                ViewBag.Name = CUserLogin.memberName;
                ViewBag.Id = CUserLogin.memberId;
                ViewBag.TypeId = CUserLogin.memberType;
                ViewBag.Figure = gym.LogIns.Where(l => l.LogInId == CUserLogin.memberId).Select(l => l.LoginFigure).FirstOrDefault();
                return View();
            }
            return RedirectToAction("Login", "Home");
        }
        public IActionResult RoomChat()
        {
            if (HasSessino() != 0)
            {
                CChatRoom.RoomId = "15660";
                CChatRoom.RoomPwd = "15660";
                ViewBag.RoomId = CChatRoom.RoomId;
                ViewBag.Pwd = CChatRoom.RoomPwd;
                ViewBag.Name = CUserLogin.memberName;
                ViewBag.Id = CUserLogin.memberId;
                ViewBag.TypeId = CUserLogin.memberType;
                ViewBag.Figure = gym.LogIns.Where(l => l.LogInId == CUserLogin.memberId).Select(l => l.LoginFigure).FirstOrDefault();
                return View();
            }
            return RedirectToAction("Login", "Home");
        }
        public IActionResult RoomChatStu()
        {
            if (HasSessino() != 0)
            {
                ViewBag.RoomId = CChatRoom.RoomId;
                ViewBag.Pwd = CChatRoom.RoomPwd;
                ViewBag.Name = CUserLogin.memberName;
                ViewBag.Id = CUserLogin.memberId;
                ViewBag.TypeId = CUserLogin.memberType;
                ViewBag.Figure = gym.LogIns.Where(l => l.LogInId == CUserLogin.memberId).Select(l => l.LoginFigure).FirstOrDefault();
                return View();
            }
            return RedirectToAction("Login", "Home");
        }

        public IActionResult CouseList(int LessonId)
        {

            //var student = gym.OrderCourses.Where(o => o.OrderClassId == CourseId).Select(o => o.OrderMember.LogInName).ToList();
            IEnumerable<MemberLesson> student = 
                gym.MemberLessons.Include(m=>m.MemberLessonMember).
                Where(m => m.MemberLessonLessonId == LessonId);
            List<CCouseListViewModel> list = new List<CCouseListViewModel>();

            foreach (var s in student)
            {
                list.Add(new CCouseListViewModel() { ms=s  });
            }

            return PartialView(list);
        }
    }
}
