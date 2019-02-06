

namespace BussinessLogic
{
   public interface IStudentResultCalculator
   {
       string GetStudentResult(string studentName, double marksObtained, int totalNoOfSubjects,
           out double percentage);
   }
}
