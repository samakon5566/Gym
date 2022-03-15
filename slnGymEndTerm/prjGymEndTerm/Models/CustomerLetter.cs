using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class CustomerLetter
    {
        public string LetterName { get; set; }
        public string LetterEmail { get; set; }
        public int LetterId { get; set; }
        public string LetterContent { get; set; }
        public int LetterStatusId { get; set; }
        public int? LetterManergerId { get; set; }
        public string LetterManergerContent { get; set; }
        public DateTime? LetterTime { get; set; }
        public string LetterPhone { get; set; }

        public virtual LogIn LetterManerger { get; set; }
        public virtual LetterStatus LetterStatus { get; set; }
    }
}
