using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commandos.Models;

namespace Commandos
{
    static class CommandoFactory
    {
        static Random Random = new Random();
        static string Name;
        static char CodeName;
        static List<string> NameSoldierList = new List<string> {"neta", "avi" , "yosi"};
        static List<char> CodeNameSoldierList = new List<char> {'n', 'a' , 'y'};

        //public CommandoFactory(string name, char codeName)
        //{
        //    Name = name;
        //    CodeName = codeName;
        //}

        static List <CommandoSoldier> CreateInstance(string typeOfInstance , int amountInstance)
        {
            List<CommandoSoldier> Commands = new List<CommandoSoldier>();
            for (int i = 0; i < amountInstance; i++)
            {
               
                switch (typeOfInstance)
                {
                    case "airCommando":
                        Commands.Add(new AirCommando(NameSoldierList[Random.Next(0, NameSoldierList.Count-1)], CodeNameSoldierList[random.Next(0, CodeNameSoldierList.Count - 1)]));
                        return Commands;
                    case "seaCommando":
                        Commands.Add(new SeaCommando(NameSoldierList[Random.Next(0, NameSoldierList.Count - 1)], CodeNameSoldierList[random.Next(0, CodeNameSoldierList.Count - 1)]));
                        return Commands; 
                    case "commandoSoldier":
                        Commands.Add(new CommandoSoldier(NameSoldierList[Random.Next(0, NameSoldierList.Count - 1)], CodeNameSoldierList[random.Next(0, CodeNameSoldierList.Count - 1)]));
                        return Commands; 
                }
            }
            return Commands;
                
        }
    }

}
