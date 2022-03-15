using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.Controllers
{
    public class OneCourseController : Controller
    {
        public IActionResult OneCourse_benefit()
        {
            return View();
        }
        
        public IActionResult 一對一課程介紹()
        {
            return View();
            //一對一課程介紹_1器材訓練
            //一對一課程介紹_2自由重量
            //一對一課程介紹_3飲食控制
            //一對一課程介紹_4生活型態
            
        }
        public IActionResult 一對一課程介紹_1器材訓練()
        {
            return View();

        }
        public IActionResult 一對一課程介紹_2自由重量()
        {
            return View();

        }
        public IActionResult 一對一課程介紹_3飲食控制()
        {
            return View();

        }
        public IActionResult 一對一課程介紹_4生活型態()
        {
            return View();
        }
    }
}
