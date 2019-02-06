using System;
using NUnit.Framework;
using BussinessLogic;

namespace TestBusinessLogic
{
    class StudentResultShould
    {
        private IStudentResultCalculator studentResultCalculator;

        [SetUp]
        public void TestSetup()
        {
            studentResultCalculator = new StudentResultCalculator();
        }
       
        [Test]
        public void ThrowArgumentExceptionIfMarksObtainedIsMoreThanTotalMarks()
        {
            //Arrange
            string studentName = "Parag";
            int marksObtained = 600;
            int totalNoOfSubjects = 5;
            double percentage;

            Student student = new Student{Name="Raju", ObtainedMarks=500,TotalStubjectCount = 3};
           
            //Act //Assert
            Assert.Throws<ArgumentException>(()=>studentResultCalculator.GetStudentResult(student));
        }

        //[Test]
        //public void GetLessThan40PercentageforTheseInputs()
        //{

        //    //Arrange
        //    string studentName = "Uday";
        //    int marksObtained = 100;
        //    int totalNoOfSubjects = 5;
        //    double percentage;

        //    //Act
        //    var result = studentResultCalculator.GetStudentResult(studentName, marksObtained, totalNoOfSubjects, out percentage);
        //    //Assert
        //    Assert.AreEqual(20, percentage,"Expected 20 percent but looks like some error has occurred");
        //}

        //[Test]
        //public void Get40PercentAsOutput()
        //{
        //    //Arrange
        //    string studentName = "Uday";
        //    int marksObtained = 200;
        //    int totalNoOfSubjects = 5;
        //    double percentage;

        //    //Act
        //    var result = studentResultCalculator.GetStudentResult(studentName, marksObtained, totalNoOfSubjects, out percentage);
        //    //Assert
        //    Assert.AreEqual(40,percentage, "Expected 40 percent but looks like some error has occurred");
        //}
        
        //[Test]
        //public void ResultShouldBePassIfMoreThaOrEqualTo40()
        //{
        //    //Arrange
        //    string studentName = "Uday";
        //    int marksObtained = 200;
        //    int totalNoOfSubjects = 5;
        //    double percentage;

        //    //Act
        //    var result = studentResultCalculator.GetStudentResult(studentName, marksObtained, totalNoOfSubjects, out percentage);
        //    //Assert
        //    Assert.AreEqual("Pass",result,"Result expected was pass but looks like some error has occurred.");
        //}


        //[Test]
        //public void ResultShouldBeFailIfLessThanEqualTo40()
        //{
        //    //Arrange
        //    string studentName = "Uday";
        //    int marksObtained = 100;
        //    int totalNoOfSubjects = 5;
        //    double percentage;

        //    //Act
        //    var result = studentResultCalculator.GetStudentResult(studentName, marksObtained, totalNoOfSubjects, out percentage);
        //    //Assert
        //    Assert.AreEqual("Fail", result, "Expected Fail as ouput but looks  like some error has occurred.");
        //}



    }
}
