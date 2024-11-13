using DB.Models;
using Repository;

namespace Service
{
    public class ClienteService : IService<Cliente>
    {
        private readonly ClienteRepository _clienteRepository;
        public ClienteService(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public Cliente Create(Cliente entity)
        {
            return _clienteRepository.Create(entity);
        }

        public Cliente Delete(int id)
        {
            return _clienteRepository.Delete(id);

        }

        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _clienteRepository.GetById(id);

        }

        public Cliente Update(Cliente entity)
        {
            return _clienteRepository.Update(entity);

        }
    }
}
