using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5KodlamaIo
{
    class Campain
    {
        public Campain()
        {
            //Constructor.

        }
        public int CampainID { get; set; }
        public string CampainName { get; set; }
        public double CampainDiscountRate { get; set; }
    }
    //Salak gibi sınıfın içinde değil de namespace içinde methodları yazarsam tabi kızar bana.
}
