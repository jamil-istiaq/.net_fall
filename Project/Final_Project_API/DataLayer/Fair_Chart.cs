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
    
    public partial class Fair_Chart
    {
        public int Fair_ID { get; set; }
        public int Route_ID { get; set; }
        public string Station_Name { get; set; }
        public string Cost { get; set; }
    
        public virtual Route_List Route_List { get; set; }
    }
}
