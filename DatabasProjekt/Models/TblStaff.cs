using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabasProjekt.Models
{
    public partial class TblStaff
    {
        public int StaffId { get; set; }
        public string Sname { get; set; }
        public string Position { get; set; }
        public string DateWork { get; set; }
        public decimal Salary { get; set; }
        public int? DepId { get; set; }

        public virtual TblDepartment Dep { get; set; }
        public virtual TblTeachers TblTeachers { get; set; }
    }
}
