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
    
    public partial class Line_Item
    {
        public int line_item_id { get; set; }
        public int invoice_id { get; set; }
        public int game_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
