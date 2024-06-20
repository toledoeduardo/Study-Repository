using Byte_meAqui.Models;
using Byte_meAqui.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Byte_meAqui.Controllers
{
    public class ProdutoController
    {
        private static int nextId = 1; // Controle de ID
        private List<Produto> produtos;
        private ProdutoRepository produtoRepository = new ProdutoRepository();

        public ProdutoController()
        {
            produtos = produtoRepository.CarregarProdutos();
            if (produtos.Count > 0)
            {
                nextId = produtos.Max(p => p.Id) + 1;
            }
        }

        public void AddProduto(string nome, decimal preco)
        {
            Produto produto = new Produto
            {
                Id = nextId++,
                Nome = nome,
                Preco = preco
            };
            produtos.Add(produto);
            produtoRepository.SalvarProdutos(produtos);
        }

        public void UpdateProduto(int id, string nome, decimal preco)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produto.Nome = nome;
                produto.Preco = preco;
                produtoRepository.SalvarProdutos(produtos);
            }
        }

        public void DeleteProduto(int id)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                produtos.Remove(produto);
                produtoRepository.SalvarProdutos(produtos);
            }
        }

        public void ListProdutos()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            else
            {
                foreach (var produto in produtos)
                {
                    Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco}");
                }
            }
        }
    }
}
