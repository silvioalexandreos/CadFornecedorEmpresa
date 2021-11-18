using CadEmpresaFornecedor.Infra.Context;
using CadEmpresaFornecedor.Infra.Entities;
using CadEmpresaFornecedor.Services.Base;
using CadEmpresaFornecedor.Services.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Services.Modules.Empresas
{
    public class EmpresaService : Service
    {
        private readonly DbSet<Empresa> _empresaSet;
        public EmpresaService(SqlServerContext context) : base(context)
        {
            _empresaSet = _context.Set<Empresa>();
        }

        public async Task<IEnumerable<EmpresaDto>> ObterTodasEmpresas()
        {
            

            if (!await _empresaSet.AnyAsync())
            {
                throw new NotFoundException("Nenhuma empresa cadastrada.");
            }

            var empresas = await _empresaSet.OrderBy(x => x.NomeFantasia).ToListAsync();

            var listEmpresas = new List<EmpresaDto>();
            foreach (var item in empresas)
            {
                listEmpresas.Add(EmpresaParser.ToDto(item));
            }

            return listEmpresas;
        }
    }
}
