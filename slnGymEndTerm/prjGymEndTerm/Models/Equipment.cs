using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            EquipmentRestorations = new HashSet<EquipmentRestoration>();
        }

        public int EquipmentId { get; set; }
        public int EquipmentCategoryId { get; set; }
        public DateTime EquipmentDay { get; set; }
        public int EquipmentCycle { get; set; }
        public int EquipmentCompanyId { get; set; }
        public int EquipmentClassroomId { get; set; }

        public virtual EquipmentCategory EquipmentCategory { get; set; }
        public virtual Classroom EquipmentClassroom { get; set; }
        public virtual Company EquipmentCompany { get; set; }
        public virtual ICollection<EquipmentRestoration> EquipmentRestorations { get; set; }
    }
}
