using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadEmpresaFornecedor.Infra.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            CreatedAt = DateTime.Now;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; protected set; }

        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
    }
}
