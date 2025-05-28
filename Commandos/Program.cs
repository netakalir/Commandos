
using System;
using System.Security.Cryptography;
using Commandos.Models;

namespace Commandos;


class Program
{
    static void Main(string[] args)
    {
        //CommandoSoldier sol = new CommandoSoldier("neta", 'n');

        //sol.walk();
        //sol.Hide();
        //sol.Attack();

        //sol.SetCodeName('d');
        //sol.GetCodeName();

        //Weapons weapon = new Weapons("M16", "kolet", 100);
        //weapon.Shoot();
        //weapon.getNumOfBalls();

        //SeaCommando seaCommando = new SeaCommando("gabi", 'g');
        //seaCommando.Swimming();
        //AirCommando airCommando = new AirCommando("yosi", 'y');
        //airCommando.parachuting();

        //CommandoSoldier[] soldirs = new CommandoSoldier[] {sol, seaCommando , airCommando } ;

        //Console.WriteLine(soldirs.Length);
        //Console.WriteLine(soldirs.GetType());

        //foreach (CommandoSoldier soldier in soldirs)
        //{
        //    soldier.Attack();
        //}

        CommandoFactory commandoFactory = new CommandoFactory();
        commandoFactory.CreateInstance("airCommando", 3);
        foreach (var sol in commandoFactory.airCommandos)
        {
            sol.parachuting();
        }

        WeaponsFactory weaponsFactory = new WeaponsFactory();
        weaponsFactory.CreateInstance("MK16", 3);
        foreach (Weapons weapon in weaponsFactory.weapons)
        {
            Console.WriteLine(weapon.Shoot());
        }

        EnemyFactory enemyFactory = new EnemyFactory();
        enemyFactory.createInstance("Hamas", 3);
        foreach(Enemy enemy in enemyFactory.enemyList)
        {
            enemy.setStatus();
            Console.WriteLine($"{enemy.getName()} {enemy.getStatus()}");
        }
    }

}