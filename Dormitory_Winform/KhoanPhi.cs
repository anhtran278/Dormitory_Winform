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
    
    public partial class KHOANPHI
    {
        public int MaKhoanPhi { get; set; }
        public int MaSV { get; set; }
        public System.DateTime NgayThanhToan { get; set; }
        public decimal TienPhong { get; set; }
        public decimal TienInternet { get; set; }
        public decimal TienGuiXe { get; set; }
        public decimal TienDienVaNuoc { get; set; }
    
        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
