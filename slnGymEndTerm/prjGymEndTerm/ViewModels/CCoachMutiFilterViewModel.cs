using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels.GroupCourse
{
    public class CCoachMutiFilterViewModel
    {


        public List<CCoachDisplayViewModel> dvlist = new List<CCoachDisplayViewModel>();

        public List<CCoachDisplayViewModel> isWhichFiltWay(string flag,int[] flag2,GYMContext _gymcontext)
        {
            ///id 0個
            if (string.IsNullOrEmpty(flag)&&flag2.Length.Equals(0))
            {
                var CoachJson = from l in _gymcontext.LogIns.Where(l => l.LogInTypeId.Equals(3))
                                select new
                                {
                                    coachID = l.LogInId,
                                    coachfigure = l.LoginFigure,
                                    coachname = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    coachbackground = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                foreach (var o in CoachJson)
                {
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = o.coachID,
                        Coachfigure = o.coachfigure,
                        Coachname = o.coachname,
                        Coachscore = o.coachscore,
                        Coachbackground = o.coachbackground,
                        Coachcomment = o.coachcomment,
                        Coachskill = o.coachskill,
                        Coachexp = o.coachexp
                    });
                }               
            }
            if (!string.IsNullOrEmpty(flag)&&flag.Contains("comment") && !flag.Contains("order") && !flag.Contains("exp") && !flag.Contains("score") && flag2.Length.Equals(0))
            {
                var CoachJson = from s in _gymcontext.MemberScores
                                where s.CourseClass.Lessons.All(l => l.LessonTime < DateTime.Now)
                                group s by s.CourseClass.CourseClassCoach.CoachNavigation.LogInId
                                into g
                                orderby g.Count() descending
                                select new
                                {
                                    coach = g.Key
                                };
                foreach (var item in CoachJson.ToList())
                {
                    var coach = from l in _gymcontext.LogIns
                                where l.LogInId == item.coach
                                select new
                                {
                                    ID = l.LogInId,
                                    figure = l.LoginFigure,
                                    name = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    background = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.FirstOrDefault().ID,
                        Coachfigure = coach.FirstOrDefault().figure,
                        Coachname = coach.FirstOrDefault().name,
                        Coachbackground = coach.FirstOrDefault().background,
                        Coachscore = coach.FirstOrDefault().coachscore,
                        Coachskill = coach.FirstOrDefault().coachskill,
                        Coachcomment = coach.FirstOrDefault().coachcomment,
                        Coachexp = coach.FirstOrDefault().coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && !flag.Contains("comment") && flag.Contains("order") && !flag.Contains("exp") && !flag.Contains("score") && flag2.Length.Equals(0))
            {
                var CoachJson = from o in _gymcontext.OrderCourses                                
                                group o by o.OrderClass.CourseClassCoach.CoachNavigation.LogInId
                                into g
                                orderby g.Count() descending
                                select new
                                {
                                    coach = g.Key
                                };
                foreach (var item in CoachJson.ToList())
                {
                    var coach = from l in _gymcontext.LogIns
                                where l.LogInId == item.coach
                                select new
                                {
                                    ID = l.LogInId,
                                    figure = l.LoginFigure,
                                    name = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    background = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.FirstOrDefault().ID,
                        Coachfigure = coach.FirstOrDefault().figure,
                        Coachname = coach.FirstOrDefault().name,
                        Coachbackground = coach.FirstOrDefault().background,
                        Coachscore = coach.FirstOrDefault().coachscore,
                        Coachskill = coach.FirstOrDefault().coachskill,
                        Coachcomment = coach.FirstOrDefault().coachcomment,
                        Coachexp = coach.FirstOrDefault().coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && !flag.Contains("comment") && !flag.Contains("order") && flag.Contains("exp") && !flag.Contains("score") && flag2.Length.Equals(0))
            {
                var CoachJson = _gymcontext.LogIns.Where(l => l.LogInTypeId.Equals(3)).OrderByDescending(l => (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience).Select(l => new
                {
                    ID = l.LogInId,
                    figure = l.LoginFigure,
                    name = l.LogInName,
                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                    background = l.Coach.CoachBackground,
                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                });
                foreach (var coach in CoachJson)
                {
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.ID,
                        Coachfigure = coach.figure,
                        Coachname = coach.name,
                        Coachbackground = coach.background,
                        Coachscore = coach.coachscore,
                        Coachskill = coach.coachskill,
                        Coachcomment = coach.coachcomment,
                        Coachexp = coach.coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && !flag.Contains("comment") && !flag.Contains("order") && !flag.Contains("exp") && flag.Contains("score") && flag2.Length.Equals(0))
            {
                var CoachJson = from s in _gymcontext.MemberScores
                                where s.CourseClass.Lessons.All(l => l.LessonTime < DateTime.Now)
                                group s by s.CourseClass.CourseClassCoach.CoachNavigation.LogInId
                                into g
                                orderby g.Average(s => s.ClassScore) descending
                                select new
                                {
                                    coach = g.Key
                                };
                foreach (var item in CoachJson.ToList())
                {
                    var coach = from l in _gymcontext.LogIns
                                where l.LogInId == item.coach
                                select new
                                {
                                    ID = l.LogInId,
                                    figure = l.LoginFigure,
                                    name = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    background = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.FirstOrDefault().ID,
                        Coachfigure = coach.FirstOrDefault().figure,
                        Coachname = coach.FirstOrDefault().name,
                        Coachbackground = coach.FirstOrDefault().background,
                        Coachscore = coach.FirstOrDefault().coachscore,
                        Coachskill = coach.FirstOrDefault().coachskill,
                        Coachcomment = coach.FirstOrDefault().coachcomment,
                        Coachexp = coach.FirstOrDefault().coachexp
                    });
                }
            }
            
            ///id 1個
            if (string.IsNullOrEmpty(flag) && flag2.Length.Equals(1))
            {
                var CoachJson = from l in _gymcontext.LogIns.Where(l => l.LogInTypeId.Equals(3)&&l.Coach.Skills.Any(s=>s.SkillCourseCategoryId.Equals(flag2.FirstOrDefault())))
                                select new
                                {
                                    coachID = l.LogInId,
                                    coachfigure = l.LoginFigure,
                                    coachname = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    coachbackground = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                foreach (var o in CoachJson)
                {
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = o.coachID,
                        Coachfigure = o.coachfigure,
                        Coachname = o.coachname,
                        Coachscore = o.coachscore,
                        Coachbackground = o.coachbackground,
                        Coachcomment = o.coachcomment,
                        Coachskill = o.coachskill,
                        Coachexp = o.coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && flag.Contains("comment") && !flag.Contains("order") && !flag.Contains("exp") && !flag.Contains("score") && flag2.Length.Equals(1))
            {
                var CoachJson = from s in _gymcontext.MemberScores
                                where s.CourseClass.Lessons.All(l => l.LessonTime < DateTime.Now)
                                group s by s.CourseClass.CourseClassCoach.CoachNavigation.LogInId
                                into g
                                orderby g.Count() descending
                                select new
                                {
                                    coach = g.Key
                                };
                foreach (var item in CoachJson.ToList())
                {
                    var coach = from l in _gymcontext.LogIns
                                where l.LogInId == item.coach&& l.Coach.Skills.Any(s => s.SkillCourseCategoryId.Equals(flag2.FirstOrDefault()))
                                select new
                                {
                                    ID = l.LogInId,
                                    figure = l.LoginFigure,
                                    name = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    background = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.FirstOrDefault().ID,
                        Coachfigure = coach.FirstOrDefault().figure,
                        Coachname = coach.FirstOrDefault().name,
                        Coachbackground = coach.FirstOrDefault().background,
                        Coachscore = coach.FirstOrDefault().coachscore,
                        Coachskill = coach.FirstOrDefault().coachskill,
                        Coachcomment = coach.FirstOrDefault().coachcomment,
                        Coachexp = coach.FirstOrDefault().coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && !flag.Contains("comment") && flag.Contains("order") && !flag.Contains("exp") && !flag.Contains("score") && flag2.Length.Equals(1))
            {
                var CoachJson = from o in _gymcontext.OrderCourses
                                group o by o.OrderClass.CourseClassCoach.CoachNavigation.LogInId
                                into g
                                orderby g.Count() descending
                                select new
                                {
                                    coach = g.Key
                                };
                foreach (var item in CoachJson.ToList())
                {
                    var coach = from l in _gymcontext.LogIns
                                where l.LogInId == item.coach && l.Coach.Skills.Any(s => s.SkillCourseCategoryId.Equals(flag2.FirstOrDefault()))
                                select new
                                {
                                    ID = l.LogInId,
                                    figure = l.LoginFigure,
                                    name = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    background = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.FirstOrDefault().ID,
                        Coachfigure = coach.FirstOrDefault().figure,
                        Coachname = coach.FirstOrDefault().name,
                        Coachbackground = coach.FirstOrDefault().background,
                        Coachscore = coach.FirstOrDefault().coachscore,
                        Coachskill = coach.FirstOrDefault().coachskill,
                        Coachcomment = coach.FirstOrDefault().coachcomment,
                        Coachexp = coach.FirstOrDefault().coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && !flag.Contains("comment") && !flag.Contains("order") && flag.Contains("exp") && !flag.Contains("score") && flag2.Length.Equals(1))
            {
                var CoachJson = _gymcontext.LogIns.Where(l => l.LogInTypeId.Equals(3) && l.Coach.Skills.Any(s => s.SkillCourseCategoryId.Equals(flag2.FirstOrDefault())))
                    .OrderByDescending(l => (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience).Select(l => new
                {
                    ID = l.LogInId,
                    figure = l.LoginFigure,
                    name = l.LogInName,
                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                    background = l.Coach.CoachBackground,
                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                });
                foreach (var coach in CoachJson)
                {
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.ID,
                        Coachfigure = coach.figure,
                        Coachname = coach.name,
                        Coachbackground = coach.background,
                        Coachscore = coach.coachscore,
                        Coachskill = coach.coachskill,
                        Coachcomment = coach.coachcomment,
                        Coachexp = coach.coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && !flag.Contains("comment") && !flag.Contains("order") && !flag.Contains("exp") && flag.Contains("score") && flag2.Length.Equals(1))
            {
                var CoachJson = from s in _gymcontext.MemberScores
                                where s.CourseClass.Lessons.All(l => l.LessonTime < DateTime.Now)
                                group s by s.CourseClass.CourseClassCoach.CoachNavigation.LogInId
                                into g
                                orderby g.Average(s => s.ClassScore) descending
                                select new
                                {
                                    coach = g.Key
                                };
                foreach (var item in CoachJson.ToList())
                {
                    var coach = from l in _gymcontext.LogIns
                                where l.LogInId == item.coach && l.Coach.Skills.Any(s => s.SkillCourseCategoryId.Equals(flag2.FirstOrDefault()))
                                select new
                                {
                                    ID = l.LogInId,
                                    figure = l.LoginFigure,
                                    name = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    background = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.FirstOrDefault().ID,
                        Coachfigure = coach.FirstOrDefault().figure,
                        Coachname = coach.FirstOrDefault().name,
                        Coachbackground = coach.FirstOrDefault().background,
                        Coachscore = coach.FirstOrDefault().coachscore,
                        Coachskill = coach.FirstOrDefault().coachskill,
                        Coachcomment = coach.FirstOrDefault().coachcomment,
                        Coachexp = coach.FirstOrDefault().coachexp
                    });
                }
            }
            
            ///id 2個
            if (string.IsNullOrEmpty(flag) &&  flag2.Length.Equals(2))
            {
                var CoachJson = from l in _gymcontext.LogIns.Where(l => l.LogInTypeId.Equals(3) && l.Coach.Skills.Select(s=>s.SkillCourseCategoryId).Contains(flag2[0])&& l.Coach.Skills.Select(s => s.SkillCourseCategoryId).Contains(flag2[1]))
                                select new
                                {
                                    coachID = l.LogInId,
                                    coachfigure = l.LoginFigure,
                                    coachname = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    coachbackground = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                foreach (var o in CoachJson)
                {
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = o.coachID,
                        Coachfigure = o.coachfigure,
                        Coachname = o.coachname,
                        Coachscore = o.coachscore,
                        Coachbackground = o.coachbackground,
                        Coachcomment = o.coachcomment,
                        Coachskill = o.coachskill,
                        Coachexp = o.coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && flag.Contains("comment") && !flag.Contains("order") && !flag.Contains("exp") && !flag.Contains("score") && flag2.Length.Equals(2))
            {
                var CoachJson = from s in _gymcontext.MemberScores
                                where s.CourseClass.Lessons.All(l => l.LessonTime < DateTime.Now)
                                group s by s.CourseClass.CourseClassCoach.CoachNavigation.LogInId
                                into g
                                orderby g.Count() descending
                                select new
                                {
                                    coach = g.Key
                                };
                foreach (var item in CoachJson.ToList())
                {
                    var coach = from l in _gymcontext.LogIns
                                where l.LogInId == item.coach && l.Coach.Skills.Select(s => s.SkillCourseCategoryId).Contains(flag2[0]) && l.Coach.Skills.Select(s => s.SkillCourseCategoryId).Contains(flag2[1])
                                select new
                                {
                                    ID = l.LogInId,
                                    figure = l.LoginFigure,
                                    name = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    background = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.FirstOrDefault().ID,
                        Coachfigure = coach.FirstOrDefault().figure,
                        Coachname = coach.FirstOrDefault().name,
                        Coachbackground = coach.FirstOrDefault().background,
                        Coachscore = coach.FirstOrDefault().coachscore,
                        Coachskill = coach.FirstOrDefault().coachskill,
                        Coachcomment = coach.FirstOrDefault().coachcomment,
                        Coachexp = coach.FirstOrDefault().coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && !flag.Contains("comment") && flag.Contains("order") && !flag.Contains("exp") && !flag.Contains("score") && flag2.Length.Equals(2))
            {
                var CoachJson = from o in _gymcontext.OrderCourses
                                group o by o.OrderClass.CourseClassCoach.CoachNavigation.LogInId
                                into g
                                orderby g.Count() descending
                                select new
                                {
                                    coach = g.Key
                                };
                foreach (var item in CoachJson.ToList())
                {
                    var coach = from l in _gymcontext.LogIns
                                where l.LogInId == item.coach && l.Coach.Skills.Select(s => s.SkillCourseCategoryId).Contains(flag2[0]) && l.Coach.Skills.Select(s => s.SkillCourseCategoryId).Contains(flag2[1])
                                select new
                                {
                                    ID = l.LogInId,
                                    figure = l.LoginFigure,
                                    name = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    background = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.FirstOrDefault().ID,
                        Coachfigure = coach.FirstOrDefault().figure,
                        Coachname = coach.FirstOrDefault().name,
                        Coachbackground = coach.FirstOrDefault().background,
                        Coachscore = coach.FirstOrDefault().coachscore,
                        Coachskill = coach.FirstOrDefault().coachskill,
                        Coachcomment = coach.FirstOrDefault().coachcomment,
                        Coachexp = coach.FirstOrDefault().coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && !flag.Contains("comment") && !flag.Contains("order") && flag.Contains("exp") && !flag.Contains("score") && flag2.Length.Equals(2))
            {
                var CoachJson = _gymcontext.LogIns.Where(l => l.LogInTypeId.Equals(3) && l.Coach.Skills.Select(s => s.SkillCourseCategoryId).Contains(flag2[0]) && l.Coach.Skills.Select(s => s.SkillCourseCategoryId).Contains(flag2[1]))
                    .OrderByDescending(l => (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience).Select(l => new
                    {
                        ID = l.LogInId,
                        figure = l.LoginFigure,
                        name = l.LogInName,
                        coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                        coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                        background = l.Coach.CoachBackground,
                        coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                        coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                    });
                foreach (var coach in CoachJson)
                {
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.ID,
                        Coachfigure = coach.figure,
                        Coachname = coach.name,
                        Coachbackground = coach.background,
                        Coachscore = coach.coachscore,
                        Coachskill = coach.coachskill,
                        Coachcomment = coach.coachcomment,
                        Coachexp = coach.coachexp
                    });
                }
            }
            if (!string.IsNullOrEmpty(flag) && !flag.Contains("comment") && !flag.Contains("order") && !flag.Contains("exp") && flag.Contains("score") && flag2.Length.Equals(2))
            {
                var CoachJson = from s in _gymcontext.MemberScores
                                where s.CourseClass.Lessons.All(l => l.LessonTime < DateTime.Now)
                                group s by s.CourseClass.CourseClassCoach.CoachNavigation.LogInId
                                into g
                                orderby g.Average(s => s.ClassScore) descending
                                select new
                                {
                                    coach = g.Key
                                };
                foreach (var item in CoachJson.ToList())
                {
                    var coach = from l in _gymcontext.LogIns
                                where l.LogInId == item.coach && l.Coach.Skills.Select(s => s.SkillCourseCategoryId).Contains(flag2[0]) && l.Coach.Skills.Select(s => s.SkillCourseCategoryId).Contains(flag2[1])
                                select new
                                {
                                    ID = l.LogInId,
                                    figure = l.LoginFigure,
                                    name = l.LogInName,
                                    coachscore = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Average(m => m.ClassScore)),
                                    coachskill = l.Coach.Skills.Select(s => s.SkillCourseCategory.CourseCategoryName),
                                    background = l.Coach.CoachBackground,
                                    coachcomment = l.Coach.CourseClasses.Where(c => c.Lessons.All(l => l.LessonTime < DateTime.Now)).Select(c => c.MemberScores.Count()),
                                    coachexp = (DateTime.Now.Year - l.LogInRegisterTime.Year) + l.Coach.CoachExperience
                                };
                    dvlist.Add(new CCoachDisplayViewModel
                    {
                        Coachid = coach.FirstOrDefault().ID,
                        Coachfigure = coach.FirstOrDefault().figure,
                        Coachname = coach.FirstOrDefault().name,
                        Coachbackground = coach.FirstOrDefault().background,
                        Coachscore = coach.FirstOrDefault().coachscore,
                        Coachskill = coach.FirstOrDefault().coachskill,
                        Coachcomment = coach.FirstOrDefault().coachcomment,
                        Coachexp = coach.FirstOrDefault().coachexp
                    });
                }
            }
            return dvlist;
        }
    }
}
