using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Car2
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }

        
        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Color: {Color}, MaxSpeed: {MaxSpeed} km/h");
        }

       
        public void Drive()
        {
            Console.WriteLine($"{Brand} is starting...");
        }
    }
}

