using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos_.classes
{
    public class Marca
    {
        int Codigo { get; set; }
        public string NomeMarca { get; set; }
        DateTime DataCadastro { get; set; }        
        public List<Marca> ListaMarcas = new List<Marca>();
        
        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();
            //é necessário fazer a instância de uma nova marca dentro do método para que seja possível inseri-la à Lista de Marcas

            Console.Write("Digite o código da marca: ");
            novaMarca.Codigo = int.Parse (Console.ReadLine());

            Console.Write("Digite o nome da marca: ");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.UtcNow;  

            ListaMarcas.Add(novaMarca);

            return novaMarca;                   
        }

        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Marcas Cadastradas");
            
            foreach (Marca item in ListaMarcas)
            {
                Console.WriteLine($"Código da Marca: {item.Codigo}\nNome da Marca: {item.NomeMarca}\n");
                
            }
            Console.ResetColor();
        }

        public void Deletar (int _cod)
        {
            Marca marcaDeletada = ListaMarcas.Find(x => x.Codigo == _cod);
            //é necessario criar uma instância de Marca para que a lista a percorra e encontre o código inserido 
            
            ListaMarcas.Remove(marcaDeletada); 
        }

    }
}