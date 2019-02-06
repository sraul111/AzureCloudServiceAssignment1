using System;


namespace BussinessLogic
{
    /// <summary>
    /// provides Student result.
    /// </summary>
    public class StudentResultCalculator: IStudentResultCalculator
    {
        //public string GetStudentResult(string studentName, double marksObtained, int totalNoOfSubjects, out double percentage)
        //{
        //    int totalMarks = totalNoOfSubjects * 100;
        //    if (marksObtained > totalMarks)
        //    {
        //        throw new ArgumentException(String.Format("Marks obtained --{0} can't be more than {1}",marksObtained, totalMarks));
        //    }

        //    percentage = 0;
        //    percentage = (marksObtained  * 100) / totalMarks;

        //    if (percentage >= 40)
        //        return "Pass";
        //    return "Fail";

        //}

        public Student GetStudentResult(Student student)
        {
            int totalMarks = student.TotalStubjectCount * 100;
            if (student.ObtainedMarks > totalMarks)
            {
                throw new ArgumentException(String.Format("Marks obtained --{0} can't be more than {1}", student.ObtainedMarks, totalMarks));
            }

            student.ResultPercentage = 0;
            student.ResultPercentage = (student.ObtainedMarks * 100) / totalMarks;

            if (student.ResultPercentage >= 40)
                student.ResultStatus = "Pass";
            student.ResultStatus = "Fail";

            return student;
        }
    }
}
