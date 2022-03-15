using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class LoginType
    {
        public LoginType()
        {
            LogIns = new HashSet<LogIn>();
        }

        public int LoginTypeId { get; set; }
        public string LoginTypeName { get; set; }

        public virtual ICollection<LogIn> LogIns { get; set; }
    }
}
