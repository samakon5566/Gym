using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{
    public class OnlineCourse : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly GYMContext gym;

        public OnlineCourse(IWebHostEnvironment p, GYMContext context)
        {
            _environment = p;
            gym = context;
        }
        public IActionResult OnlineVideo()
        {
            var onlinevideo = gym.FitnessVideos.Include(c => c.FitnessVideoCoach.CoachNavigation);
            List<CFitnessVideoViewModel> fitnesses = new List<CFitnessVideoViewModel>();
            foreach (var item in onlinevideo)
            {
                fitnesses.Add(new CFitnessVideoViewModel()
                {
                    fitnessVideo = item
                });
            }
            return View(fitnesses);
        }


        public IActionResult categoryselect()
        {
            var category = gym.CourseCategories.Select(m => new
            {
                m.CourseCategoryId,
                m.CourseCategoryName
            });
            return Json(category);
        }
        public IActionResult coachselect(int SkillCourseCategoryId)
        {
            var coach = gym.FitnessVideos.Where(s => s.FitnessVideoCourseCategoryId == SkillCourseCategoryId)
              .Select(s => new { s.FitnessVideoCoachId, s.FitnessVideoCoach.CoachNavigation.LogInName }).Distinct();
            return Json(coach);

        }
        public IActionResult videodisplay(int SkillCourseCategoryId,int categoryid)
        {
            if (SkillCourseCategoryId == 0)
            {
                var Videosall = gym.FitnessVideos.Where(v => v.FitnessVideoCourseCategoryId.Equals(categoryid))
                 .Select(v => new
                 {
                     coachname = v.FitnessVideoCoach.CoachNavigation.LogInName,
                     videoname = v.FitnessVideoTitle,
                     videocontent = v.FitnessVideoContent,
                     videourl = v.FitnessVideoUrl
                 });
                return Json(Videosall);
            }
            var Videos = gym.FitnessVideos.Where(v => v.FitnessVideoCoachId.Equals(SkillCourseCategoryId) && v.FitnessVideoCourseCategoryId == categoryid)
                 .Select(v => new
                 {
                     coachname = v.FitnessVideoCoach.CoachNavigation.LogInName,
                     videoname = v.FitnessVideoTitle,
                     videocontent = v.FitnessVideoContent,
                     videourl = v.FitnessVideoUrl
                 });
            return Json(Videos);
        }
        public IActionResult coachvideodisplay(int SkillCourseCategoryId)
        {
            if (SkillCourseCategoryId == 0) {
                var Videosall = gym.FitnessVideos
                 .Select(v => new
                 {
                     coachname = v.FitnessVideoCoach.CoachNavigation.LogInName,
                     videoname = v.FitnessVideoTitle,
                     videocontent = v.FitnessVideoContent,
                     videourl = v.FitnessVideoUrl
                 });
                return Json(Videosall);
            }
            var Videos = gym.FitnessVideos.Where(v => v.FitnessVideoCourseCategoryId.Equals(SkillCourseCategoryId))
                 .Select(v => new
                 {
                     coachname = v.FitnessVideoCoach.CoachNavigation.LogInName,
                     videoname = v.FitnessVideoTitle,
                     videocontent = v.FitnessVideoContent,
                     videourl = v.FitnessVideoUrl
                 });
            return Json(Videos);
        }


    }
}
