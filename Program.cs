using System;

namespace ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ReajusteSalarial();
        }

        static void ReajusteSalarial()
        {
            // Ínicio variável
            string menu;
            var salario = 0.0;
            // Fim variável

            try
            {
                Console.Write("Digite o salário atual do Colaborador: ");
                salario = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ops, algo deu errado. Lembre-se de digitar somente números!! :)");
                ReajusteSalarial();
            }

            if (salario <= 1700)
            {
                salario = salario + 300;
                Console.WriteLine($"Novo salário do colaborador: {salario}");

            }
            else
            {
                salario = salario + 200;
                Console.WriteLine($"Novo salário do colaborador: {salario}");
            }

            Console.Write("Deseja fazer de outro colaborador? [Sim/S] | [Não/N]: ");
            menu = Console.ReadLine().ToLower().Substring(0, 1);

            switch (menu)
            {
                case "s":
                    Console.Clear();
                    ReajusteSalarial();
                    break;
                default:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            }

        }
    }
}
