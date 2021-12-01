using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    interface IOrderService
    {
        void Order(Game game, Gamer gamer);

        void CampaignOrder(Game game, Gamer gamer, Campaign campaign);
    }
}
