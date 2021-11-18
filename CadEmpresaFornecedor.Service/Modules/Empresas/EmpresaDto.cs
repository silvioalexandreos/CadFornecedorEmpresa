using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Services.Modules.Empresas
{
    public record EmpresaDto(
        string NomeFantasia,
        string CNPJ,
        string UF
        );
}
