using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class CommandoSoldier
    {
        private string Name;
        private char CodeName { get; set; }
        private string[] Tools = new string[5] { "Hammer", "chisel", "rope", "bag", "water bottle" };
        private string Status;
        private Weapons Weapon;
        private Enemy enemy;

        public CommandoSoldier(string name, char codeName)
        {
            Name = name;
            CodeName = codeName;
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

        public virtual void Attack()
        {
            Console.WriteLine($"'{CodeName}' is attack now");
        }

        public void SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                Console.WriteLine(Name);
            }

            else if (commanderRank == "COLONEL")
            {
                Console.WriteLine(CodeName);
            }

            else
            {
                Console.WriteLine("Your classification level is not compatible with receiving the measure.");
            }

        }

        public string GetName()
        {
            return Name;
        }
        public void SetCodeName(char newCodeName)
        {
            CodeName = newCodeName;
        }
        public void GetCodeName()
        {
            Console.WriteLine(CodeName);
        }

        public Weapons GetWeapon()
        {
            return Weapon;
        }

        public void SetWeapon(Weapons weapon)
        {
            Weapon = weapon;
        }




    }
}
