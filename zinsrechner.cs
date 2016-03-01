using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte einmalige Höhe der Einzahlung eingeben: ");
            double einzahlung = Convert.ToDouble(Console.ReadLine());

            double neueinzahlung = einzahlung;
            Console.WriteLine("Bitte Höhe der Jährlichen Zinsen eingeben: ");
            double zins = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte Laufzeit der Einzahlung in Jahren eingeben: ");
            int laufzeit = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i <= laufzeit)
            {
                neueinzahlung = (1 + zins / 100) * neueinzahlung;
                Console.WriteLine("Im Alter von " + i + " beträgt  der Kontostand + Zinsen " + neueinzahlung);
                i++;
            }
            Console.ReadKey();
        }
    }
}
