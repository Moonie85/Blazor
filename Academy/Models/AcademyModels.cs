using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    [Table("Directions")]
    public class Direction
    {
        [Column("direction_id")]
        public byte Id { get; set; }

        [Column("direction_name")]
        public string? Name { get; set; }
    }

    [Table("Groups")]
    public class Group
    {
        [Column("group_id")]
        public int Id { get; set; }

        [Column("group_name")]
        public string? Name { get; set; }

        [Column("direction")]
        public byte? DirectionId { get; set; }

        [Column("weekdays")]
        public byte? Weekdays { get; set; }

        [Column("start_time")]
        public TimeOnly? StartTime { get; set; }
    }

    [Table("Students")]
    public class Student
    {
        [Column("stud_id")]
        public int Id { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("birth_date")]
        public DateOnly? BirthDate { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("photo")]
        public byte[]? Photo { get; set; }

        [Column("group")]
        public int? GroupId { get; set; }
    }

    [Table("Teachers")]
    public class Teacher
    {
        [Column("teacher_id")]
        public short Id { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("birth_date")]
        public DateOnly? BirthDate { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("photo")]
        public byte[]? Photo { get; set; }

        [Column("work_since")]
        public DateOnly? WorkSince { get; set; }

        [Column("rate")]
        public decimal? Rate { get; set; }
    }
}