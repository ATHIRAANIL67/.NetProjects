//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDemoDBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOCATION
    {
        public int location_id { get; set; }
        public string street_address { get; set; }
        public Nullable<int> postal_code { get; set; }
        public string city { get; set; }
        public string state_province { get; set; }
        public Nullable<int> country_id { get; set; }
    
        public virtual COUNTRy COUNTRy { get; set; }
    }
}
