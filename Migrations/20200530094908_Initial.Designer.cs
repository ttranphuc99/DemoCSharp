﻿// <auto-generated />
using System;
using DemoWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoWeb.Migrations
{
    [DbContext(typeof(DemoWebContext))]
    [Migration("20200530094908_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoWeb.Models.Project", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BQLDuAn");

                    b.Property<string>("ChuDauTu");

                    b.Property<string>("ChuongTrinhMTQG");

                    b.Property<bool>("CoQDDieuChinh");

                    b.Property<string>("DonVi");

                    b.Property<string>("HinhThucDauTu");

                    b.Property<string>("HinhThucQuanLy");

                    b.Property<int>("LoaiDuAn");

                    b.Property<string>("MaQHNS");

                    b.Property<string>("NamQDDauTuBD");

                    b.Property<string>("NganhKinhTe");

                    b.Property<string>("NhomDuAn");

                    b.Property<int>("PhanLoaiDV");

                    b.Property<string>("SuDungNguonVon");

                    b.Property<string>("TKChuDauTu");

                    b.Property<string>("TenDuAn");

                    b.Property<string>("TinhTrang");

                    b.Property<string>("VaiTroChuaGanQuyen");

                    b.Property<DateTime>("XacNhanDuLieuMoiDenNgay");

                    b.Property<DateTime>("XacNhanDuLieuMoiTuNgay");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });
#pragma warning restore 612, 618
        }
    }
}
