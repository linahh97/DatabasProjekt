using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabasProjekt.Models
{
    public partial class TblGrades
    {
        public int? StudGradeId { get; set; }
        public int? TeachGradeId { get; set; }
        public string Courses { get; set; }
        public string Grade { get; set; }
        public int? GradeNum { get; set; }
        public DateTime? GradeDate { get; set; }

        public virtual Course CoursesNavigation { get; set; }
        public virtual StudentCourse StudGrade { get; set; }
        public virtual TblStudents StudGradeNavigation { get; set; }
        public virtual TblTeachers TeachGrade { get; set; }
    }
}
