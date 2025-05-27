
using System;
using Commandos.Models;

namespace Commandos;


class Program
{
    public static void Main(string[] args)
    {
        CommandoSoldier sol = new CommandoSoldier("neta", 'n');

        sol.walk();
        sol.Hide();
        sol.Attack();

        sol.SetCodeName('d');
        sol.GetCodeName();

        Weapons weapon = new Weapons("M16", "kolet", 100);
        weapon.Shoot();
        weapon.getNumOfBalls();

        SeaCommando seaCommando = new SeaCommando("gabi", 'g');
        seaCommando.Swimming();
        AirCommando airCommando = new AirCommando("yosi", 'y');
        airCommando.parachuting();

        CommandoSoldier[] soldirs = new CommandoSoldier[] {sol, seaCommando , airCommando } ;
        
        Console.WriteLine(soldirs.Length);
        Console.WriteLine(soldirs.GetType());

        foreach (CommandoSoldier soldier in soldirs)
        {
            soldier.Attack();
            Console.WriteLine(soldier.GetType());

        }



    }

}