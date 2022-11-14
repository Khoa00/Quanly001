using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class PhucapModel
    {
        [Key]
        [Display(Name = "STT")]
        public int STT { get; set; }
        
        [Required(ErrorMessage = "Bạn Cần Nhập Mã Phụ Cấp")]
        [Display(Name = "Mã phụ cấp")]
        
        public int Monhoc { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Tên Phụ Cấp")]
        [Display(Name = "Tên phụ cấp")]
        [StringLength(100)]
        public string Tenphucap { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Tên Giá Trị")]
        [Display(Name = "Giá trị")]
        [StringLength(100)]
        public string Giatri { get; set; }

        [Display(Name = "Kiểu giá trị")]
        [StringLength(100)]
        public string Kieugiatri { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Tạo"), Display(Name = "Ngày tạo")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngaytao { get; set; }

        [Required(ErrorMessage = "Chọn Trạng Thái")]
        [StringLength(100)]
        [Display(Name = "Trạng Thái")]
        public string Trangthai { get; set; }

    }
}
