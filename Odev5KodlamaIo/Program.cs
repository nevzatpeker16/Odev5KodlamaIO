using System;
using System.Collections.Generic;

namespace Odev5KodlamaIo
{
    class Program
    {
        static void Main(string[] args)
        {
            Campain halfPriceCampain = new Campain() { };
            GamerManager gamerManager = new GamerManager() { };
            ComputerGameManager computerGameManager = new ComputerGameManager() { };
            Game oyun = new Game() { };
            Gamer oyuncu = new Gamer() { };
            oyuncu.GamerID = 1;
            oyuncu.GamerIdentityNumber = "30277256554";
            oyuncu.GamerName = "Nevzat";
            oyuncu.GamerSurname = "Peker";
            oyuncu.GamerTelNumber = "53508590";
            oyun.GameName = "GTA5 ";
            oyun.GameID = 1;

            computerGameManager.AddGame(oyun);
            gamerManager.TcKontrol(oyuncu);
            List<Game> games = new List<Game>() {oyun };
            List<Gamer> gamers = new List<Gamer>() {oyuncu};
            List<Campain> campains = new List<Campain>() { halfPriceCampain};

            computerGameManager.SellGame(games, gamers, campains);



        }
    }
}
