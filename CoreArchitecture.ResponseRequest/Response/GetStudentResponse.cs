using System.Collections.Generic;
using CoreArchitecture.Domain.Entities;

namespace CoreArchitecture.ResponseRequest.Response
{
    public class CreateStudentResponse
    {
        public CreateStudentResponse()
        {
            StudentList = new List<Student>();
        }

        public List<Student> StudentList { get; set; }
    }
}
