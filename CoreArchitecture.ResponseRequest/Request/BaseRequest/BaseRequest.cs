namespace CoreArchitecture.ResponseRequest.Request.BaseRequest
{
    public class BaseRequest<T>
    {
        public T Id { get; set; }
    }
    public class BaseRequest : BaseRequest<int>
    {

    }

}
