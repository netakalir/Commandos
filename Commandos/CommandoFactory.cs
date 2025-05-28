using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Commandos.Models;

namespace Commandos
{
    public class CommandoFactory
    {
        static Random random = new Random();
        public List<CommandoSoldier> CommandsSoldier = new List<CommandoSoldier>();
        public List<AirCommando> airCommandos = new List<AirCommando>();
        public List<SeaCommando> seaCommandos = new List<SeaCommando>();
        static List<string> NameSoldierList = new List<string> { "neta", "avi", "yosi" };
        static List<char> CodeNameSoldierList = new List<char> { 'n', 'a', 'y' };
        //static List<Weapons> weapons = new List<Weapons>();



        public void CreateInstance(string typeOfInstance, int amountInstance)
        {

            for (int i = 0; i < amountInstance; i++)
            {
                switch (typeOfInstance)
                {
                    case "airCommando":
                        airCommandos.Add(new AirCommando(NameSoldierList[random.Next(0, NameSoldierList.Count - 1)], CodeNameSoldierList[random.Next(0, CodeNameSoldierList.Count - 1)]));
                        break;
                    case "seaCommando":
                        seaCommandos.Add(new SeaCommando(NameSoldierList[random.Next(0, NameSoldierList.Count - 1)], CodeNameSoldierList[random.Next(0, CodeNameSoldierList.Count - 1)]));
                        break;
                    case "commandoSoldier":
                        CommandsSoldier.Add(new CommandoSoldier(NameSoldierList[random.Next(0, NameSoldierList.Count - 1)], CodeNameSoldierList[random.Next(0, CodeNameSoldierList.Count - 1)]));
                        break;
                }
            }
        }
    }
}
