using System;

namespace DIO.Series
{
    class Program
    {
        static ProcessarFilme processarFilme = new ProcessarFilme();
        static ProcessarSerie processarSerie = new ProcessarSerie(); 

        static void Main(string[] args)
        {   
            string opcaoUsuarioCad = ObterOpcaoUsuario();

            while(opcaoUsuarioCad.ToUpper() != "X")
            {
                switch(opcaoUsuarioCad)
                {
                    case "1":
                        processarFilme.Listar();
                        break;
                    case "2":
                        processarFilme.Inserir();
                        break;
                    case "3":
                        processarFilme.Atualizar();
                        break;
                    case "4":
                        processarFilme.Excluir();
                        break;
                    case "5":
                        processarFilme.Visualizar();
                        break;
                    case "6":
                        processarSerie.Listar();
                        break;
                    case "7":
                        processarSerie.Inserir();
                        break;
                    case "8":
                        processarSerie.Atualizar();
                        break;
                    case "9":
                        processarSerie.Excluir();
                        break;
                    case "10":
                        processarSerie.Visualizar();
                        break;   
                    case "T":
                        processarFilme.Listar();
                        Console.WriteLine("===================");
                        processarSerie.Listar();
                        break; 
                    case "C":
                        Console.Clear();
                        break; 
                    default:
                        throw new ArgumentOutOfRangeException();                       
                    }    
                    opcaoUsuarioCad = ObterOpcaoUsuario(); 
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.WriteLine();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries e Filmes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar Filmes");
            Console.WriteLine("2- Cadastrar Filme");
            Console.WriteLine("3- Atualizar Filme");
            Console.WriteLine("4- Excluir Filme");
            Console.WriteLine("5- Visualizar Filme");
            Console.WriteLine("===================");
            Console.WriteLine("6- Listar Séries");
            Console.WriteLine("7- Cadastrar Série");
            Console.WriteLine("8- Atualizar Série");
            Console.WriteLine("9- Excluir Série");
            Console.WriteLine("10- Visualizar Série");
            Console.WriteLine("===================");
            Console.WriteLine("T- Ver lista completa");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}