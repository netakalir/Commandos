
using System;
using System.Security.Cryptography;
using Commandos.Models;

namespace Commandos;


class Program
{
    static void Main(string[] args)
    {
        //CommandoFactory commandoFactory = new CommandoFactory();
        //commandoFactory.CreateInstance("airCommando", 3);
        //foreach (var sol in commandoFactory.airCommandos)
        //{
        //    sol.parachuting();
        //}

        //WeaponsFactory weaponsFactory = new WeaponsFactory();
        //weaponsFactory.CreateInstance("MK16", 3);
        //foreach (Weapons weapon in weaponsFactory.weapons)
        //{
        //    Console.WriteLine(weapon.Shoot());
        //}

        //EnemyFactory enemyFactory = new EnemyFactory();
        //enemyFactory.createInstance("Hamas", 3);
        //foreach(Enemy enemy in enemyFactory.enemyList)
        //{
        //    enemy.setStatus();
        //    Console.WriteLine($"{enemy.getName()} {enemy.getStatus()}");
        //}

        Game game = new Game();
        game.initGame();
    }

}