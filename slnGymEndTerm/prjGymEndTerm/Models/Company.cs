using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class Company
    {
        public Company()
        {
            Equipment = new HashSet<Equipment>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ComapnyPhone { get; set; }
        public int CompanyTaxId { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
