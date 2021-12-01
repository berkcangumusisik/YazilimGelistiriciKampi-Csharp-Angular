using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Concrete;
using GameDemo.Entities;

namespace GameDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer
            {
                ID = 1,
                DateOfBirth = new DateTime(1999, 04, 12),
                FirstName = " BERKCAN ",
                LastName = "  GÜMÜŞIŞIK ",
                UserName = " binbirgece ",
                NationalityId = 20123456788
            };

            Gamer gamer2 = new Gamer
            {
                ID = 2,
                DateOfBirth = new DateTime(2001, 04, 16),
                FirstName = " METE SERKAN ",
                LastName = " ÖZDEMİR ",
                UserName = " Coder ",
                NationalityId = 12345678902
            };


            gamerManager.Add(gamer1);

            Console.WriteLine("----------------------------");

            CampaignManager campaingManager = new CampaignManager();
            Campaign campaign = new Campaign { ID = 1, CampaignName = "  %60 İNDİRİMLİ ", DiscountRate = 0.60M };
            Campaign campaign2 = new Campaign { ID = 2, CampaignName = "  %80 İNDİRİMLİ ", DiscountRate = 0.80M };
            campaingManager.Add(campaign);

            Console.WriteLine("----------------------------");

            GameManager gameManager = new GameManager();
            Game game1 = new Game { ID = 1, GameName = "Counter Strike ", GamePrice = 200 };
            Game game2 = new Game { ID = 2, GameName = "GTA 5  ", GamePrice = 140 };

            gameManager.Add(game2);
            gameManager.Update(game1);

            Console.WriteLine("----------------------------");

            OrderManager orderManager = new OrderManager();

            orderManager.CampaignOrder(game1, gamer1, campaign);
            orderManager.Order(game2, gamer2);

        }
    }

}