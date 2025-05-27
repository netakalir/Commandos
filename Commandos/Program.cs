
using System;

namespace Commandos;


class Program
{
    public static void Main(string[] args)
    {
        CommandoSoldier sol = new CommandoSoldier("neta", 'n', "");
        
        sol.walk();
        sol.Hide();
        sol.Attack();

        //sol.SetCodeName('d');
        //sol.GetCodeName();

        Weapons weapon = new Weapons("M16", "kolet", 100);
        weapon.Shoot();
        weapon.getNumOfBalls();

    }
}