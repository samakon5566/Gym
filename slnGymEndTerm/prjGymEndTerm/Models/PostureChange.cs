using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class PostureChange
    {
        public int RecordId { get; set; }
        public int OrderId { get; set; }
        public decimal? Weight { get; set; }
        public decimal? MuscleBass { get; set; }
        public decimal? BasalMetabolism { get; set; }
        public decimal? Fat { get; set; }
        public DateTime? RecordTime { get; set; }

        public virtual OrderCourse Order { get; set; }
    }
}
