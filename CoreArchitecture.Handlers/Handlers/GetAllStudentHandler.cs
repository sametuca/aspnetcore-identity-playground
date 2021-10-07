using CoreArchitecture.ResponseRequest.Request;
using CoreArchitecture.ResponseRequest.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CoreArchitecture.Domain;
using CoreArchitecture.Domain.Entities;

namespace CoreArchitecture.Handlers.Handlers
{
    public class GetAllStudentHandler : IRequestHandler<GetAllStudentRequest, GetAllStudentResponse>
    {
        private readonly ApplicationDbContext _dbcontext;

        public GetAllStudentHandler(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Task<GetAllStudentResponse> Handle(GetAllStudentRequest request,
            CancellationToken cancellationToken)
        {
            var testStudent = new GetAllStudentResponse()
            {
                StudentList = new List<Student>()
                {
                    new Student()
                    {
                        Id = 1,
                        Name = "samet",
                        Notes = new List<Note>()
                        {
                            new Note()
                            {
                                Id = 1,
                                StudentId = 1
                            }
                        }
                    }
                }
            };
            return Task.FromResult(testStudent);
        }
    }
}
