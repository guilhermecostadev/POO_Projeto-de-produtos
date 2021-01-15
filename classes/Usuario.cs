using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos_.classes
{
    public class Usuario
    {
        int CodigoUser { get; set; }
        public string NomeUser { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        DateTime DataCadastroUser { get; set; }

        public Usuario()
        {
            UsuarioPadrao();
        }
        public Usuario (int _codUser, string _nomeUser, string _email, string _senha)
        {
            CodigoUser       = _codUser;
            NomeUser         = _nomeUser;
            Email            = _email;
            Senha            = _senha;
            DataCadastroUser = DateTime.UtcNow;
        }
        
        // public void CadastrarUser()
        // {            
        //     Console.WriteLine("Digite seu nome completo: ");
        //     NomeUser = Console.ReadLine();
            
        //     Console.WriteLine("Digite seu e-mail:");
        //     Email = Console.ReadLine();
            
        //     Console.WriteLine("Digite uma senha:");
        //     Senha = Console.ReadLine();

        //     DataCadastroUser = DateTime.UtcNow;                 
        // }

        public void UsuarioPadrao()
        {
            NomeUser = "Admin";
            Email = "admin@admin.com";
            Senha = "123456";
            DataCadastroUser = DateTime.UtcNow;
        }

        public void DeletarUser()
        {   
            NomeUser         = "";
            Email            = "";
            Senha            = "";
            DataCadastroUser = DateTime.Parse("0000-00-00t00:00:00");
            //Formato DateTime: AAAA-MM-DDTHH:MM-SS            
        }

    }
}