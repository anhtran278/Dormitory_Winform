//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dormitory_Winform
{
    using System;
    using System.Collections.Generic;
    
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            this.KHOANPHIs = new HashSet<KHOANPHI>();
            this.NGUOITHANs = new HashSet<NGUOITHAN>();
            this.SINHVIENVAOPHONGs = new HashSet<SINHVIENVAOPHONG>();
        }
    
        public int MaSV { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string LoaiPhongSVDangKi { get; set; }
        public string TrangThaiDki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOANPHI> KHOANPHIs { get; set; }
        public virtual LOAIPHONGSVDKI LOAIPHONGSVDKI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOITHAN> NGUOITHANs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIENVAOPHONG> SINHVIENVAOPHONGs { get; set; }
    }
}
