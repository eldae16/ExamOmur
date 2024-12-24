using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllLibrary;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building ps = new Building("Троицкая 11", "дом");
            ps.Show();

            Apartment b1 = new Apartment("24", "Омуралиев");
            ps.Apartments.Add(b1);

            Apartment b2 = new Apartment("16", "Арутюнян");
            ps.Apartments.Add(b2);

            foreach (Apartment b in ps.Apartments)
            {
                b.Show();
            }

            Console.ReadKey();
        }
    }
}
