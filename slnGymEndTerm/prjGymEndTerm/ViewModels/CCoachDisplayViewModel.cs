using System.Collections.Generic;

namespace prjGymEndTerm.ViewModels
{
    public class CCoachDisplayViewModel
    {
        public int Coachid { get; set; }
        public string Coachfigure { get; set; }
        public string Coachname { get; set; }
        public IEnumerable<double> Coachscore { get; set; }
        public IEnumerable<string> Coachskill { get; set; }
        public string Coachbackground { get; set; }
        public IEnumerable<int> Coachcomment { get; set; }
        public int? Coachexp { get; set; }
    }
}
