//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fifness.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.CHUDEs = new HashSet<CHUDE>();
            this.KHACHHANGs = new HashSet<KHACHHANG>();
            this.QUANGCAOs = new HashSet<QUANGCAO>();
            this.USERs = new HashSet<USER>();
        }
    
        public int MANV { get; set; }
        public string TENNV { get; set; }
        public string SDT { get; set; }
        public string GIOITINH { get; set; }
        public string DIACHI { get; set; }
        public string HINH { get; set; }
        public Nullable<int> MAKH { get; set; }
        public string GIOITHIEU { get; set; }
        public Nullable<int> MACV { get; set; }
        public string HINHmh { get; set; }
        public string LANGUEGE { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUDE> CHUDEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUANGCAO> QUANGCAOs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER> USERs { get; set; }
    }
}
