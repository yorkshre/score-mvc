//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SklepMuzyczny
{
    using System;
    using System.Collections.Generic;
    
    public partial class towar_zamowienie
    {
        public int idTowaru { get; set; }
        public int idZamowienia { get; set; }
        public int Ilosc { get; set; }
        public int Cena { get; set; }
    
        public virtual towar towar { get; set; }
        public virtual zamowienia zamowienia { get; set; }
    }
}
