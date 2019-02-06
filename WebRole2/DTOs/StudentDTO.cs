using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BussinessLogic;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace WebRole2.DTOs
{
    public class StudentDTO : IValidatableObject
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int ObtainedMarks { get; set; }

        public Student ToStudent()
        {
            return new Student()
            {
                Name = Name,
                ObtainedMarks = ObtainedMarks
            };
        }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            int totalStubjectCount = Convert.ToInt32(RoleEnvironment.GetConfigurationSettingValue("SubjectCount"));
            if (string.IsNullOrEmpty(Name))
            {
                yield return new ValidationResult("Student name is Required");
            }
            else if (ObtainedMarks < 0)
            {
                yield return new ValidationResult("Invalid Obtained Marks");
            }
            else if (ObtainedMarks > (totalStubjectCount * 100))
            {
                yield return new ValidationResult("Obtained Marks should be less then Total Marks");
            }
        }
    }
}