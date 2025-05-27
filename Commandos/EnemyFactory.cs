using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Models;

namespace Commandos
{
    public class EnemyFactory
    {
        public List<Enemy> enemyList = new List<Enemy>();


        public void createInstance(int amountInstance, Enemy typeOfInstance)
        {
            for (int i = 1; i <= amountInstance; i++)
            {
                enemyList.Add(typeOfInstance);
            }
        }
    }
}
