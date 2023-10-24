using System.Security.Cryptography.X509Certificates;

namespace CaseNDLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            char coi;
            int h = 0;
            while (restart == true)
            {
                Console.WriteLine("Seleziona F per un ciclo For");
                Console.WriteLine("Seleziona W per un ciclo While");
                coi = Console.ReadKey().KeyChar;
                char.ToUpper(coi);
                switch (coi)
                {
                    case 'f':
                        Console.WriteLine();
                        Console.WriteLine("adesso useremo un ciclo for per stampare 10 numeri");
                        for (int i = 0; i <= 10; i++)
                        {
                            Console.Write(i + " ");
                        }
                            Console.WriteLine();
                            Console.WriteLine("________________________________________________________________");
                        break;
                    case 'w':
                        Console.WriteLine();
                        Console.WriteLine("adesso useremo un ciclo while per stampare 10 numeri");
                        do
                        {
                            Console.Write(h + " ");
                            h++;
                        }
                        while (h <= 10);
                        Console.WriteLine();
                        Console.WriteLine("________________________________________________________________");
                        break;
                    default:
                        Console.WriteLine("non è una scelta valida (-_-)");
                        break;
                } //fine switch
                Console.WriteLine("desideri continuare? se si premi s");
                Console.WriteLine();
                char rc = Convert.ToChar(Console.ReadKey().KeyChar);
                if (rc != 's')
                {
                    restart = false;
                }
            } // fine while

        }
    }
}