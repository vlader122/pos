using DB;
using DB.Models;

namespace Repository
{
    public class ClienteRepository : IRepository<Cliente>
    {
        private readonly PosContext _context;
        public ClienteRepository(PosContext context)
        {
            _context = context;
        }
        public void Create(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            List<Cliente> clientes = _context.Clientes.ToList();
            return clientes;
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
