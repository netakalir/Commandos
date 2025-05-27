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


        public Enemy(string name, string statusLife ,int life = 100) 
        {
            Name = name;    
            Life = life;
            StatusLife = statusLife;
        }

        public void Scream()
        {
            Console.WriteLine("Im ememy!!!");
        }



    }
}