﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam_system_App.Entities
{
    public partial class Instructor_Courses_ReportResult
    {
        [Column("Course Name")]
        public string CourseName { get; set; }
        [Column("Students Count")]
        public int? StudentsCount { get; set; }
    }
}