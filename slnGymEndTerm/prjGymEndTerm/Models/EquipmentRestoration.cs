using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class EquipmentRestoration
    {
        public int RestorationId { get; set; }
        public int EquipmentId { get; set; }
        public DateTime? EquipmentStayServiceDay { get; set; }
        public DateTime? EquipmentServiceDay { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
