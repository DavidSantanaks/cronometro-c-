using System.Threading;

namespace Stopwatch
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GOOOOOOO...");
            Thread.Sleep(2500);
            //O paramentro informado no PreStart é jogando dentro de start
            Start(time);
        }


        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                //Cria um intervalo de tempo a por MS
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado, retornando para o menu");
            //Intervalo para voltar pro menu em MS
            Thread.Sleep(2500);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quando tempo deseja contar?");
            string data = Console.ReadLine().ToLower();
            //Coletanto a letra do tempo informado
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            //Coletando o tempo informado
            int time = int.Parse(data.Substring(0, data.Length - 1));

            //calculando o tempo

            int multplier = 1;
            if (type == 'm')
                multplier = 60;
            if (time == 0)
                System.Environment.Exit(0);
            //O valor do tempo é multiplicado 
            //e é enviado diretamente como um valor de int
            //que passa este time para a chamado do Start()
            PreStart(time * multplier);
        }
    }
}