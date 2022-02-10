using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DatabasProjekt.Models
{
    public partial class TestSchool2DbContext : DbContext
    {
        public TestSchool2DbContext()
        {
        }

        public TestSchool2DbContext(DbContextOptions<TestSchool2DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<StudentCourse> StudentCourse { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblGrades> TblGrades { get; set; }
        public virtual DbSet<TblStaff> TblStaff { get; set; }
        public virtual DbSet<TblStudents> TblStudents { get; set; }
        public virtual DbSet<TblTeachers> TblTeachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = LAPTOP-RTVA969K;Initial Catalog=TestSchool2;Integrated Security = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseName)
                    .HasName("PK_Course_1");

                entity.Property(e => e.CourseName).HasMaxLength(50);

                entity.Property(e => e.CourseId)
                    .IsRequired()
                    .HasColumnName("CourseID")
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeachId).HasColumnName("TeachID");

                entity.HasOne(d => d.Teach)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.TeachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_tblTeachers");
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(e => e.StudCourseId);

                entity.Property(e => e.StudCourseId)
                    .HasColumnName("StudCourseID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Course1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Course2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Course3)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.StudCourse)
                    .WithOne(p => p.StudentCourse)
                    .HasForeignKey<StudentCourse>(d => d.StudCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentCourse_tblStudents");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DepId)
                    .HasName("PK_tblDepStaff");

                entity.ToTable("tblDepartment");

                entity.Property(e => e.DepId)
                    .HasColumnName("DepID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblGrades>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblGrades");

                entity.Property(e => e.Courses).HasMaxLength(50);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.GradeDate).HasColumnType("date");

                entity.Property(e => e.StudGradeId).HasColumnName("StudGradeID");

                entity.Property(e => e.TeachGradeId).HasColumnName("TeachGradeID");

                entity.HasOne(d => d.CoursesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Courses)
                    .HasConstraintName("FK_tblGrades_Course");

                entity.HasOne(d => d.StudGrade)
                    .WithMany()
                    .HasForeignKey(d => d.StudGradeId)
                    .HasConstraintName("FK_tblGrades_StudentCourse");

                entity.HasOne(d => d.StudGradeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StudGradeId)
                    .HasConstraintName("FK_tblGrades_tblStudents");

                entity.HasOne(d => d.TeachGrade)
                    .WithMany()
                    .HasForeignKey(d => d.TeachGradeId)
                    .HasConstraintName("FK_tblGrades_tblTeachers");
            });

            modelBuilder.Entity<TblStaff>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("tblStaff");

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateWork).HasMaxLength(10);

                entity.Property(e => e.DepId).HasColumnName("DepID");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sname)
                    .IsRequired()
                    .HasColumnName("SName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.TblStaff)
                    .HasForeignKey(d => d.DepId)
                    .HasConstraintName("FK_tblStaff_tblDepStaff");
            });

            modelBuilder.Entity<TblStudents>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("tblStudents");

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClassYear)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("LName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTeachers>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.ToTable("tblTeachers");

                entity.Property(e => e.TeacherId)
                    .HasColumnName("TeacherID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Tcourse)
                    .IsRequired()
                    .HasColumnName("TCourse")
                    .HasMaxLength(50);

                entity.Property(e => e.Tdepartment)
                    .IsRequired()
                    .HasColumnName("TDepartment")
                    .HasMaxLength(50);

                entity.Property(e => e.Tname)
                    .IsRequired()
                    .HasColumnName("TName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Teacher)
                    .WithOne(p => p.TblTeachers)
                    .HasForeignKey<TblTeachers>(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTeachers_tblStaff");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
