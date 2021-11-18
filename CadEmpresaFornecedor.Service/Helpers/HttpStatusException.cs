using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Services.Helpers
{
    public abstract class HttpStatusException : Exception
    {
        protected HttpStatusException(HttpStatusCode statusCode, string message = null)
            : base(message)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; protected set; }

        public virtual ObjectResult CreateObjectResult()
        {
            return new ObjectResult(new
            {
                Message,
                Data,
                Source,
            })
            {
                StatusCode = (int)this.StatusCode,
            };
        }
    }
}
