//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoGameStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Credit_Card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Credit_Card()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int credit_card_id { get; set; }
        public int user_id { get; set; }
        public long card_number { get; set; }
        public System.DateTime expiry_date { get; set; }
        public bool is_expired { get; set; }
        public bool is_flagged { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}