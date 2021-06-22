using System;
using System.Collections.Generic;
using System.Text;

namespace CoreArchitecture.ResponseRequest.Response.BaseResponse
{
    public class BaseResponse<T>
    {
        public T Id { get; set; }
    }
    public class BaseResponse : BaseResponse<int>
    {
        
    }
}
