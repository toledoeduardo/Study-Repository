using Byte_meAqui.Models;
using Byte_meAqui.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Byte_meAqui.Controllers
{
    public class ClienteController
    {
        private static int nextId = 1; // Controle de ID
        private List<Cliente> clientes;
        private ClienteRepository clienteRepository = new ClienteRepository();

        public ClienteController()
        {
            clientes = clienteRepository.CarregarClientes();
            if (clientes.Count > 0)
            {
                nextId = clientes.Max(c => c.Id) + 1;
            }
        }

        public void AddCliente(string nome, string email)
        {
            Cliente cliente = new Cliente
            {
                Id = nextId++,
                Nome = nome,
                Email = email
            };
            clientes.Add(cliente);
            clienteRepository.SalvarClientes(clientes);
        }

        public void UpdateCliente(int id, string nome, string email)
        {
            Cliente cliente = clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                cliente.Nome = nome;
                cliente.Email = email;
                clienteRepository.SalvarClientes(clientes);
            }
        }

        public void DeleteCliente(int id)
        {
            Cliente cliente = clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                clienteRepository.SalvarClientes(clientes);
            }
        }

        public void ListClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            else
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome}, Email: {cliente.Email}");
                }
            }
        }
    }
}
