using System;
using System.Collections.Generic;
using System.Text;

namespace ZakladInterface.Tridy
{
    internal interface IOvladatelne
    {
        bool JeZapnuto { get; } 
        void Zapni();             
        void Vypni();
    }
}
