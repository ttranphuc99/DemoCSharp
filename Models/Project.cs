using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemoWeb.Models
{
    public class Project
    {
        public string Id { get; set; }
        public string DonVi { get; set; }
        public string NamQDDauTuBD { get; set; }
        public bool CoQDDieuChinh { get; set; }
        public int PhanLoaiDV { get; set; }
        public string TKChuDauTu { get; set; }
        public string ChuongTrinhMTQG { get; set; }
        public string MaQHNS { get; set; }
        public string TinhTrang { get; set; }
        public string TenDuAn { get; set; }
        public string HinhThucQuanLy { get; set; }
        public string HinhThucDauTu { get; set; }
        public string NganhKinhTe { get; set; }
        public string NhomDuAn { get; set; }
        public string ChuDauTu { get; set; }
        public string BQLDuAn { get; set; }
        public string VaiTroChuaGanQuyen { get; set; }
        public string SuDungNguonVon { get; set; }
        [DataType(DataType.Date)]
        public DateTime XacNhanDuLieuMoiTuNgay { get; set; }
        [DataType(DataType.Date)]
        public DateTime XacNhanDuLieuMoiDenNgay { get; set; }
        public int LoaiDuAn { get; set; }
    }
}
