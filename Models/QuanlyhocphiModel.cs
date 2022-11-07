using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class QuanlyhocphiModel
    {
        [Key]   
        [Required(ErrorMessage = "Bạn Cần Nhập Mã Học Viên")]
        [Display(Name = "Mã học viên")]
        public int Mahocvien { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Tên Học Viên")]
        [Display(Name = "Tên Học Viên")]
        [StringLength(100)]
        public string Tenhocvien { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Lớp")]
        [Display(Name = "Lớp")]
        [StringLength(100)]
        public string lop { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Niên Khóa")]
        [Display(Name = "Niên Khóa")]
        public double nienkhoa { get; set; }

        [Required(ErrorMessage = "Bạn Cần Khoa-Khối")]
        [Display(Name = "Khoa-Khối")]
        [StringLength(100)]
        public string Khoakhoi { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Đối Tượng")]
        [Display(Name = "Đối Tượng")]
        [StringLength(100)]
        public string Doituong { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Số Điện Thoại"), Display(Name = "Số Điện Thoại")]
        [Column(TypeName = "varchar(15)"), MaxLength(15)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$", ErrorMessage = "Số Điện Thoại Không Hợp Lệ")]
        public string DienThoai { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Nhập Học"), Display(Name = "Ngày Nhập Học")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? NgayNhapHoc { get; set; }

        [Display(Name = "Học Phí")]
        public double Hocphi { get; set; }


        [Required, Range(0, double.MaxValue), Display(Name = "Tổng Học Phí")]
        public double Tonghocphi { get; set; }

        [Required(ErrorMessage = "Chọn Trạng Thái")]
        [Display(Name = "Trạng Thái")]
        public string Trangthai { get; set; }

        [Required, Range(0, double.MaxValue), Display(Name = "Thực Thu")]
        public double Thucthu { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Thu"), Display(Name = "Ngày thu")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngaythu { get; set; }
        
    }
}
