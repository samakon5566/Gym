using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CCheckoutViewModel
    {
        /// <summary>
        /// checkout
        /// </summary>
        public string tradeNo { get; set; }
        public int totalamount { get; set; }
        public string itemName { get; set; }
        public string backtoURL { get; set; }
        public string merchantTradeDate { get; set; }
        public string returnurl { get; set; }
        public string payment { get; set; }
        public string checkmacvalue { get; set; }

    }
}
