using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public enum Gender
    {
        [Display(Name = "Nam")]
        Nam = 1,
        [Display(Name = "Nữ")]
        Nu = 2
    }

    public class GiangvienModel
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần Nhập Mã Giảng Viên")]
        [Display(Name = "Mã giảng viên")]
        public int Magiangvien { get; set; } 

        [Required(ErrorMessage = "Bạn Cần Nhập Họ Và Tên")]
        [Display(Name = "Họ và tên")]
        [StringLength(100)]
        public string Hovaten { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn Giới Tính")]
        [Display(Name = "Giới Tính")]
        public Gender Gioitinh { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Sinh"), Display(Name = "Ngày Sinh")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? NgaySinh { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Số CMND/CCCD")]
        [Display(Name = "Số CMND/CCCD")]
        public int SoCMND { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Cấp"), Display(Name = "Ngày Cấp")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngaycap { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Nơi Cấp")]
        [Display(Name = "Nơi Cấp")]
        [StringLength(100)]
        public string Noicap { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Địa Chỉ")]
        [Display(Name = "Địa Chỉ")]
        [StringLength(100)]
        public string Diachi { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Số sổ BHXH")]
        [Display(Name = "Số sổ BHXH")]
        [StringLength(100)]
        public string BHXH { get; set; }

        [Display(Name = "Trình độ đào tạo")]
        [StringLength(100)]
        public string Trinhdodaotao { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Chức Vụ")]
        [Display(Name = "Chức Vụ")]
        [StringLength(100)]
        public string Chucvu { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Tổ Bộ Môn")]
        [Display(Name = "Tổ Bộ Môn")]
        [StringLength(100)]
        public string Tobomon { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Loại Hợp Đồng")]
        [Display(Name = "Loại Hợp Đồng")]
        [StringLength(100)]
        public string Loaihopdong { get; set; }

        [Display(Name = "Nghĩ Phép")]
        [StringLength(100)]
        public string Nghiphep { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Trạng Thái")]
        [Display(Name = "Trạng thái")]
        [StringLength(100)]
        public string Trangthai { get; set; }

        [Display(Name = "Mã Ngạch")]
        public double manghach { get; set; }

        [Display(Name = "Văn Bản Quyết Định")]
        [Column(TypeName = "varchar(200)"), MaxLength(100)]
        public string Vanbanquyetdinh { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Chọn Văn Bản Quyết Định")]
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Áp Dụng Chức Vụ"), Display(Name = "Ngày áp dụng chức vụ")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngayapdungchucvu { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Bắt Đầu Làm Việc"), Display(Name = "Ngày bắt đầu làm việc")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngaybatdaulamviec { get; set; }
    }
}
