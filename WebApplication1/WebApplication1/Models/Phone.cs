//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phone
    {
        public int Id { get; set; }
        public string Phone1 { get; set; }
        public int Emp__Id { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
