using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CPostureChangeViewModel
    {
        public int RecordId { get; set; }
        public int OrderId { get; set; }
        [DisplayName("體重(kg)")]
        public decimal? Weight { get; set; }
        [DisplayName("肌肉量(kg)")]
        public decimal? MuscleBass { get; set; }
        [DisplayName("基礎代謝(Cal)")]
        public decimal? BasalMetabolism { get; set; }
        [DisplayName("體脂率(%)")]
        public decimal? Fat { get; set; }
        [DisplayName("紀錄時間")]
        public DateTime? RecordTime { get; set; }
                
    }
}
