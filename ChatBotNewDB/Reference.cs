//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatBotNewDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reference
    {
        public int ParentID { get; set; }
        public int ChildID { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
    
        public virtual Node Node { get; set; }
        public virtual Node Node1 { get; set; }
    }
}