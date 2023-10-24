using ExemploPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace produto
{
    internal class Login
    {
        public static string Usuario { get; set; }
        public static string Password { get; set; }

        public static void Logar()
        {
            Console.WriteLine("Digite o usuario: ");
            Usuario = Console.ReadLine();

            Console.WriteLine("Digite a senha: ");
            Password = Console.ReadLine();

            if (Usuario == "gustavo" +
                "" && Password == "123")
            {
                Menu.MostrarMenuPrincipal();
            }
            else
            {
                Console.WriteLine("Login Inválido");
                Logar();
            }
        }
    }
}
