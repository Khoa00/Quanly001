using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class QuanlyluongModel
    {
        [Key]
        [Display(Name = "Mã bảng Lương")]
        public int Mabangluong { get; set; }


        [Required(ErrorMessage = "Bạn Cần Chọn Tên Bảng Lương")]
        [Display(Name = "Tên Bảng Lương")]
        [StringLength(100)]
        public string Loaihopdong { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Kì Tính Lương")]
        [Display(Name = "Kì Tính Lương")]
        [StringLength(100)]
        public string Kitinhluong { get; set; }

        [Display(Name = "Tổng Lương Phải Chi")]
        [StringLength(100)]
        public string Tongluongphaichi { get; set; }

        [Display(Name = "Đã Chi Lương")]
        [StringLength(100)]
        public string Dachiluong { get; set; }

        [Display(Name = "Chưa Chi Lương")]
        [StringLength(100)]
        public string Chuchiluong { get; set; }

        [Required(ErrorMessage = "Chọn Trạng Thái")]
        [Display(Name = "Trạng Thái")]
        public string Trangthai { get; set; }
    }
}
