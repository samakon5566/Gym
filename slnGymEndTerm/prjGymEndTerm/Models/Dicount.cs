using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class Dicount
    {
        public Dicount()
        {
            DiscountPlans = new HashSet<DiscountPlan>();
        }

        public int DicountId { get; set; }
        public decimal DiscountPercent { get; set; }

        public virtual ICollection<DiscountPlan> DiscountPlans { get; set; }
    }
}
