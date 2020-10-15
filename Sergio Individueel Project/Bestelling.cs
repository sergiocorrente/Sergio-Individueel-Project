//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sergio_Individueel_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bestelling
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bestelling()
        {
            this.BestellingProducts = new HashSet<BestellingProduct>();
        }
    
        public int BestellingID { get; set; }
        public System.DateTime DatumOpgemaakt { get; set; }
        public int PersoneelslidID { get; set; }
        public int LeverancierID { get; set; }
        public int KlantID { get; set; }
    
        public virtual Klant Klant { get; set; }
        public virtual Leverancier Leverancier { get; set; }
        public virtual PersoneelsID PersoneelsID { get; set; }
        public virtual BestellingProduct BestellingProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BestellingProduct> BestellingProducts { get; set; }
    }
}
