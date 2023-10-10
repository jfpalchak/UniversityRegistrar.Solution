using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    [Required(ErrorMessage = "* Student Name cannot be empty.")]
    public string Name { get; set; }
    public int StudentId { get; set; }
    [Required(ErrorMessage = "* Please enter date of enrollment.")]
    [DataType(DataType.DateTime)]
    public DateTime? EnrollmentDate { get; set; }

    // Collection Navigation Property
    public List<Enrollment> JoinEntities { get; set; }
  }
}