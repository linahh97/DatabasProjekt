using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabasProjekt.Models
{
    public partial class Course
    {
        public int TeachId { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string IsActive { get; set; }

        public virtual TblTeachers Teach { get; set; }
    }
}
