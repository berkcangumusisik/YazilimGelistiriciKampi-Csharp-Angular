using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Adapter;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GamerCheckManager:IGamerCheckService
    {
        IGamerCheckService _gamerCheckService;
        public bool Check(Gamer gamer)
        {
            _gamerCheckService = new MernisCheckService();

            return _gamerCheckService.Check(gamer);
        }
    }
}
