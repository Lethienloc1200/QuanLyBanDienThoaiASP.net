//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteBangHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            this.PhieuNhaps = new HashSet<PhieuNhap>();
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string Fax { get; set; }
    
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
