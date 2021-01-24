using Odev5KodlamaIo;
using System;
using System.Collections.Generic;
using System.Text;


interface IGameManager
{

    void AddGame(Game game);

    void DeleteGame(Game game);

    void SellGame(List<Game> games, List<Gamer> gamer, List<Campain> campains);
   
}

