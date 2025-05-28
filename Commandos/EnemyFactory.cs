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
        static Random random = new Random();
        public List<Enemy> enemyList = new List<Enemy>();
        //static List<string> nameOrgistionList = new List<string> { "Hamas","Hizzblla","Airan" };
        static List<string> nameTerroristList = new List<string> { "Mahmod", "Df", "Yosof" };



        public void createInstance(string typeOfInstance, int amountInstance)
        {
            for (int i = 0; i < amountInstance; i++)
            {
                switch (typeOfInstance)
                {
                    case "Hamas":
                        enemyList.Add(new Enemy("Hamas", nameTerroristList[random.Next(0, nameTerroristList.Count - 1)], 100));
                        break;
                    case "Hizzblla":
                        enemyList.Add(new Enemy("Hizzblla", nameTerroristList[random.Next(0, nameTerroristList.Count - 1)], 100));
                        break;
                    case "Airan":
                        enemyList.Add(new Enemy("Airan", nameTerroristList[random.Next(0, nameTerroristList.Count - 1)], 100));
                        break;

                }
            }
        }

        public List<Enemy> GetEnemyList()
        {
            return enemyList;
        }




    }
}
