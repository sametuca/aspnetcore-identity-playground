using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreArchitecture.API.Controllers.Base;
using Microsoft.Extensions.Logging;

namespace CoreArchitecture.API.Controllers
{
    public class ExceptionController : BaseController
    {
        private readonly ILogger<ExceptionController> _logger;

        public ExceptionController(ILogger<ExceptionController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            throw new Exception("Test exception");
        }
    }
}
