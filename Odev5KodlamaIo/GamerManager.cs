using Odev5KodlamaIo;
using System;
using System.Collections.Generic;
using System.Text;

    class GamerManager
    {
        public void AddGamer(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + "Oyuncusu için kayıt oluşturulacak, E - devlet doğrulama başarılı..");
        }
        public void DeleteGamer(Gamer gamer)
        {
            
            Console.WriteLine(gamer.GamerID.ToString() + " " + gamer.GamerName + " " + gamer.GamerSurname + " " + "Oyuncu Silindi.");
        }

       public void TcKontrol(Gamer gamer)
        {

        Console.WriteLine("TC Kimlik no kontrolü yapıldı");

        }

    }
