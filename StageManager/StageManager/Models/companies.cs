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
    
    public partial class companies
    {
        public companies()
        {
            this.supervisor = new HashSet<supervisor>();
        }
    
        public int id { get; set; }
        public int address_id { get; set; }
        public string name { get; set; }
        public string phonenumber { get; set; }
        public string website { get; set; }
    
        public virtual adresses adresses { get; set; }
        public virtual ICollection<supervisor> supervisor { get; set; }
    }
}