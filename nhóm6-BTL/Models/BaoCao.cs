using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nhóm6_BTL.Models
{
    public class BaoCao
    {
        [Key]
        public int DoanhThuTheoThang { get; set; }
        public int DoanhThuTheoQuy { get; set; }
        public int DonHangTrongNgay { get; set; }
        public int DonHangTrongThang { get; set; }
    }
}