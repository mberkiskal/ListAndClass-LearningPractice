using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p23Listeler
{
    internal class kisiler
    {
        string ad;
        string soyad;
        string meslek;

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Meslek
        { 
            get { return meslek; }
            set { meslek = value; } 
        }
    }
}
