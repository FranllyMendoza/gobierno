using System;

namespace gobierno
{
    class Program
    {
        static void Main(string[] args)
        {
            int Partido, Politica;
            string terminar="";

            Random r = new Random();

            Partido = Convert.ToInt32(r.Next(0, 2));

            if (Convert.ToBoolean(Partido))
            {
                Console.WriteLine("Gobierno Conservador.");
            }
            else
            {
                Console.WriteLine("Gobierno Liberal.");
            }

            Politica = Convert.ToInt32(r.Next(0, 2));

            if (Convert.ToBoolean(Politica))
            {
                Console.WriteLine("Politica Permisiva.");
            }
            else
            {
                Console.WriteLine("Politica Coercitiva.");
            }

            if (Convert.ToBoolean(Politica))
            {
                Console.WriteLine("Contienda Civil Baja.");
            }
            else
            {
                Console.WriteLine("Contienda Civil Alta.");
            }

            terminar = Console.ReadLine();
           
        }
    }
}
