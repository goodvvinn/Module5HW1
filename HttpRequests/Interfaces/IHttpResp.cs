using System.Net;

namespace HttpRequests.Interfaces
{
    public interface IHttpResp
    {
        HttpStatusCode HttpStatusCode { get; set; }
        string DefaultMessage { get; set; }
    }
}
