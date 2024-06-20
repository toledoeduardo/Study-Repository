using Byte_meAqui.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Byte_meAqui.Repository
{
    public class ProdutoRepository
    {
        private string filePath = "produtos.txt";

        public List<Produto> CarregarProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            if (File.Exists(filePath))
            {
                var linhas = File.ReadAllLines(filePath);
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(';');
                    var produto = new Produto
                    {
                        Id = int.Parse(dados[0]),
                        Nome = dados[1],
                        Preco = decimal.Parse(dados[2])
                    };
                    produtos.Add(produto);
                }
            }
            return produtos;
        }

        public void SalvarProdutos(List<Produto> produtos)
        {
            var linhas = produtos.Select(p => $"{p.Id};{p.Nome};{p.Preco}");
            File.WriteAllLines(filePath, linhas);
        }
    }
}

