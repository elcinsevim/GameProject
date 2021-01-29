using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " name game " + game.GamePrice + "added to the system with price ");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " game deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " game updated");
        }
    }
}
