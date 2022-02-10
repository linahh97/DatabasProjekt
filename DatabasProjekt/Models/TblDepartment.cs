using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabasProjekt.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblStaff = new HashSet<TblStaff>();
        }

        public int DepId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<TblStaff> TblStaff { get; set; }
    }
}
