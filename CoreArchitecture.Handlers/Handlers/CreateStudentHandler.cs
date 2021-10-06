using CoreArchitecture.ResponseRequest.Request;
using CoreArchitecture.ResponseRequest.Response;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreArchitecture.Handlers.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentRequest, CreateStudentResponse>
    {
        public Task<CreateStudentResponse> Handle(CreateStudentRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
