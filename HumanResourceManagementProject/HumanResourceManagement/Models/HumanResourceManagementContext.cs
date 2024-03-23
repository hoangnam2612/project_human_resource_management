using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HumanResourceManagement.Models;

public partial class HumanResourceManagementContext : DbContext
{
    public HumanResourceManagementContext()
    {
    }

    public HumanResourceManagementContext(DbContextOptions<HumanResourceManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Allowance> Allowances { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<AwardDiscipline> AwardDisciplines { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeAllowance> EmployeeAllowances { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<Overtime> Overtimes { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SalaryAdvance> SalaryAdvances { get; set; }

    public virtual DbSet<ShiftType> ShiftTypes { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WorkType> WorkTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=nam26122003;database=HumanResourceManagement;TrustServerCertificate=true;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Allowance>(entity =>
        {
            entity.ToTable("Allowance");

            entity.Property(e => e.AllowanceId).HasColumnName("AllowanceID");
            entity.Property(e => e.AllowanceName).HasMaxLength(50);
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.ToTable("Attendance");

            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.WorkTypeId).HasColumnName("WorkTypeID");

            entity.HasOne(d => d.Employee).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Attendance_Employee");

            entity.HasOne(d => d.WorkType).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.WorkTypeId)
                .HasConstraintName("FK_Attendance_WorkType");
        });

        modelBuilder.Entity<AwardDiscipline>(entity =>
        {
            entity.ToTable("Award_Discipline");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adcount).HasColumnName("ADCount");
            entity.Property(e => e.Content).HasMaxLength(500);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.HasOne(d => d.Employee).WithMany(p => p.AwardDisciplines)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Award_Discipline_Employee");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Address).HasMaxLength(300);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Idcart)
                .HasMaxLength(50)
                .HasColumnName("IDCart");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PositionId).HasColumnName("PositionID");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_Employee_Department");

            entity.HasOne(d => d.Position).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_Employee_Position");

            entity.HasOne(d => d.Skill).WithMany(p => p.Employees)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("FK_Employee_Skill");
        });

        modelBuilder.Entity<EmployeeAllowance>(entity =>
        {
            entity.ToTable("Employee_Allowance");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllowanceId).HasColumnName("AllowanceID");
            entity.Property(e => e.Content).HasMaxLength(500);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.HasOne(d => d.Allowance).WithMany(p => p.EmployeeAllowances)
                .HasForeignKey(d => d.AllowanceId)
                .HasConstraintName("FK_Employee_Allowance_Allowance");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeAllowances)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Employee_Allowance_Employee");
        });

        modelBuilder.Entity<Insurance>(entity =>
        {
            entity.ToTable("Insurance");

            entity.Property(e => e.InsuranceId).HasColumnName("InsuranceID");
            entity.Property(e => e.CoverageStartDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.InsuranceNumber).HasMaxLength(50);
            entity.Property(e => e.InsuranceProvider).HasMaxLength(50);
            entity.Property(e => e.RegisteredClinic).HasMaxLength(100);

            entity.HasOne(d => d.Employee).WithMany(p => p.Insurances)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Insurance_Employee");
        });

        modelBuilder.Entity<Overtime>(entity =>
        {
            entity.ToTable("Overtime");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ShiftTypeId).HasColumnName("ShiftTypeID");

            entity.HasOne(d => d.Employee).WithMany(p => p.Overtimes)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Overtime_Employee");

            entity.HasOne(d => d.ShiftType).WithMany(p => p.Overtimes)
                .HasForeignKey(d => d.ShiftTypeId)
                .HasConstraintName("FK_Overtime_ShiftType");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.ToTable("Position");

            entity.Property(e => e.PositionId).HasColumnName("PositionID");
            entity.Property(e => e.PositionName).HasMaxLength(50);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<SalaryAdvance>(entity =>
        {
            entity.ToTable("SalaryAdvance");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.HasOne(d => d.Employee).WithMany(p => p.SalaryAdvances)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_SalaryAdvance_Employee");
        });

        modelBuilder.Entity<ShiftType>(entity =>
        {
            entity.ToTable("ShiftType");

            entity.Property(e => e.ShiftTypeId).HasColumnName("ShiftTypeID");
            entity.Property(e => e.ShiftTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.ToTable("Skill");

            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.SkillName).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.Employee).WithMany(p => p.Users)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_User_Employee");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_User_Role");
        });

        modelBuilder.Entity<WorkType>(entity =>
        {
            entity.ToTable("WorkType");

            entity.Property(e => e.WorkTypeId).HasColumnName("WorkTypeID");
            entity.Property(e => e.WorkTypeName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
