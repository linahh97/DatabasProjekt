using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabasProjekt.Models
{
    public partial class TblTeachers
    {
        public TblTeachers()
        {
            Course = new HashSet<Course>();
        }

        public int TeacherId { get; set; }
        public string Tname { get; set; }
        public string Tcourse { get; set; }
        public string Tdepartment { get; set; }

        public virtual TblStaff Teacher { get; set; }
        public virtual ICollection<Course> Course { get; set; }
    }
}
