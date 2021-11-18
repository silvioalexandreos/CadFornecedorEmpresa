using CadEmpresaFornecedor.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Services.Base
{
    public abstract class Service
    {
        protected readonly SqlServerContext _context;

        protected Service(SqlServerContext context)
        {
            _context = context;
        }

        protected virtual async Task CommitChanges()
        {
            var changes = 0;
            try
            {
                changes = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

            if (changes <= 0)
            {
                throw new Exception("Erro ao salvar as alterações no banco de dados.");
            }
        }
    }
}
