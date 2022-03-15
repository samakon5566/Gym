using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CEquipmentViewModel
    {
        private Equipment _equipment = null;
        public Equipment equipment
        {
            get
            {
                if (_equipment == null)
                    _equipment = new Equipment();
                return _equipment;
            }
            set { _equipment = value; }
        }

        [DisplayName("設備編號")]

        public int EquipmentId
        {
            get { return this.equipment.EquipmentId; }
            set { this.equipment.EquipmentId = value; }
        }

        [DisplayName("設備種類")]

        public int EquipmentCategoryId
        {
            get { return this.equipment.EquipmentCategoryId; }
            set { this.equipment.EquipmentCategoryId = value; }
        }

        [DisplayName("進貨時間")]
        public DateTime EquipmentDay
        {
            get { return this.equipment.EquipmentDay; }
            set { this.equipment.EquipmentDay = value; }
        }

        [DisplayName("維修週期(年)")]
        public int EquipmentCycle
        {
            get { return this.equipment.EquipmentCycle; }
            set { this.equipment.EquipmentCycle = value; }
        }

        [DisplayName("廠商")]

        public int EquipmentCompanyId
        {
            get { return this.equipment.EquipmentCompanyId; }
            set { this.equipment.EquipmentCompanyId = value; }
        }

        [DisplayName("教室")]

        public int EquipmentClassroomId
        {
            get { return this.equipment.EquipmentClassroomId; }
            set { this.equipment.EquipmentClassroomId = value; }
        }

        public virtual EquipmentCategory EquipmentCategory { get; set; }
        public virtual Classroom EquipmentClassroom { get; set; }
        public virtual Company EquipmentCompany { get; set; }
        public virtual ICollection<EquipmentRestoration> EquipmentRestorations { get; set; }


        private Company _company = null;
        public Company company
        {
            get
            {
                if (_company == null)
                    _company = new Company();
                return _company;
            }
            set { _company = value; }
        }

        [DisplayName("廠商")]
        public string CompanyName
        {
            get { return this.company.CompanyName; }
            set { this.company.CompanyName = value; }
        }



        private EquipmentCategory _equipmentCategory = null;
        public EquipmentCategory equipmentCategory
        {
            get
            {
                if (_equipmentCategory == null)
                    _equipmentCategory = new EquipmentCategory();
                return _equipmentCategory;
            }
            set { _equipmentCategory = value; }
        }

        [DisplayName("設備種類")]
        public string EquipmentCategoryName
        {
            get { return this.equipmentCategory.EquipmentCategoryName; }
            set { this.equipmentCategory.EquipmentCategoryName = value; }
        }


        private Classroom _classroom = null;
        public Classroom classroom
        {
            get
            {
                if (_classroom == null)
                    _classroom = new Classroom();
                return _classroom;
            }
            set { _classroom = value; }
        }

        [DisplayName("教室")]
        public string ClassroomName
        {
            get { return this.classroom.ClassroomName; }
            set { this.classroom.ClassroomName = value; }
        }
    }
}
