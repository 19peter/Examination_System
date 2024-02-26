﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exam_system_App.Entities;

[Table("Instructor")]
public partial class Instructor
{
    [Key]
    [Column("Ins_ID")]
    public int InsId { get; set; }

    [Column("Ins_Name")]
    [StringLength(255)]
    [Unicode(false)]
    public string InsName { get; set; }

    [Column("Dept_Id")]
    public int? DeptId { get; set; }

    [Column("ins_password")]
    [StringLength(30)]
    [Unicode(false)]
    public string InsPassword { get; set; }

    [InverseProperty("Ins")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [ForeignKey("DeptId")]
    [InverseProperty("Instructors")]
    public virtual Department Dept { get; set; }
}