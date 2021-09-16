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
    
    public partial class Surucu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Surucu()
        {
            this.Transfer = new HashSet<Transfer>();
        }
    
        public int surucuID { get; set; }
        public Nullable<int> acentaID { get; set; }
        public Nullable<int> ulkeID { get; set; }
        public Nullable<int> sehirID { get; set; }
        public Nullable<int> aracID { get; set; }
        public Nullable<int> dilID { get; set; }
        public string surucuAdi { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public string plaka { get; set; }
        public Nullable<System.DateTime> kayıtTarih { get; set; }
        public Nullable<System.DateTime> sonLogin { get; set; }
        public string tcKimlikNo { get; set; }
        public string adres { get; set; }
        public string sifre { get; set; }
        public Nullable<int> surucuTip { get; set; }
        public Nullable<int> surucuKomisyon { get; set; }
        public Nullable<int> sozlesme { get; set; }
        public Nullable<System.DateTime> sozlesmeOnayTarih { get; set; }
        public string faturaBilgisi { get; set; }
        public string ıban { get; set; }
        public string vergiDaire { get; set; }
        public string vergiDaireNo { get; set; }
        public Nullable<decimal> kredi { get; set; }
        public string notlar { get; set; }
    
        public virtual Acente Acente { get; set; }
        public virtual Arac Arac { get; set; }
        public virtual Dil Dil { get; set; }
        public virtual Sehir Sehir { get; set; }
        public virtual Ulke Ulke { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer> Transfer { get; set; }
    }
}
