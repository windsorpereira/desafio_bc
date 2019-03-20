using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Porte
    {
        public Porte()
        {
            Clientes = new HashSet<Cliente>();
        }   

        public virtual int Id { get; protected set; }
        public virtual string Nome { get; set; }

        public virtual ISet<Cliente> Clientes { get; set; }
    }
}
