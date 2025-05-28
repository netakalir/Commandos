using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Models;

namespace Commandos
{
    public class WeaponsFactory
    {
        static Random random = new Random();
        public List<Weapons> weapons = new List<Weapons>();
        static List<string> weaponsList = new List<string> { "MK16", "AR7", "KALACH" };
        static List<string> facturerweaponsList = new List<string> { "KOLET", "ALBIT", "RFAEL" };
        static List<int> numberOfBalls = new List<int> { 100,200,300 };



        public void CreateInstance(string typeOfInstance, int amountInstance)
        {
            for (int i = 0; i < amountInstance; i++)
            {
                switch (typeOfInstance)
                {
                    case "MK16":
                        weapons.Add(new Weapons(weaponsList[random.Next(0, weaponsList.Count - 1)], facturerweaponsList[random.Next(0,facturerweaponsList.Count-1)], numberOfBalls[random.Next(0, numberOfBalls.Count-1)]));
                        break;
                    case "AR7":
                        weapons.Add(new Weapons(weaponsList[random.Next(0, weaponsList.Count - 1)], facturerweaponsList[random.Next(0,facturerweaponsList.Count-1)], numberOfBalls[random.Next(0, numberOfBalls.Count-1)]));
                        break;
                    case "KALACH":
                        weapons.Add(new Weapons(weaponsList[random.Next(0, weaponsList.Count - 1)], facturerweaponsList[random.Next(0,facturerweaponsList.Count-1)], numberOfBalls[random.Next(0, numberOfBalls.Count-1)]));
                        break;
                    
                }
            }
        }
    }
}
