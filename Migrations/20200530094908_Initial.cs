using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWeb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DonVi = table.Column<string>(nullable: true),
                    NamQDDauTuBD = table.Column<string>(nullable: true),
                    CoQDDieuChinh = table.Column<bool>(nullable: false),
                    PhanLoaiDV = table.Column<int>(nullable: false),
                    TKChuDauTu = table.Column<string>(nullable: true),
                    ChuongTrinhMTQG = table.Column<string>(nullable: true),
                    MaQHNS = table.Column<string>(nullable: true),
                    TinhTrang = table.Column<string>(nullable: true),
                    TenDuAn = table.Column<string>(nullable: true),
                    HinhThucQuanLy = table.Column<string>(nullable: true),
                    HinhThucDauTu = table.Column<string>(nullable: true),
                    NganhKinhTe = table.Column<string>(nullable: true),
                    NhomDuAn = table.Column<string>(nullable: true),
                    ChuDauTu = table.Column<string>(nullable: true),
                    BQLDuAn = table.Column<string>(nullable: true),
                    VaiTroChuaGanQuyen = table.Column<string>(nullable: true),
                    SuDungNguonVon = table.Column<string>(nullable: true),
                    XacNhanDuLieuMoiTuNgay = table.Column<DateTime>(nullable: false),
                    XacNhanDuLieuMoiDenNgay = table.Column<DateTime>(nullable: false),
                    LoaiDuAn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
