using Byte_meAqui.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Byte_meAqui.Repository
{
    public class ClienteRepository
    {
        private string filePath = "clientes.txt";

        public List<Cliente> CarregarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            if (File.Exists(filePath))
            {
                var linhas = File.ReadAllLines(filePath);
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(';');
                    var cliente = new Cliente
                    {
                        Id = int.Parse(dados[0]),
                        Nome = dados[1],
                        Email = dados[2]
                    };
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }

        public void SalvarClientes(List<Cliente> clientes)
        {
            var linhas = clientes.Select(c => $"{c.Id};{c.Nome};{c.Email}");
            File.WriteAllLines(filePath, linhas);
        }
    }
}
