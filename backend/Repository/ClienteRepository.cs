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
        public Cliente Create(Cliente entity)
        {
            Cliente cliente = new Cliente();
            cliente.Nombres = entity.Nombres;
            cliente.Apellidos = entity.Apellidos;
            cliente.Telefono = entity.Telefono;
            cliente.Direccion = entity.Direccion;
            _context.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }

        public Cliente Delete(int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return cliente;
        }

        public List<Cliente> GetAll()
        {
            List<Cliente> clientes = _context.Clientes.ToList();
            return clientes;
        }

        public Cliente GetById(int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            return cliente;
        }

        public Cliente Update(Cliente entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
