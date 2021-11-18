using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Services.Helpers
{
    public class NotFoundException : HttpStatusException
    {
        public NotFoundException(string message = "Nenhum recurso foi encontrado.")
            : base(HttpStatusCode.NotFound, message)
        {
        }
    }
}
