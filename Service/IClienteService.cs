using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IClienteService
    {
        Cliente Salvar(Cliente cliente);
        IList<Cliente> ObterTodos();
    }
}
