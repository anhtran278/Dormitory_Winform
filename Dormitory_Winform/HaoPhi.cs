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
    
    public partial class HAOPHI
    {
        public int MaHaoPhi { get; set; }
        public string MaPhong { get; set; }
        public int MaThietBi { get; set; }
        public decimal TienBaoTriPhong { get; set; }
        public decimal TienBaoTriThietBi { get; set; }
        public System.DateTime NgayHaoPhi { get; set; }
    
        public virtual PHONG PHONG { get; set; }
        public virtual THIETBI THIETBI { get; set; }
    }
}
