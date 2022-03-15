using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class News
    {
        public int NewsTypeId { get; set; }
        public int NewsId { get; set; }
        public int NewsManagerId { get; set; }
        public DateTime NewsTime { get; set; }
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public string NewsFigure { get; set; }
        public virtual LogIn NewsManager { get; set; }
        public virtual NewsType NewsType { get; set; }
    }
}
