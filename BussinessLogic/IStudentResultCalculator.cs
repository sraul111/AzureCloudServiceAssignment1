

namespace BussinessLogic
{
   public interface IStudentResultCalculator
   {
       Student GetStudentResult(Student student);

     // string GetStudentResult(string studentName, double marksObtained, int totalNoOfSubjects, out double percentage);
    }
}
