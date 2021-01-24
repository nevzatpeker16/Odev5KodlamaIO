using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5KodlamaIo
{
    class ComputerGameManager : IGameManager
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Oyun Eklendi");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Oyun Silindi...");
        }

        public void SellGame(List<Game> games,List<Gamer> gamers,List<Campain> campains)
        {
            foreach(var gamer in gamers)
            {

                foreach(var game in games)
                {

                    foreach(var campain in campains)
                    {

                        Console.WriteLine(gamer.GamerID + "Id'li" + gamer.GamerName + "İsimli " + gamer.GamerSurname + " Soyadlı " + game.GameID + " Id'li " + game.GameName + " Adlı Oyunu " +game.GamePrice * campain.CampainDiscountRate + " Fiyatına oyun satın aldı..."  );
                    }
                }


            }
            Console.WriteLine("Oyun Satıldı..");
        }
    }
}
