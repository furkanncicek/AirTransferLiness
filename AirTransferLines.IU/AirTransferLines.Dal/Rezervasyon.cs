//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirTransferLines.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezervasyon
    {
        public int rezervasyonID { get; set; }
        public Nullable<int> uyeID { get; set; }
        public Nullable<int> acentaID { get; set; }
        public Nullable<System.DateTime> kayıtTarih { get; set; }
        public Nullable<decimal> fiyat { get; set; }
        public Nullable<decimal> ekstrasızFiyat { get; set; }
        public Nullable<decimal> tlFiyat { get; set; }
        public Nullable<decimal> tlEkstrasızFiyat { get; set; }
        public string doviz { get; set; }
        public Nullable<decimal> euroKur { get; set; }
        public Nullable<decimal> usdKur { get; set; }
        public Nullable<decimal> indirimliFiyat { get; set; }
    
        public virtual Uye Uye { get; set; }
    }
}
