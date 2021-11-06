namespace nhóm6_BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ceate_table_hanghoa : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.XuatKhoes", newName: "HangHoas");
            CreateTable(
                "dbo.NhapKhoes",
                c => new
                    {
                        MaPhieuNhap = c.Int(nullable: false, identity: true),
                        NgayXuat = c.Int(nullable: false),
                        MaHang = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                        MaNV = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuNhap);
            
            CreateTable(
                "dbo.XuatKhoes",
                c => new
                    {
                        MaPhieuXuat = c.Int(nullable: false, identity: true),
                        NgayXuat = c.Int(nullable: false),
                        MaHang = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                        MaNV = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuXuat);
            
            AddColumn("dbo.HangHoas", "Size", c => c.Int(nullable: false));
            DropColumn("dbo.HangHoas", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HangHoas", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.HangHoas", "Size");
            DropTable("dbo.XuatKhoes");
            DropTable("dbo.NhapKhoes");
            RenameTable(name: "dbo.HangHoas", newName: "XuatKhoes");
        }
    }
}
