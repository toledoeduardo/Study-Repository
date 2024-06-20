using Byte_meAqui.Models;
using System.Collections.Generic;
using System;

namespace Byte_meAqui.Views
{
    public class ProdutoView
    {
        public void DisplayAllProducts(IEnumerable<Produto> produtos)
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco}");
            }
        }

        public void DisplayProductDetails(Produto produto)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco}");
        }
    }
}
