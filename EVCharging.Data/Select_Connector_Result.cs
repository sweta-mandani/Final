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
    
    public partial class Select_Connector_Result
    {
        public int Id { get; set; }
        public Nullable<int> ChargerId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> ConnectorTypeId { get; set; }
        public string ConnectorStatus { get; set; }
        public string SMSCode { get; set; }
        public string ConnectorUnId { get; set; }
        public string Tariff { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    }
}
