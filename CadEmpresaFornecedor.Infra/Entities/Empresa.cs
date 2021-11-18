using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Infra.Entities
{
    [Table("tb_empresa")]
    public class Empresa : Entity
    {
        public Empresa(string nomeFantasia, string cNPJ, string uF)
        {
            NomeFantasia = nomeFantasia;
            CNPJ = cNPJ;
            UF = uF;
        }
        public Empresa()
        {

        }

        [MaxLength(150)]
        public string NomeFantasia { get; private set; }
        [MaxLength(14)]
        public string CNPJ { get; private set; }
        [MaxLength(2)]
        public string UF { get; private set; }
    }
}
