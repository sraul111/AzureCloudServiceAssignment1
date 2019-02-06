using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using BussinessLogic;
using Microsoft.WindowsAzure.ServiceRuntime;


namespace WebRole2.Controllers
{
    public class StudentController : ApiController
    {
        private string jsonData;

        private readonly int
            totalSubject = 5; // Convert.ToInt32(RoleEnvironment.GetConfigurationSettingValue("SubjectCount"));

        private readonly IStudentResultCalculator studentResultCalculator;

       

    public StudentController(IStudentResultCalculator studentResultCalculator)
        {
            this.studentResultCalculator = studentResultCalculator;
        }

        //[HttpGet]
        //public HttpResponseMessage Get(double totalObtainedMarks, string studentName)
        //{
           
        //    if (string.IsNullOrEmpty(studentName))
        //    {
        //        jsonData = "{\"Error\":\" Invalid Name\"}";
        //    }
        //    else if (totalSubject <= 0)
        //    {
        //        jsonData = "{\"Error\":\" Invalid Total Subject count\"}";
        //    }
        //    else if (totalObtainedMarks > (totalSubject * 100))
        //    {
        //        jsonData = "{\"Error\":\" Invalid mark obtained and total no of marks Values\"}";
        //    }
        //    else
        //    {
        //        double percentage;
               
        //        var resultStatus = studentResultCalculator.GetStudentResult(studentName, totalObtainedMarks, totalSubject, out percentage);
        //        jsonData = "{\"Name\":\"" + studentName + "\",\"Percentage\":\"" + percentage + "\",\"Passing Status\":\"" + resultStatus + "}";
        //    }

        //    var resp = new HttpResponseMessage()
        //    {
        //        Content = new StringContent(jsonData)
        //    };
        //    resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    return resp;
        //}


    }
}
