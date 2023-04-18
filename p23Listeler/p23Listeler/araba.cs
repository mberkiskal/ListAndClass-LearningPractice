using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p23Listeler
{
    internal class araba
    {
        string marka;
        string model;
        string ulke;

        public string markasi
        {
            get { return marka; } set {  marka = value; }
        }
        public string modeli
        {
            get { return model; } set { model = value; }
        }

        public string ulkesi
        {
            get { return ulke; } set { ulke = value;}
        }
    }
}
