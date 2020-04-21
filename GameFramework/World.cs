using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GameFramework.Abstracts;
using GameFramework.Characters;
using GameFramework.Enum;
using GameFramework.Factories;
using GameFramework.Interfaces;

namespace GameFramework
{
    public class World : AWorld
    {
        public Player Play { get; set; }
       public Random randomNumber = new Random();
        int numberOfEntities = 6;
        int numberOfAttackGears = 3;
        int numberOfDefenseGears = 3;
        int numberOfPotions = 2;
        public World(int sizeX, int sizeY)
        {
            SizeX = sizeX;
            SizeY = sizeY;
            Entities = new List<AEntity>();
            AttackGears = new List<AGear>();
            DefenseGears = new List<AGear>();
            Potions = new List<AGear>();
            Parallel.Invoke((() => new Thread(playerMovementHandler).Start()));
            
           
        }

        public void GenerateMap()
        {
            for (int i = 0; i < SizeX; i++)
            {
                for (int y = 0; y < SizeY; y++)
                {
                    PrintOjbects();
                    PrintAttackGear();
                    PrintDefenseGear();
                    PrintPotions();
                }
            }
        }

        private void PrintAttackGear()
        {
            while (AttackGears.Count < numberOfAttackGears)
            {

                AttackGears.Add(AttackWeaponFactory.MakeAttackWeapon(15, 0, true, 3, TypeOfWeapons.Axe )); continue;
            }
        }
        private void PrintPotions()
        {
            while (AttackGears.Count < numberOfAttackGears)
            {
           
                Potions.Add(PotionFactory.MakePotion(5)); continue;
            }
        }
        private void PrintDefenseGear()
        {
            while (AttackGears.Count < numberOfAttackGears)
            {
              
                DefenseGears.Add(DefenseWeaponFactory.MakeDefenseWeapon(15, 0, true, 2, TypeOfDefense.Helmet)); continue;
            }
        }
        public void PrintOjbects()
        {
            while (Entities.Count < numberOfEntities)
            {
                var randX = randomNumber.Next(1, SizeX);
                var randY = randomNumber.Next(1, SizeY); 
                Entities.Add(EntityFactory.MakeEntity(1, 1, randX, randY, EnemyType.Devil)); continue;
            }
        }

   

        public void playerMovementHandler()
        {

            while (true)
            {
                ConsoleKeyInfo keyboardInput = Console.ReadKey();


                if (keyboardInput.Key == ConsoleKey.W)
                {
                    Play.PlayerMovements( Direction.Up);
                }

                if (keyboardInput.Key == ConsoleKey.A)
                {
                    Play.PlayerMovements( Direction.Left);
                }
                if (keyboardInput.Key == ConsoleKey.S)
                {
                    Play.PlayerMovements( Direction.Down);
                }
                if (keyboardInput.Key == ConsoleKey.D)
                {
                    Play.PlayerMovements( Direction.Right);
                }
               

            }

        }
    }
}
