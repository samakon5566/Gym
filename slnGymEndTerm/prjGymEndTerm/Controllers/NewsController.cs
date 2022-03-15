using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels.News_ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{
    public class NewsController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly GYMContext gym;
        public NewsController(IWebHostEnvironment p, GYMContext context)
        {
            _environment = p;
            gym = context;
        }

        public IActionResult popularActivities2()
        {
            var news = (gym.News.
                       Include(n => n.NewsManager).Where(n => n.NewsTypeId == 1)).OrderByDescending(c => c.NewsTime.Date);

            List<CPopularViewModel> list = new List<CPopularViewModel>();
            int i = 0;
            foreach (var item in news)
            {
                i++;
                if (i > 5)
                {
                    list.Add(new CPopularViewModel() { news = item });
                }
            }
            return View(list);
        }

        public IActionResult popularActivities()
        {
            var news = (gym.News.
                   Include(n => n.NewsManager).Where(n => n.NewsTypeId == 1)).OrderByDescending(c => c.NewsTime.Date);
            List<CPopularViewModel> list = new List<CPopularViewModel>();
            int i = 0;
            foreach (var item in news)
            {
                i++;
                if (i <= 5)
                {
                    list.Add(new CPopularViewModel() { news = item });
                }
            }
            return View(list);
        }

        public IActionResult News()
        {
            var news = (gym.News.Include(n => n.NewsManager)
                .Where(n => n.NewsTypeId == 5)).OrderByDescending(c=>c.NewsTime.Date);

            List<CNewsViewModel> list = new List<CNewsViewModel>();
            int i = 0;
            foreach (var item in news)
            {
                i++;
                if (i <= 5)
                {
                    list.Add(new CNewsViewModel() { news = item });
                }
            }
            return View(list);
        }
        public IActionResult News2()
        {
            var news = (gym.News.Include(n => n.NewsManager)
                 .Where(n => n.NewsTypeId == 5)).OrderByDescending(c => c.NewsTime.Date);

            List<CNewsViewModel> list = new List<CNewsViewModel>();
            int i = 0;
            foreach (var item in news)
            {
                i++;
                if (i > 5)
                {
                    list.Add(new CNewsViewModel() { news = item });
                }
            }
            return View(list);
        }

        public IActionResult discount()
        {
            var news = from t in gym.News
                       where t.NewsTypeId.Equals(2)
                       orderby t.NewsTime descending
                       select t;
            return View(news);
        }
        public IActionResult discount2()
        {
            var news = from t in gym.News
                       where t.NewsTypeId.Equals(2)
                       orderby t.NewsTime descending
                       select t;
            return View(news);
        }
        public IActionResult popularActivitiesIdnex1()
        {
            return View();
        }

        public IActionResult announcement()
        {
            var news = gym.News.Include(n => n.NewsManager)
                .Where(n => n.NewsTypeId == 5 && (n.NewsTitle.Contains("公告") || n.NewsContent.Contains("公告")));
            List<CNewsViewModel> list = new List<CNewsViewModel>();
            foreach (var item in news)
            {
                list.Add(new CNewsViewModel() { news = item });

            }
            return View(list);
        }

        public IActionResult epidemic()
        {
            var news = gym.News.Include(n => n.NewsManager)
                .Where(n => n.NewsTypeId == 5 && (n.NewsTitle.Contains("疫情") || n.NewsContent.Contains("疫情")));
            List<CNewsViewModel> list = new List<CNewsViewModel>();
            foreach (var item in news)
            {
                list.Add(new CNewsViewModel() { news = item });
            }
            return View(list);
        }

        public IActionResult personalTraining()
        {
            var news = gym.News.Include(n => n.NewsManager)
                .Where(n => n.NewsTypeId == 5 && (n.NewsTitle.Contains("個人教練") || n.NewsContent.Contains("個人教練")));
            List<CNewsViewModel> list = new List<CNewsViewModel>();
            foreach (var item in news)
            {
                list.Add(new CNewsViewModel() { news = item });

            }
            return View(list);
        }


        public IActionResult menu()
        {
            var news = gym.News.Include(n => n.NewsManager)
                .Where(n => n.NewsTypeId == 5 && (n.NewsTitle.Contains("菜單") || n.NewsContent.Contains("菜單")));
            List<CNewsViewModel> list = new List<CNewsViewModel>();
            foreach (var item in news)
            {

                list.Add(new CNewsViewModel() { news = item });

            }
            return View(list);
        }


        public IActionResult dogym()
        {
            var news = gym.News.Include(n => n.NewsManager)
                .Where(n => n.NewsTypeId == 1 && (n.NewsTitle.Contains("健身") || n.NewsContent.Contains("健身")));
            List<CPopularViewModel> list = new List<CPopularViewModel>();
            foreach (var item in news)
            {

                list.Add(new CPopularViewModel() { news = item });
            }
            return View(list);
        }

        public IActionResult dom()
        {
            var news = gym.News.Include(n => n.NewsManager)
                .Where(n => n.NewsTypeId == 1 && (n.NewsTitle.Contains("動滋劵") || n.NewsContent.Contains("動滋劵")));
            List<CPopularViewModel> list = new List<CPopularViewModel>();
            foreach (var item in news)
            {

                list.Add(new CPopularViewModel() { news = item });
            }
            return View(list);
        }

        public IActionResult member()
        {
            var news = gym.News.Include(n => n.NewsManager)
                .Where(n => n.NewsTypeId == 1 && (n.NewsTitle.Contains("會員") || n.NewsContent.Contains("會員")));
            List<CPopularViewModel> list = new List<CPopularViewModel>();
            foreach (var item in news)
            {

                list.Add(new CPopularViewModel() { news = item });
            }
            return View(list);
        }

        public IActionResult yoga()
        {
            var news = gym.News.Include(n => n.NewsManager)
                .Where(n => n.NewsTypeId == 1 && (n.NewsTitle.Contains("瑜珈") || n.NewsContent.Contains("瑜珈")));
            List<CPopularViewModel> list = new List<CPopularViewModel>();
            foreach (var item in news)
            {
                list.Add(new CPopularViewModel() { news = item });
            }
            return View(list);
        }

    }
}
