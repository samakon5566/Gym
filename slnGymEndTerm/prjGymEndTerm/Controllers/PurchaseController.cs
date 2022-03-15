using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using prjGymEndTerm.Models;
using prjGymEndTerm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace prjGymEndTerm.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly GYMContext _gymcontext;

        public PurchaseController(GYMContext gymcontext)
        {
            _gymcontext = gymcontext;
        }

        public IActionResult OrderPurchaselistAll(string id, List<CNormalPurchase> list)
        {
            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
            {
                LogIn user = System.Text.Json.JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));
                if (user.LogInTypeId.Equals(2))
                {
                    var ids = System.Text.Json.JsonSerializer.Deserialize<List<int>>(id);
                    foreach (var num in ids)
                    {
                        var Order = _gymcontext.CourseClasses
                                        .Where(c => c.CourseClassId.Equals(num))
                                        .Select(c => new
                                        {
                                            ClassID = c.CourseClassId,
                                            CategoryName = c.CourseClassDetail.CourseCategory.CourseCategoryName,
                                            CourseClassName = c.CourseClassName,
                                            CourseDetailName = c.CourseClassDetail.CourseDetailName,
                                            DiscountPlan = c.CourseClassPlan.DiscountPlan1,
                                            Classpic = c.CourseClassDetail.CourseDetailPicture,
                                            ClassinitialMoney = Convert.ToDecimal(c.CourseClassDetail.CourseDetailMoney),
                                            ClassdiscountMoney = Convert.ToDecimal(c.CourseClassDetail.CourseDetailMoney) * (1-c.CourseClassPlan.Dicount.DiscountPercent),
                                            ClassMoney = Convert.ToDecimal(c.CourseClassDetail.CourseDetailMoney) * c.CourseClassPlan.Dicount.DiscountPercent
                                        }).FirstOrDefault();
                        
                        list.Add(new CNormalPurchase
                        {
                            txtclassID = Order.ClassID,
                            txtCourseCategory = Order.CategoryName,
                            txtCourseDetail = Order.CourseDetailName,
                            txtCourseClassName = Order.CourseClassName,
                            txtDiscountPlan = Order.DiscountPlan,
                            txtClassPic = Order.Classpic,
                            txtinitailMoney = Order.ClassinitialMoney,
                            txtdiscountMoney = Order.ClassdiscountMoney,
                            txtMoney = Order.ClassMoney.ToString("c")                            
                        });                       
                    }
                    return View(list);
                }
            }
            return RedirectToAction("Login", "Home");

        }

        public IActionResult Orderlessoninfo(int id)
        {
            var courseinfos = _gymcontext.CourseClasses.Where(c => c.CourseClassId.Equals(id)).
            Select(c => new
            {
                classname = c.CourseClassName,
                lessontime = c.Lessons.Select(l => l.LessonTime),
                vacancy = c.CourseClassPeople - c.OrderCourses.Count,
                classpeople = c.CourseClassPeople,
                coachname = c.CourseClassCoach.CoachNavigation.LogInName
            });
            
            return Json(courseinfos);
        }


        public IActionResult Ordercheckout(string paidway,int money,string itemname,CCheckoutViewModel order)
        {
            
            if (paidway.Equals("Credit") || paidway.Equals("CVS")||paidway.Equals("cash"))
            {
                order.tradeNo = "DX" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + "A";
                order.totalamount = money;
                order.itemName = itemname;
                order.backtoURL = "https://msit132gym.azurewebsites.net/GroupCourse/課程與選購";
                order.merchantTradeDate = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
                order.returnurl = "https://developers.opay.tw/AioMock/MerchantReturnUrl";
                order.payment = paidway;
                string checkmac = $"HashKey=5294y06JbISpM5x9&ChoosePayment={paidway}&ClientBackURL={order.backtoURL}&CreditInstallment=&EncryptType=1&InstallmentAmount=&ItemName={order.itemName}&MerchantID=2000132&MerchantTradeDate={order.merchantTradeDate}&MerchantTradeNo={order.tradeNo}&PaymentType=aio&Redeem=&ReturnURL={order.returnurl}&StoreID=&TotalAmount={order.totalamount}&TradeDesc=建立信用卡測試訂單&HashIV=v77hoKGq4kWxNNIS";
                string checkmacUTF8 = HttpUtility.UrlEncode(checkmac, Encoding.UTF8);
                string checkmacUTF8Lower = checkmacUTF8.ToLower();
                SHA256 sha256 = SHA256.Create();
                order.checkmacvalue = (GetHash(sha256, checkmacUTF8Lower)).ToUpper();
            }

            if (HttpContext.Session.Keys.Contains(LoginDictionary.SK_Logined_User))
            {
                LogIn user = System.Text.Json.JsonSerializer.Deserialize<LogIn>(HttpContext.Session.GetString(LoginDictionary.SK_Logined_User));

                char[] separators = new char[] { ':', ';' };
                string[] orderarray = itemname.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < orderarray.Length; i += 2)
                {
                    OrderCourse OrderCourse = new OrderCourse
                    {
                        OrderMemberId = user.LogInId,
                        OrderStatusId = 3,
                        OrderClassId = Convert.ToInt32(orderarray[i]),
                        OrderPaymentId = OrderPaymentid(paidway),
                        OrderTime = Convert.ToDateTime(order.merchantTradeDate)
                    };

                    _gymcontext.Add(OrderCourse);
                    var lessonids = _gymcontext.Lessons.Where(l => l.LessonClassId.Equals(Convert.ToInt32(orderarray[i]))).Select(l => l.LessonId).ToList();
                    foreach (var id in lessonids)
                    {
                        MemberLesson memberLesson = new MemberLesson
                        {
                            MemberLessonLessonId = id,
                            MemberLessonMemberId = user.LogInId
                        };
                        _gymcontext.Add(memberLesson);
                    }
                    _gymcontext.SaveChanges();
                }
            }
            return Json(order);

        }

        private int OrderPaymentid(string Payment)
        {
            if (Payment.Equals("Credit"))
                return 1;
            else
                return 2;
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
