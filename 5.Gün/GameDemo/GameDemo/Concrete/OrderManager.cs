using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class OrderManager : IOrderService
    {
        public void CampaignOrder(Game game, Gamer gamer, Campaign campaign)
        {
            decimal indirimOranı = game.GamePrice - (game.GamePrice * campaign.DiscountRate);

            Console.WriteLine(" Sayın " + gamer.FirstName + " " + gamer.LastName + " " + campaign.CampaignName + " " + game.GameName + " : Oyununu  " + indirimOranı + " TL' ye Satın Aldınız");

        }

        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Satın Aldı : " + game.GameName + "  " + game.GamePrice + " TL ");
        }
    }
}