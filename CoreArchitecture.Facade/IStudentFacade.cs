using CoreArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreArchitecture.ResponseRequest.Response;

namespace CoreArchitecture.Facade
{
    public interface IStudentFacade
    {
        public Task<GetAllStudentResponse> GetAllStudent();
        Student GetStudent(int id);
        bool DeleteStudent(int id);
        bool UpdateStudent(Student student);

    }
}
