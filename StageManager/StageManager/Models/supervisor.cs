//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StageManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class supervisor
    {
        public supervisor()
        {
            this.internships = new HashSet<internships>();
        }
    
        public int user_id { get; set; }
        public int company_id { get; set; }
        public string education { get; set; }
        public string function { get; set; }
        public int minimal_time { get; set; }
    
        public virtual companies companies { get; set; }
        public virtual ICollection<internships> internships { get; set; }
        public virtual users users { get; set; }
    }
}