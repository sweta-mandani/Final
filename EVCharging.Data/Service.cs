//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVCharging.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public Nullable<bool> Accepted { get; set; }
        public string ServiceStatus { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    }
}
public enum ServiceStatus
{
    Pending,
    Completed
}