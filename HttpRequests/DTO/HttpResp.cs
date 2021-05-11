using System;
using System.Net;

namespace HttpRequests.DTO
{
    public class HttpResp
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public Type Object { get; set; }
    }
}
