using System;
using System.Collections.Generic;

#nullable disable

namespace prjGymEndTerm.Models
{
    public partial class EquipmentCategory
    {
        public EquipmentCategory()
        {
            Equipment = new HashSet<Equipment>();
        }

        public int EquipmentCategoryId { get; set; }
        public string EquipmentCategoryName { get; set; }
        public string EquipmentPicture { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
