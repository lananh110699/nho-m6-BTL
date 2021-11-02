using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nhóm6_BTL.Models
{
    public class XuatKho
    {
        [Key]
        public int MaHang { get; set; }
        public int TenHang { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
    }
}