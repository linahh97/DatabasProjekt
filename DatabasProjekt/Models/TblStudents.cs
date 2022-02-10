using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabasProjekt.Models
{
    public partial class TblStudents
    {
        public int StudentId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string ClassYear { get; set; }
        public int SocNum { get; set; }
        public string Address { get; set; }

        public virtual StudentCourse StudentCourse { get; set; }
    }
}
