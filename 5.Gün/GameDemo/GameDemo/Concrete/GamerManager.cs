using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckManager;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckManager = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true)
            {
                Console.WriteLine(" Kayıt Başarılı ");
                Console.WriteLine(gamer.UserName + "   : Oyuncusu Eklendi ");
            }
            else
            {
                Console.WriteLine(" Lütfen Kendi Bilgilerinle Gelmeyi Dene ! Yoksa Aramıza Almayız... ");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + "   : Oyuncusu Silindi ");
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true)
            {
                Console.WriteLine(" BAŞARILI");
                Console.WriteLine(gamer.UserName + "   : Oyuncusu Güncellendi  ");
            }
            else
            {
                Console.WriteLine(" Güncelleme Başarısız Oldu. Gerçek Bilgilerini Gir.  ");
            }
        }
    }
}