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
    
    public partial class users
    {
        public users()
        {
            this.webkeys = new HashSet<webkeys>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
    
        public virtual administrators administrators { get; set; }
        public virtual supervisor supervisor { get; set; }
        public virtual teachers teachers { get; set; }
        public virtual ICollection<webkeys> webkeys { get; set; }
        public virtual students students { get; set; }
    }
}