using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class SeaCommando : CommandoSoldier
    {
        public SeaCommando(string name, char codeName) : base(name, codeName)
        {

        }

        public void Swimming ()
        {
            Console.WriteLine("Swimming went into action");
        }

        public override void Attack()
        {
            Console.WriteLine("sea commando solider attak");
        }
    }
    
}
