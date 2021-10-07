using System.Collections.Generic;
using System.Threading.Tasks;
using CoreArchitecture.Domain.Entities;
using CoreArchitecture.ResponseRequest.Request;
using CoreArchitecture.ResponseRequest.Response;
using MediatR;

namespace CoreArchitecture.Facade
{
    public class StudentFacade : IStudentFacade
    {
        private readonly IMediator _mediatr;
        public StudentFacade(IMediator mediatr)
        {
            this._mediatr = mediatr;
        }
        public async Task<GetAllStudentResponse> GetAllStudent()
        {
            var response = _mediatr.Send(new GetAllStudentRequest());
            return await response;
        }

        public Student GetStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateStudent(Student student)
        {
            throw new System.NotImplementedException();
        }
    }
}
