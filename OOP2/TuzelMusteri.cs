using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //corporate
    //Miras - inheritance Tüzel Müşteri de bir müşteridir
    //müşteride olan özellikler tüzel müşteride de vardır
    //
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
