using CadEmpresaFornecedor.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Services.Modules.Empresas
{
    public class EmpresaParser
    {
        public static EmpresaDto ToDto(Empresa empresa)
        {
            return new EmpresaDto(empresa.NomeFantasia, empresa.CNPJ, empresa.UF);
        }

        public static Empresa ToEntity(EmpresaDto dto)
        {
            return new Empresa(dto.NomeFantasia, dto.CNPJ, dto.UF);
        }
    }
}
