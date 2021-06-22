using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoreArchitecture.ResponseRequest.Request;
using CoreArchitecture.ResponseRequest.Response;
using MediatR;

namespace CoreArchitecture.Handlers.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentRequest,CreateStudentResponse>
    {
        public Task<CreateStudentResponse> Handle(CreateStudentRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
