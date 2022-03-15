using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{
    public class AboutController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly GYMContext gym;

        public AboutController(IWebHostEnvironment p, GYMContext context)
        {
            _environment = p;
            gym = context;
        }

        public IActionResult Index()
        {
            //主頁
            return View();
        }

        public IActionResult List()
        {
            //設備環境
            return View();
        }

        public IActionResult ServiceList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ServiceList(CustomerLetter c)
        {
            
            c.LetterStatusId = 2;
            c.LetterTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            gym.Add(c);
            gym.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public IActionResult ContactInformation()
        {
            //聯絡資訊 
            return View();
        }
    }
}
