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
    
    public partial class Pozicije
    {
        public Pozicije()
        {
            this.Kuvaris = new HashSet<Kuvari>();
        }
    
        public int Id_pozicija { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<Kuvari> Kuvaris { get; set; }
    }
}