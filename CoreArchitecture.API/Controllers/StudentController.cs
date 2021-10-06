using CoreArchitecture.API.Controllers.Base;
using CoreArchitecture.Facade;
using Microsoft.AspNetCore.Mvc;

namespace CoreArchitecture.API.Controllers
{
    public class StudentController : BaseController
    {
        private readonly IStudentFacade studentFacade;

        public StudentController(IStudentFacade studentFacade)
        {
            this.studentFacade = studentFacade;
        }

        [HttpGet]
        public IActionResult GetApi()
        {
            return Ok("Api Work");
        }

    }

}
