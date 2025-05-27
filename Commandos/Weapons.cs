using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Commandos.Models
{
    public class Weapons
    {
        private string Name;
        private string Manufacturer;
        private int NumberOfBalls;



    public Weapons(string name , string manuFacturer , int numberOfBoalls) 
        {
            Name = name;
            Manufacturer = manuFacturer;
            NumberOfBalls = numberOfBoalls;
        }


    public void Shoot()
        {
            Console.WriteLine("BOOOOMMMMM");
            NumberOfBalls--;
        }

    public void getNumOfBalls()
        {
            Console.WriteLine(NumberOfBalls);
        }

    }
}
