//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Thuctap01.Models
//{
//    public class LuongModel
//    {
//        [Key]
//        [Display(Name = "ID Lương")]
//        public int IDLuong { get; set; }


//        [Required(ErrorMessage = "Bạn Cần Chọn Loại Hợp Đồng")]
//        [Display(Name = "Loại Hợp Đồng")]
//        [StringLength(100)]
//        public string Loaihopdong { get; set; }

//        [Required(ErrorMessage = "Bạn Cần Chọn Lương Cơ Bản")]
//        [Display(Name = "Lương Cơ Bản")]
//        public int Lươngcoban { get; set; } 

//        [Display(Name = "Văn Bản Quyết Định")]
//        [Column(TypeName = "varchar(200)"), MaxLength(100)]
//        public string Vanbanquyetdinh { get; set; }

//        [NotMapped]
//        [Display(Name = "Chọn Văn Bản Quyết Định")]
//        [StringLength(100)]
//        public IFormFile ImageFile { get; set; }

//        [Required(ErrorMessage = "Bạn Cần Chọn Bảo Hiểm Phải Đóng")]
//        [Display(Name = "Bảo hiểm phải đóng")]
//        [StringLength(100)]
//        public string baohiemphaidong { get; set; }

//        [Display(Name = "Ngạch/Hang ")]
//        [StringLength(100)]
//        public string Ngachhang { get; set; }

//        [Display(Name = "Mã Ngạch")]
//        public double manghach { get; set; }

//        [Display(Name = "Bậc Lượng")]
//        [StringLength(100)]
//        public string Bacluong { get; set; }

//        [Display(Name = "Phụ Cấp")]
//        [StringLength(100)]
//        public string Phucap { get; set; }

//        [Display(Name = "Hệ Số Lương")]
//        public int Hesoluong { get; set; }

//        [Display(Name = "File đính kèm")]
//        [Column(TypeName = "varchar(200)"), MaxLength(100)]
//        public string Filedinhkem { get; set; }

//        [NotMapped]
//        [Display(Name = "Chọn Văn Bản Quyết Định")]
//        [StringLength(100)]
//        public IFormFile Image { get; set; }

//        [Required(ErrorMessage = "Chọn Ngày Áp Dụng Ngạch Bậc"), Display(Name = "Ngày áp dụng ngạch bậc")]
//        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
//        public DateTime? Ngayapdungngachbac { get; set; }
//    }
//}
