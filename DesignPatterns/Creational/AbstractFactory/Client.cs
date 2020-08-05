using MyNotes.DesignPatterns.Creational.AbstractFactory.Classes;
using MyNotes.DesignPatterns.Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.DesignPatterns.Creational.AbstractFactory
{
    public class Client
    {
        private IPlayer _player;
        private IEnemy _enemy;

        public Client()
        {
            Console.WriteLine("_-_Abstract Method _-_");
            Console.WriteLine(" Press 1 to create Zombie Game");
            Console.WriteLine(" Press 2 to create RPG Game");
            Console.WriteLine(" Press 3 to create Robot Game");
            Console.WriteLine(" Press 4 to End");

            string command = string.Empty;

            while (true)
            {
                _player = null;
                _enemy = null;

                command = Console.ReadLine();

                switch (command)
                {

                    case "1":
                        ZombieGame();
                        break;
                    case "2":
                        RpgGame();
                        break;
                    case "3":
                        RobotGame();
                        break;
                }

                if (_enemy != null)
                    _enemy.GetTypeOfEnemy();

                if (_player != null)
                    _player.GetTypeOfPlayer();

                if (command == "4")
                    break;
            }
        }

        public void ZombieGame()
        {
            _player = new ZombieGameAbstractFactory().CreatePlayer();
            _enemy = new ZombieGameAbstractFactory().CreateEnemy();
        }

        public void RpgGame()
        {
            _player = new RpgGameAbstractFactory().CreatePlayer();
            _enemy = new RpgGameAbstractFactory().CreateEnemy();
        }

        public void RobotGame()
        {
            _player = new RobotGameAbstractFactory().CreatePlayer();
            _enemy = new RobotGameAbstractFactory().CreateEnemy();
        }
    }
}
