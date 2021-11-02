namespace nhóm6_BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_4_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaoCaos",
                c => new
                    {
                        DoanhThuTheoThang = c.Int(nullable: false, identity: true),
                        DoanhThuTheoQuy = c.Int(nullable: false),
                        DonHangTrongNgay = c.Int(nullable: false),
                        DonHangTrongThang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DoanhThuTheoThang);
            
            CreateTable(
                "dbo.DangNhap",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 50, unicode: false),
                        MatKhau = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
            CreateTable(
                "dbo.XuatKhoes",
                c => new
                    {
                        MaHang = c.Int(nullable: false, identity: true),
                        TenHang = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MaHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.XuatKhoes");
            DropTable("dbo.DangNhap");
            DropTable("dbo.BaoCaos");
        }
    }
}
