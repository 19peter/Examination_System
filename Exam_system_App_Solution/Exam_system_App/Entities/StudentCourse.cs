﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exam_system_App.Entities;

[PrimaryKey("StId", "CrsId")]
[Table("Student_Course")]
public partial class StudentCourse
{
    [Key]
    [Column("St_ID")]
    public int StId { get; set; }

    [Key]
    [Column("Crs_ID")]
    public int CrsId { get; set; }

    [Column("Final_Grade")]
    public int? FinalGrade { get; set; }

    [ForeignKey("CrsId")]
    [InverseProperty("StudentCourses")]
    public virtual Course Crs { get; set; }

    [ForeignKey("StId")]
    [InverseProperty("StudentCourses")]
    public virtual Student St { get; set; }
}