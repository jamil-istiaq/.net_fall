//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment_Info
    {
        public int Payment_ID { get; set; }
        public int User_ID { get; set; }
        public int Tkt_ID { get; set; }
        public string Amount { get; set; }
        public string Phone { get; set; }
        public string Payment_Type { get; set; }
    
        public virtual User_Info User_Info { get; set; }
    }
}
