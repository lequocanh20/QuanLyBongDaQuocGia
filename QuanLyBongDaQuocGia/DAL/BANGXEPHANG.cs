//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBongDaQuocGia.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANGXEPHANG
    {
        public int MaXH { get; set; }
        public string MaDB { get; set; }
        public Nullable<int> Thang { get; set; }
        public Nullable<int> Hoa { get; set; }
        public Nullable<int> Thua { get; set; }
        public Nullable<int> HieuSo { get; set; }
        public Nullable<int> Diem { get; set; }
    
        public virtual DOIBONG DOIBONG { get; set; }
    }
}
