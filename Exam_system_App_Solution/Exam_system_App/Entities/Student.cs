﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exam_system_App.Entities;

[Table("Student")]
public partial class Student
{
    [Key]
    [Column("St_ID")]
    public int StId { get; set; }

    [Column("ST_Fname")]
    [StringLength(30)]
    [Unicode(false)]
    public string StFname { get; set; }

    [Column("ST_Lname")]
    [StringLength(30)]
    [Unicode(false)]
    public string StLname { get; set; }

    [Column("ST_Email")]
    [StringLength(30)]
    [Unicode(false)]
    public string StEmail { get; set; }

    [Column("ST_Password")]
    [StringLength(30)]
    [Unicode(false)]
    public string StPassword { get; set; }

    [Column("Dept_Id")]
    public int DeptId { get; set; }

    [ForeignKey("DeptId")]
    [InverseProperty("Students")]
    public virtual Department Dept { get; set; }

    [InverseProperty("St")]
    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    [InverseProperty("St")]
    public virtual ICollection<StudentExamQuestion> StudentExamQuestions { get; set; } = new List<StudentExamQuestion>();
}