using System;

namespace amg204
{
    class Program
    {
        static void Main()
        {
            // Datele de intrare
            string car = "AMG_w204_c63";
            int HP = 430;
            double acceleratie = 4.1;
            int stage2 = 60;
            int totalPutere = HP + stage2;

            // Afisarea in consola
            Console.WriteLine("========================================");
            Console.WriteLine(" Curent car: " + car);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(car + " stock:   " + HP + " HP");
            Console.WriteLine(car + " 0-100:   " + acceleratie + " sec");
            Console.WriteLine(car + " stage 2: " + totalPutere + " HP");
            Console.WriteLine("========================================");
            
            // Aceasta linie tine consola deschisa pe PC ca sa apuci sa citesti
            Console.WriteLine("\nApasa orice tasta pentru a inchide...");
            Console.ReadKey();
        }
    }
}
