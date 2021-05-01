using System;

namespace SampleConsoleAppThread
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Iniciando...");
                AreaCompartilhada.Valor = 0;
                ThreadSoma soma = new ThreadSoma();
                ThreadSubtrai subtrai = new ThreadSubtrai();
                soma.Inicializa();
                subtrai.Inicializa();
                soma.AguardaEncerrar();
                subtrai.AguardaEncerrar();
                Console.WriteLine($"Área compartilhada: {AreaCompartilhada.Valor}");
            }
            Console.ReadKey();
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");
            ThreadBackground thread = new ThreadBackground();
            thread.Inicializa();
            ThreadBackground thread1 = new ThreadBackground();
            thread1.Inicializa();
            Console.WriteLine("Pressione para encerrar...");
            Console.ReadKey();
        }
    }
}
