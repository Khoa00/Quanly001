//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Thuctap01.Models
//{
//    public class Bangchamcongmodel
//    {
//        [Key]
//        [Required(ErrorMessage = "Bạn Cần Nhập Mã Giảng Viên")]
//        [Display(Name = "Mã giảng viên")]
//        public int Magiangvien { get; set; }

//        [Required(ErrorMessage = "Bạn Cần Nhập Họ Và Tên")]
//        [Display(Name = "Họ và tên")]
//        [StringLength(100)]
//        public string Hovaten { get; set; }

//        [Required(ErrorMessage = "Bạn Cần Khoa-Khối")]
//        [Display(Name = "Khoa-Khối")]
//        [StringLength(100)]
//        public string Khoakhoi { get; set; }

//        [Display(Name = "Nghĩ phép")]
//        [StringLength(100)]
//        public string Nghiphep { get; set; }

//        [Required(ErrorMessage = "Bạn Cần Nhập Chức Vụ")]
//        [Display(Name = "Chức Vụ")]
//        [StringLength(100)]
//        public string Chucvu { get; set; }

//        [Required, Range(0, double.MaxValue), Display(Name = "Tổng Ngày Công")]
//        public double Tongngaycong { get; set; }

//        [Display(Name = "Ngày Công Thực Tế")]
//        [StringLength(100)]
//        public string Ngaycongthucte { get; set; }

//        [Required(ErrorMessage = "Bạn Cần Chọn Tổng Thời Lượng Giảng Dạy")]
//        [Display(Name = "Tổng Thời Lượng Giảng Dạy")]
//        [StringLength(100)]
//        public string Tongthoiluonggiangday { get; set; }
//        public GiangvienModel giangvienModel { get; set; }
//    }
//}
