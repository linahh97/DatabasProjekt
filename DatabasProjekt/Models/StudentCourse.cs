using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabasProjekt.Models
{
    public partial class StudentCourse
    {
        public int StudCourseId { get; set; }
        public string Course1 { get; set; }
        public string Course2 { get; set; }
        public string Course3 { get; set; }

        public virtual TblStudents StudCourse { get; set; }
    }
}
