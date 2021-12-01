using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "  : Oyunu Eklendi. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "  : Oyunu Güncellendi. ");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "  : Oyunu Silindi. ");
        }
    }
}
