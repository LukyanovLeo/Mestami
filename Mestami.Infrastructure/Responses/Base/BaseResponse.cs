using System.Net;

namespace Mestami.Infrastructure.Responses.Base
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Description { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public T Content { get; set; }
    }
}