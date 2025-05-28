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
        private List<Weapons> weaponsList = new List<Weapons>();
        static List<string> facturerweaponsList = new List<string> { "KOLET", "ALBIT", "RFAEL" };
        static List<int> numberOfBalls = new List<int> { 100, 200, 300 };



        public void CreateInstance(string typeOfInstance, int amountInstance)
        {
            for (int i = 0; i < amountInstance; i++)
            {
                switch (typeOfInstance)
                {
                    case "MK16":
                        weaponsList.Add(new Weapons("MK16", facturerweaponsList[random.Next(0, facturerweaponsList.Count - 1)], numberOfBalls[random.Next(0, numberOfBalls.Count - 1)]));
                        break;
                    case "AR7":
                        weaponsList.Add(new Weapons("AR7", facturerweaponsList[random.Next(0, facturerweaponsList.Count - 1)], numberOfBalls[random.Next(0, numberOfBalls.Count - 1)]));
                        break;
                    case "KALACH":
                        weaponsList.Add(new Weapons("KALACH", facturerweaponsList[random.Next(0, facturerweaponsList.Count - 1)], numberOfBalls[random.Next(0, numberOfBalls.Count - 1)]));
                        break;

                }
            }
        }

        public List<Weapons> GetWeapons()
        {
            return weaponsList;
        }
    }
}
