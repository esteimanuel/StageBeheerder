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
    
    public partial class education
    {
        public education()
        {
            this.students = new HashSet<students>();
            this.administrators = new HashSet<administrators>();
            this.teachers = new HashSet<teachers>();
        }
    
        public int id { get; set; }
        public int academic_id { get; set; }
        public string name { get; set; }
    
        public virtual academics academics { get; set; }
        public virtual ICollection<students> students { get; set; }
        public virtual ICollection<administrators> administrators { get; set; }
        public virtual ICollection<teachers> teachers { get; set; }
    }
}
