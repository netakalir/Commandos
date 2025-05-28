using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class AirCommando:CommandoSoldier
    {
        public AirCommando(string name , char codeName) :base(name, codeName)
        {

        }

        public void parachuting()
        {
            Console.WriteLine("parachuting went into action");
        }

        public override void Attack()
        {
            Console.WriteLine($"air commando {GetName()} solider attak");
        }
    }

        
    
    
}
