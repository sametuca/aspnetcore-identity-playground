using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreArchitecture.API.Controllers.Base;
using CoreArchitecture.Facade;

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
