//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kuvari
    {
        public int Id_kuvara { get; set; }
        public string ime { get; set; }
        public string slika { get; set; }
        public string slika_mala { get; set; }
        public int id_pozicija { get; set; }
    
        public virtual Pozicije Pozicije { get; set; }
    }
}
