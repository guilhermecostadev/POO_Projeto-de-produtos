using System;

namespace Projeto_de_Produtos_.classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }
        
        public void Logar(Usuario usuario)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Bem vindo ao Projeto de Produtos\n");
            Console.ResetColor();
            Console.WriteLine($"Entrar na aplicação\n");

            Console.WriteLine($"Insira seu e-Mail:");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine($"Insira sua senha:");
            string senhaLogin = Console.ReadLine();
            
            if (emailLogin == usuario.Email && senhaLogin == usuario.Senha)
            {
                Logado = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Login realizado com sucesso!\n");
                Console.ResetColor();

            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Falha ao acessar aplicação.");
                Console.ResetColor();
            }            
        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {
            Produto itemMenu = new Produto();
            Marca marcaMenu  = new Marca();

            string opcao = "m";
            do
            {
                Console.WriteLine("------ Menu de Navegação ------\n");
                Console.WriteLine("Escolha uma das opções abaixo:\n");

                Console.WriteLine("1 - Cadastrar novo produto");
                Console.WriteLine("2 - Lista de produtos cadastrados");
                Console.WriteLine("3 - Deletar um produto");
                Console.WriteLine("4 - Cadastrar nova marca");
                Console.WriteLine("5 - Listar marcas cadastradas");
                Console.WriteLine("6 - Deletar uma marca");
                Console.WriteLine("0 - LogOut");
                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                        itemMenu.CadastrarItem();
                        break;

                    case "2":
                        itemMenu.ListarItem();
                        break;

                    case "3":
                        Console.WriteLine($"Digite o código do produto a ser excluído:");
                        int codigo = int.Parse(Console.ReadLine());
                        itemMenu.DeletarItem(codigo);
                        break;

                    case "4":
                        marcaMenu.Cadastrar();
                        break;

                    case "5":
                        marcaMenu.Listar();
                        break;

                    case "6":
                        Console.WriteLine($"Digite o código da marca a ser excluída:");
                        int codigoMarca = int.Parse(Console.ReadLine());
                        itemMenu.DeletarItem(codigoMarca);
                        break;

                    default:
                        Console.WriteLine($"Opção Inválida");                        
                        break;
                }
                
                
                
            } while (opcao != "0");
            Console.WriteLine($"Sessão Finalizada!\nVolte sempre.");
            
        }
        
    }
}