using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CPurchaseSecureViewModel
    {
        public string membername { get; set; }
        public string coursecategory { get; set; }
        public string coursedetail { get; set; }
        public string courseclass { get; set; }
        public string coursemoney { get; set; }
        public decimal discount { get; set; }
        public string discountqty { get; internal set; }
        public string pracprice { get; internal set; }
    }
}
