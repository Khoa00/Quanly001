using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thuctap01.Migrations
{
    public partial class THUCTAP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DangnhapModels",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chucdanh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangnhapModels", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "GiangvienModels",
                columns: table => new
                {
                    Magiangvien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hovaten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gioitinh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoCMND = table.Column<int>(type: "int", nullable: false),
                    Ngaycap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Noicap = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BHXH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Trinhdodaotao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Chucvu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tobomon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Vanbanquyetdinh = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Ngayapdungchucvu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngaybatdaulamviec = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangvienModels", x => x.Magiangvien);
                });

            migrationBuilder.CreateTable(
                name: "Luongs",
                columns: table => new
                {
                    Loaihopdong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lươngcoban = table.Column<int>(type: "int", nullable: false),
                    Luongcoban = table.Column<int>(type: "int", nullable: false),
                    Vanbanquyetdinh = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    baohiemphaidong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ngachhang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Bacluong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Hesoluong = table.Column<int>(type: "int", nullable: false),
                    Filedinhkem = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Ngayapdungngachbac = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luongs", x => x.Loaihopdong);
                });

            migrationBuilder.CreateTable(
                name: "MuchocphiModels",
                columns: table => new
                {
                    Mamonhoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monhoc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Khoakhoi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false),
                    Donvitinh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    mucthu = table.Column<int>(type: "int", nullable: false),
                    nienkhoa = table.Column<double>(type: "float", nullable: false),
                    Tonghocphi = table.Column<double>(type: "float", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuchocphiModels", x => x.Mamonhoc);
                });

            migrationBuilder.CreateTable(
                name: "QuanyhocphiModelss",
                columns: table => new
                {
                    Mahocvien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenhocvien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    lop = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Khoakhoi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Doituong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DienThoai = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    NgayNhapHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hocphi = table.Column<double>(type: "float", nullable: false),
                    Tonghocphi = table.Column<double>(type: "float", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thucthu = table.Column<double>(type: "float", nullable: false),
                    Ngaythu = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanyhocphiModelss", x => x.Mahocvien);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DangnhapModels");

            migrationBuilder.DropTable(
                name: "GiangvienModels");

            migrationBuilder.DropTable(
                name: "Luongs");

            migrationBuilder.DropTable(
                name: "MuchocphiModels");

            migrationBuilder.DropTable(
                name: "QuanyhocphiModelss");
        }
    }
}
