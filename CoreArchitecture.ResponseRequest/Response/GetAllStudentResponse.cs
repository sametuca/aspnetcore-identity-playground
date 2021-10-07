using System.Collections.Generic;
using CoreArchitecture.Domain.Entities;

namespace CoreArchitecture.ResponseRequest.Response
{
    public class GetAllStudentResponse
    {
        public GetAllStudentResponse()
        {
            StudentList = new List<Student>();
        }

        public List<Student> StudentList { get; set; }
    }
}
