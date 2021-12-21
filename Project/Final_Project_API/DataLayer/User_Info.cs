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
    
    public partial class User_Info
    {
        public User_Info()
        {
            this.EM_Info = new HashSet<EM_Info>();
            this.Payment_Info = new HashSet<Payment_Info>();
            this.Pending_Tickets = new HashSet<Pending_Tickets>();
            this.Salary_Info = new HashSet<Salary_Info>();
            this.Tokens = new HashSet<Token>();
            this.Purchase_Tickets = new HashSet<Purchase_Tickets>();
        }
    
        public int User_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string NID { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
    
        public virtual ICollection<EM_Info> EM_Info { get; set; }
        public virtual ICollection<Payment_Info> Payment_Info { get; set; }
        public virtual ICollection<Pending_Tickets> Pending_Tickets { get; set; }
        public virtual ICollection<Salary_Info> Salary_Info { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual Token_Info Token_Info { get; set; }
        public virtual ICollection<Purchase_Tickets> Purchase_Tickets { get; set; }
    }
}