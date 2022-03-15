using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class NewsType
    {
        public NewsType()
        {
            News = new HashSet<News>();
        }
        public int NewsTypeId { get; set; }
        public string NewsTypeName { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
