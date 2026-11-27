using System;
using System.Collections.Generic;
using System.Text;

namespace ZakladInterface.Tridy
{
    public class Projektor : IOvladatelne
    {
        public bool JeZapnuto { get; set; }

        public void Zapni()
        {
            JeZapnuto = true;
        }

        public void Vypni()
        {
            JeZapnuto = false;
        }
    }
}
