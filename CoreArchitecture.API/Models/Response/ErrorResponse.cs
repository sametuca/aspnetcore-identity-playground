using System.Collections.Generic;

namespace CoreArchitecture.API.JWT.Models.Response
{
    public class ErrorResponse
    {
        public IEnumerable<string> ErrorMessages { get; set; }

        public ErrorResponse(string errorMessage) : this(new List<string>() { errorMessage })
        {

        }

        public ErrorResponse(IEnumerable<string> errorMessages)
        {

        }
    }
}
