using System.Net;

namespace Mestami.Infrastructure.Responses.Base
{
    public interface IBaseResponse<T>
    {
        HttpStatusCode StatusCode { get; }

        T Content { get; }
    }
}
