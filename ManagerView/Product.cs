//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagerView
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string SellsPrice { get; set; }
        public string Unit { get; set; }
    
        public virtual Purchase Purchase { get; set; }
    }
}
