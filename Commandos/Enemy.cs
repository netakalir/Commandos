using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class Enemy
    {
        private string Name;
        private int Life;
        private string StatusLife;
        string NameOrgistion;


        public Enemy(string nameOrgistion, string name, int life = 100)
        {
            NameOrgistion = nameOrgistion;
            Name = name;
            Life = life;
            StatusLife = "live";
        }

        public string Scream()
        {
            return "Im ememy!!!";
        }

        public string getName()
        {
            return Name;
        }
        public void setStatus()
        {
            if (Life <= 0)
            {
                StatusLife = "dead";
                Console.WriteLine("The terrorist is dead.!");


            }
        }

        public string getStatus()
        {
            return StatusLife;
        }


        public int getLife()
        {
            return Life;
        }

        public void setLife()
        {
            
            Life--;
            Console.WriteLine("Heeeeeeeeeee i was hurt!");
            setStatus();
        }




    }
}