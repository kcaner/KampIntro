using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{

    //public = ürün bildirgeci 
    class Urun
    {

        //Property - Bunların hepsi bir ürün bunlar da özellikleri
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }



    }
}
