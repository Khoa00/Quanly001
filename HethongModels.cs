using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class HethongModels
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần Nhập Mã Trường")]
        [Display(Name = "Mã trường")]
        [StringLength(100)]
        public int Matruong { get; set; }


        [Required(ErrorMessage = "Bạn Cần Nhập Tên Trường")]
        [Display(Name = "Tên trường")]
        [StringLength(100)]
        public string Tentruong { get; set; }

        [Required(ErrorMessage = "Bạn Cần Địa Danh Kỳ")]
        [Display(Name = "Địa danh kỳ")]
        [StringLength(100)]
        public string Diadanhy { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chức Vụ Kỳ")]
        [Display(Name = "Chức vụ kỳ")]
        [StringLength(100)]
        public string Chuvuky { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Sở Ban Ngành")]
        [Display(Name = "Sở Ban Ngành")]
        [StringLength(100)]
        public string Sobannganh { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Cơ Quan Cấp Trên")]
        [Display(Name = "Cơ Quan Cấp Trên")]
        [StringLength(100)]
        public string Coquancaptren { get; set; }

        [Display(Name = "Tỉnh Thành")]
        [StringLength(100)]
        public string Tinhthanh { get; set; }

        [Display(Name = "Huyện thị")]
        [StringLength(100)]
        public string Huyenthi { get; set; }

        [Display(Name = "Xã Phường")]
        [StringLength(100)]
        public string Xaphuong { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Địa Chỉ")]
        [Display(Name = "Địa chỉ")]
        [StringLength(100)]
        public string Diachi { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Số Điện Thoại"), Display(Name = "Số Điện Thoại")]
        [Column(TypeName = "varchar(15)"), MaxLength(15)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$", ErrorMessage = "Số Điện Thoại Không Hợp Lệ")]
        public string DienThoai { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Mã Số Thuê")]
        [Display(Name = "Mã Số Thuê")]
        [StringLength(100)]
        public int MAST { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Mã QHNS")]
        [Display(Name = "Mã QHNS")]
        [StringLength(100)]
        public int MAQHNS { get; set; }

        [Display(Name = "Kế Toán Trưởng")]
        [StringLength(100)]
        public string KTT { get; set; }

        [Display(Name = "Thủ quỹ")]
        [StringLength(100)]
        public int Thuquy { get; set; }

        [Display(Name = "Thủ trưởng đơn vị")]
        [StringLength(100)]
        public string Thutruongdonvi { get; set; }

        [Display(Name = "Đơn vị tiền tệ")]
        [StringLength(100)]
        public string Donvitiente { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Niên Khóa")]
        [Display(Name = "Niên Khóa")]
        public double nienkhoa { get; set; }
        public HethongModels hethongModelss { get; set; }
    }    
    public class hethonguudaimodel
    {
        [Key]
        [Display(Name = "Mã Ưu đãi")]
        [StringLength(100)]
        public string Mauudai { get; set; }

        [Display(Name = "Ưu đãi")]
        [StringLength(100)]
        public string Uudai { get; set; }

        [Display(Name = "Loại ưu đãi")]
        [StringLength(100)]
        public string Loaiuudai { get; set; }

        [Display(Name = "Giảm học phí")]
        public int Giamhocphi { get; set; }

        [Display(Name = "Áp dụng")]
        [StringLength(100)]
        public string Apdung { get; set; }

        [Display(Name = "Trạng thái")]
        public int Trangthai { get; set; }

        [Display(Name = "Bắt đầu")]
        [StringLength(100)]
        public string Batdau { get; set; }

        [Display(Name = "Kết thúc")]
        [StringLength(100)]
        public string Ketthuc { get; set; }
    }

}
