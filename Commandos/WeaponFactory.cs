using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Models;

namespace Commandos
{
    public class WeaponFactory
    {
        public List<Weapons> WeaponsList = new List<Weapons>();


        public void createInstance(int amountInstance, Weapons typeOfInstance)
        {
            for (int i = 1; i <= amountInstance; i++)
            {
                WeaponsList.Add(typeOfInstance);
            }
        }
    }
}
