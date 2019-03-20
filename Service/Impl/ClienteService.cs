using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Data.Repositories;

namespace Service.Impl
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IList<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public Cliente Salvar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
