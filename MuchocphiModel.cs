using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{   
    public class MuchocphiModel
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần Nhập Mã Môn Học")]
        [Display(Name = "Mã môn học")]
        public int Mamonhoc { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Tên Môn Học")]
        [Display(Name = "Môn học")]
        [StringLength(100)]
        public string Monhoc { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Niên Khóa")]
        [Display(Name = "Niên Khóa")]
        public double nienkhoa { get; set; }
        

        [Required(ErrorMessage = "Bạn Cần Khoa-Khối")]
        [Display(Name = "Khoa-Khối")]
        [StringLength(100)]
        public string Khoakhoi { get; set; }

        [Required(ErrorMessage = "Tổng thời lượng môn học của một môn tính theo 1 đơn vị tính Ví dụ một môn học bắt buộc phải học 3 lần chỉ theo quy định của trường học")]
        [Display(Name = "Thời lượng")]
        public int ThoiLuong { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Đơn Vị Tính")]
        [Display(Name = "Đơn vị tính")]
        [StringLength(100)]
        public string Donvitinh { get; set; }

        [Display(Name = "Mức thu/1 đơn vị tính")]
        public int mucthu { get; set; }

        [Required, Range(0, double.MaxValue)]
        [Display(Name = "Tổng học phí phải thu")]
        public double Tonghocphi { get; set; }

        [Required(ErrorMessage = "Chọn Trạng Thái")]
        [StringLength(100)]
        [Display(Name = "Trạng Thái")]
        public string Trangthai { get; set; }
    }
}
