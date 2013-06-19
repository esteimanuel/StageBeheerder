//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StageBeheerder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class internships
    {
        public internships()
        {
            this.students_internships = new HashSet<students_internships>();
            this.knowledge = new HashSet<knowledge>();
            this.teachers1 = new HashSet<teachers>();
        }
    
        public long id { get; set; }
        public Nullable<int> supervisor_user_id { get; set; }
        public Nullable<int> teacher_user_id { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
        public System.DateTime creation_date { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string feedback { get; set; }
        public string approved { get; set; }
    
        public virtual supervisor supervisor { get; set; }
        public virtual teachers teachers { get; set; }
        public virtual ICollection<students_internships> students_internships { get; set; }
        public virtual ICollection<knowledge> knowledge { get; set; }
        public virtual ICollection<teachers> teachers1 { get; set; }
    }
}
