using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class LetterStatus
    {
        public LetterStatus()
        {
            CustomerLetters = new HashSet<CustomerLetter>();
        }

        public int LetterStatusId { get; set; }
        public string LetterStatusName { get; set; }

        public virtual ICollection<CustomerLetter> CustomerLetters { get; set; }
    }
}
