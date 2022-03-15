using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CPurchaseOrderinfoViewModel
    {
        public string classname { get; set; }
        public IEnumerable<string> lessontime { get; set; }        
        public int vacancy { get; set; }
        public string coachname { get; set; }
    }
}
