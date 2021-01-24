using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5KodlamaIo
{
    class HalfPriceCampain : ICampainManager
    {
        public void AddCampain()
        {
            Console.WriteLine("Kampanya Eklendi.");
        }

        public void DeleteCampain()
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void UpdateCampain()
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
