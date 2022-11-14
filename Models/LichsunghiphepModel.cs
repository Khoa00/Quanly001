using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class LichsunghiphepModel
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần Nhập Mã Giảng Viên")]
        [Display(Name = "Mã giảng viên")]
        public int Magiangvien { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Họ Và Tên")]
        [Display(Name = "Họ và tên")]
        [StringLength(100)]
        public string Hovaten { get; set; }

        [Display(Name = "Lý Do Nghĩ phép")]
        [StringLength(100)]
        public string Lydonghiphep { get; set; }

        [Required(ErrorMessage = "Bạn Cần Khoa-Khối")]
        [Display(Name = "Khoa-Khối")]
        [StringLength(100)]
        public string Khoakhoi { get; set; }

        [Display(Name = "Từ Ngày")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Tungay { get; set; }

        [Display(Name = "Đến Ngày")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Denngay { get; set; }

        [Required(ErrorMessage = "Chọn Trạng Thái")]
        [Display(Name = "Trạng Thái")]
        public string Trangthai { get; set; }

        public GiangvienModel giangvienModelss { get; set; }
    }
}
