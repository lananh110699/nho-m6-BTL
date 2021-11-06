using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nhóm6_BTL.Models
{
    public class NhapKho
    
        {
        [Key]
        public int MaPhieuNhap { get; set; }
        public int NgayXuat { get; set; }
        public int MaHang { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int MaNV { get; set; }
    
}
}