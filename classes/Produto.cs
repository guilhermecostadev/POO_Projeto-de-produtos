using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos_.classes
{
    public class Produto
    {
        int CodigoProduto { get; set; }
        string NomeProduto { get; set; }
        public float PrecoProduto { get; set; }
        DateTime DataCadastroP { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();        
        public List<Produto> ListaProdutos = new List<Produto>();
        
        public void CadastrarItem()
        {
            Produto novoItem = new Produto();

            Console.WriteLine($"Insira o Código do Produto:");
            novoItem.CodigoProduto = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o Nome do Produto:");
            novoItem.NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Insira o Preço do Produto:");
            novoItem.PrecoProduto = float.Parse(Console.ReadLine());
            
            novoItem.DataCadastroP = DateTime.UtcNow;

            //[CLASSE MARCA] alteramos o método Cadastrar do tipo void para Marca e retornamos novaMarca para conseguir acesso ao cadastro de uma nova marca
            novoItem.Marca = Marca.Cadastrar();
            novoItem.CadastradoPor = new Usuario(); 
            
            ListaProdutos.Add(novoItem);
        }
        
        public void ListarItem()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Produtos Cadastrados");
            
            foreach (var item in ListaProdutos)
            {
                Console.WriteLine($"Codigo: {item.CodigoProduto}");
                Console.WriteLine($"Nome: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.PrecoProduto}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastroP}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.CadastradoPor.NomeUser}\n");                    
            }
            Console.ResetColor();
        }

        public void DeletarItem(int cod)
        {
            Produto prodDelete = ListaProdutos.Find(p => p.CodigoProduto == cod);
            ListaProdutos.Remove(prodDelete);
        }
        
        
    }
}