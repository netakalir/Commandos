using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class CommandoSoldier
    {
        private string Name;
        private char KoodName;
        private List<string> Tools = new List<string> { "Hammer", "chisel", "rope", "bag", "water bottle" };
        private string Status;



        public CommandoSoldier(string name, char koodName, string status)
        {
            Name = name;
            KoodName = koodName;
            Status = status;
        }

        public void walk()
        {
            Console.WriteLine("Commando soldier walks");
            Status = "walk";
        }


        public void Hide()
        {
            Console.WriteLine("Commando soldier is hiding");
            Status = "hiding";
        }

        public void Attack()
        {
            Console.WriteLine($"'{KoodName}' is attack now");
        }

    }
}
