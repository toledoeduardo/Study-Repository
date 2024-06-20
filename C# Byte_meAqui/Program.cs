using Byte_meAqui.Controllers;
using System;

namespace Byte_meAqui
{
    class Program
    {
        static ProdutoController produtoController = new ProdutoController();
        static ClienteController clienteController = new ClienteController();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo(a) Ao Sistema De Gerenciamento da Byte-meAqui!\n");

            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();

                Console.Write("\nDigite a opção desejada: ");
                string opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        ListarProdutos();
                        break;
                    case "2":
                        AdicionarProduto();
                        break;
                    case "3":
                        AtualizarProduto();
                        break;
                    case "4":
                        ExcluirProduto();
                        break;
                    case "5":
                        ListarClientes();
                        break;
                    case "6":
                        AdicionarCliente();
                        break;
                    case "7":
                        AtualizarCliente();
                        break;
                    case "8":
                        ExcluirCliente();
                        break;
                    case "9":
                        continuar = false;
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Obrigado por usar o Sistema de Gerenciamento da Byte-meAqui!");
        }

        static void MostrarMenu()
        {
            Console.WriteLine("* Menu Principal *");
            Console.WriteLine("1. Lista de produtos");
            Console.WriteLine("2. Adicionar produto");
            Console.WriteLine("3. Atualizar produto");
            Console.WriteLine("4. Excluir produto");
            Console.WriteLine("5. Lista de clientes");
            Console.WriteLine("6. Adicionar cliente");
            Console.WriteLine("7. Atualizar cliente");
            Console.WriteLine("8. Excluir cliente");
            Console.WriteLine("9. Sair do programa");
        }

        static void ListarProdutos()
        {
            Console.WriteLine("* Lista de Produtos *");
            produtoController.ListProdutos();
        }

        static void AdicionarProduto()
        {
            Console.WriteLine("* Adicionar Produto *");

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            produtoController.AddProduto(nome, preco);
            Console.WriteLine("Produto adicionado com sucesso.");
        }

        static void AtualizarProduto()
        {
            Console.WriteLine("* Atualizar Produto *");

            Console.Write("Digite o ID do produto que deseja atualizar: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite o novo nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o novo preço do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            produtoController.UpdateProduto(id, nome, preco);
        }

        static void ExcluirProduto()
        {
            Console.WriteLine("* Excluir Produto *");

            Console.Write("Digite o ID do produto que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());

            produtoController.DeleteProduto(id);
        }

        static void ListarClientes()
        {
            Console.WriteLine("* Lista de Clientes *");
            clienteController.ListClientes();
        }

        static void AdicionarCliente()
        {
            Console.WriteLine("* Adicionar Cliente *");

            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o email do cliente: ");
            string email = Console.ReadLine();

            clienteController.AddCliente(nome, email);
            Console.WriteLine("Cliente adicionado com sucesso.");
        }

        static void AtualizarCliente()
        {
            Console.WriteLine("* Atualizar Cliente *");

            Console.Write("Digite o ID do cliente que deseja atualizar: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite o novo nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o novo email do cliente: ");
            string email = Console.ReadLine();

            clienteController.UpdateCliente(id, nome, email);
        }

        static void ExcluirCliente()
        {
            Console.WriteLine("* Excluir Cliente *");

            Console.Write("Digite o ID do cliente que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());

            clienteController.DeleteCliente(id);
        } 
    }
}  