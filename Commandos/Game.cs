using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class Game
    {
        public WeaponsFactory weaponsFactory = new WeaponsFactory();
        public EnemyFactory enemyFactory = new EnemyFactory();

        public List<AirCommando> createSolieir()
        {
            CommandoFactory commandoFactory = new CommandoFactory();
            commandoFactory.CreateInstance("airCommando", 3);
            return commandoFactory.airCommandos;
        }

        public WeaponsFactory createWeapons()
        {
            weaponsFactory.CreateInstance("M16", 3);
            return weaponsFactory;
        }

        public List<Enemy> createEnemy()
        {
            EnemyFactory enemyFactory = new EnemyFactory();
            enemyFactory.createInstance("Hamas", 3);
            return enemyFactory.GetEnemyList();
        }

        public void initGame()
        {
            List<AirCommando> Commandos = createSolieir();
            List<Weapons> Weapons = weaponsFactory.GetWeapons();
            List<Enemy> Enemys = createEnemy();
            if (Commandos.Count == Weapons.Count)
            {
                for (int i = 0; i < Commandos.Count; i++)
                {
                    Commandos[i].SetWeapon(Weapons[i]);
                }
            }

            for (int i = 0; i < Enemys.Count; i++)
            {
                Commandos[i].Attack();
                while (Enemys[i].getStatus() == "live")
                {
                    Enemys[i].setLife();
                }

            }

        }

    }
}

