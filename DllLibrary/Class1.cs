using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllLibrary
{
    // класс - здание
    public class Building
    {
        // квартиры данного здания
        public string Address { get; set; }
        public string Description { get; set; }
        public List<Apartment> Apartments = new List<Apartment>();
        public Building(string nm, string ad)
        {
            Address = nm;
            Description = ad;
        }
        public void Show()
        {
            Console.WriteLine($"Здание: адрес = {Address}, описание = {Description}");
        }
    }
    //  класс квартир
    public class Apartment
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public Apartment(string nm, string avt)
        {
            Number = nm;
            Owner = avt;
        }
        public void Show()
        {
            Console.WriteLine(
                 $"Квартира: номер = {Number}, владелец = {Owner}");
        }
    }
}
