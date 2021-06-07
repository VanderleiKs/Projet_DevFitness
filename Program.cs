using System;
using System.Collections.Generic;

namespace DevFitness
{
    public class Program
    {
        static List<Usuario> usuarios = new();
        static List<Refeicao> refeicaos = new();
        static void Main(string[] args)
        {
            
            ExibirOpcoes();


            Console.Read();
        }

        public static void ExibirOpcoes()
        {
            Menu:
            Console.WriteLine("--- Seja Berm vindo ao DevFitness ---");
            Console.WriteLine("1- Cadastrar novo usuário.");
            //Console.WriteLine("2- Exibir detalhes do usuário.");
            Console.WriteLine("2- Cadastrar novas refeições.");
            Console.WriteLine("3- Listar todas refeições.");
            Console.WriteLine("0- Finalizar programa.");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastroUsuario();
                    break;
                case "2":
                    CadastroRefeicao();
                    break;
                case "3":
                    ListarRefeicao();
                    break;
                case "0":
                    EncerrarPrograma();
                    break;
                default:
                    Console.WriteLine("Opção inválida, digite outra opção.");
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
            }
        }

        public static void EncerrarPrograma()
        {

        }

        public static void CadastroRefeicao()
        {
            Refeicao refeicao = new();
            Console.Write("Digite a descrição: ");
            refeicao.Descricao = Console.ReadLine();

            Console.Write("Digite as Calorias: ");
            var calorias = Console.ReadLine();

            if(int.TryParse(calorias, out int caloriasInt))
            {
                refeicao.Calorias = caloriasInt;
                refeicaos.Add(refeicao);
                Console.WriteLine("Refeição adicionada com sucesso!");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoes();
            }
            else
            {
                Console.WriteLine("Opção inválida, digite uma opção válida.");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoes();
            }
        }
    
        public static  void ListarRefeicao()
        {
            foreach(Refeicao refeicao in refeicaos)
            {
                refeicao.ImprimirRefeicoes();
            }
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoes();
        }

        public static void CadastroUsuario()
        {
            Usuario newUser = new Usuario();
            Console.Write("Digite seu nome: ");
            newUser.nome = Console.ReadLine();

            Console.Write("Digite sua altura: ");
            newUser.altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            newUser.peso = double.Parse(Console.ReadLine());

            usuarios.Add(newUser);
        }
    }
}
