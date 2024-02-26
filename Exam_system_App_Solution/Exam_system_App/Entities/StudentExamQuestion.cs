﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exam_system_App.Entities;

[PrimaryKey("StId", "QuestionId")]
[Table("Student_Exam_Question")]
public partial class StudentExamQuestion
{
    [Key]
    [Column("ST_ID")]
    public int StId { get; set; }

    [Key]
    [Column("Question_ID")]
    public int QuestionId { get; set; }

    [Column("Exam_ID")]
    public int ExamId { get; set; }

    [Column("Student_Answer")]
    [StringLength(100)]
    [Unicode(false)]
    public string StudentAnswer { get; set; }

    [ForeignKey("ExamId")]
    [InverseProperty("StudentExamQuestions")]
    public virtual Exam Exam { get; set; }

    [ForeignKey("QuestionId")]
    [InverseProperty("StudentExamQuestions")]
    public virtual Question Question { get; set; }

    [ForeignKey("StId")]
    [InverseProperty("StudentExamQuestions")]
    public virtual Student St { get; set; }
}