using CoreArchitecture.Facade;
using CoreArchitecture.ResponseRequest.Response;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CoreArchitecture.API.Controllers.Base;

namespace CoreArchitecture.API.Controllers
{
    public class StudentController : BaseController
    {
        private readonly IStudentFacade _studentFacade;

        public StudentController(IStudentFacade studentFacade)
        {
            this._studentFacade = studentFacade;
        }

        [HttpGet]
        [Route("GetAllStudent")]
        public Task<GetAllStudentResponse> GetAllStudent()
        {
            var response = _studentFacade.GetAllStudent();
            return response;
        }

    }

}
