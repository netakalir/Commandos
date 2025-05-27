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
        private char CodeName;
        private List<string> Tools = new List<string> { "Hammer", "chisel", "rope", "bag", "water bottle" };
        private string Status;



        public CommandoSoldier(string name, char codeName, string status)
        {
            Name = name;
            CodeName = codeName;
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
            Console.WriteLine($"'{CodeName}' is attack now");
        }

    }
}
