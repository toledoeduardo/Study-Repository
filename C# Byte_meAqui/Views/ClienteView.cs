using Byte_meAqui.Models;
using System.Collections.Generic;
using System;

namespace Byte_meAqui.Views
{
    public class ClienteView
    {
        public void DisplayAllClientes(IEnumerable<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome}, Email: {cliente.Email}");
            }
        }

        public void DisplayClienteDetails(Cliente cliente)
        {
            Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome}, Email: {cliente.Email}");
        }
    }
}
