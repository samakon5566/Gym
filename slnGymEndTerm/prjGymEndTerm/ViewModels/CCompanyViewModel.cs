using prjGymEndTerm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjGymEndTerm.ViewModels
{
    public class CCompanyViewModel
    {
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

        public int CompanyId
        {
            get { return this.company.CompanyId; }
            set { this.company.CompanyId = value; }
        }

        [DisplayName("廠商名稱")]
        public string CompanyName
        {
            get { return this.company.CompanyName; }
            set { this.company.CompanyName = value; }
        }

        [DisplayName("廠商電話")]
        public string ComapnyPhone
        {
            get { return this.company.ComapnyPhone; }
            set { this.company.ComapnyPhone = value; }
        }

        [DisplayName("廠商統編")]
        public int CompanyTaxId
        {
            get { return this.company.CompanyTaxId; }
            set { this.company.CompanyTaxId = value; }
        }

        public virtual ICollection<Equipment> Equipment { get; set; }

    }
}
