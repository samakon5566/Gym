using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class LoginCreateValidationViewModel
    {
        public string txtAcount { get; set; }
        public string txtIdNum { get; set; }
        public LogIn logIns { get; set; }
        public string InformExist()
        {
            string flag = "";
            if (!string.IsNullOrEmpty(txtAcount) || !string.IsNullOrEmpty(txtIdNum))
            {
                var account = new GYMContext().LogIns.FirstOrDefault(n => n.LogInAccount == txtAcount);
                var IdNum = new GYMContext().LogIns.FirstOrDefault(n => n.LogInIdNumber == txtIdNum);
                if (account != null)
                    flag = "　<i class='fas fa-times - circle'></i>　該帳號已被使用";

                if (IdNum != null)
                    flag = "　<i class='fas fa-times - circle'></i>　該身分證字號已存在";
            }
            return flag;
        }
    }
}
