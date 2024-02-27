﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Exam_system_App.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam_system_App.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionChoice> QuestionChoices { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<StudentExamQuestion> StudentExamQuestions { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=online_Examination;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasOne(d => d.Ins).WithMany(p => p.Courses).HasConstraintName("FK_Course_Instructor");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepId).HasName("PK__Departme__0C2B45CD663DD630");

            entity.Property(e => e.DepName).UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Crs).WithMany(p => p.Exams).HasConstraintName("FK_Exam_Course");

            entity.HasMany(d => d.Questions).WithMany(p => p.Exams)
                .UsingEntity<Dictionary<string, object>>(
                    "ExamQuestion",
                    r => r.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Questions_Question"),
                    l => l.HasOne<Exam>().WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Questions_Exam"),
                    j =>
                    {
                        j.HasKey("ExamId", "QuestionId");
                        j.ToTable("Exam_Questions");
                        j.IndexerProperty<int>("ExamId").HasColumnName("Exam_ID");
                        j.IndexerProperty<int>("QuestionId").HasColumnName("Question_ID");
                    });
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InsId).HasName("PK__Instruct__151409CD278D14C9");

            entity.HasOne(d => d.Dept).WithMany(p => p.Instructors).HasConstraintName("FK_Instructor_Department");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasOne(d => d.Crs).WithMany(p => p.Questions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Question_Course");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasOne(d => d.Dept).WithMany(p => p.Students)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Department");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasOne(d => d.Crs).WithMany(p => p.StudentCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Course_Course");

            entity.HasOne(d => d.St).WithMany(p => p.StudentCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Course_Student");
        });

        modelBuilder.Entity<StudentExamQuestion>(entity =>
        {
            entity.HasOne(d => d.Exam).WithMany(p => p.StudentExamQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Exam_Question_Exam");

            entity.HasOne(d => d.Question).WithMany(p => p.StudentExamQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Exam_Question_Question");

            entity.HasOne(d => d.St).WithMany(p => p.StudentExamQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Exam_Question_Student");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.Property(e => e.TopicId).ValueGeneratedNever();

            entity.HasOne(d => d.Crs).WithMany(p => p.Topics)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Topic_Course");
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingGeneratedFunctions(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}