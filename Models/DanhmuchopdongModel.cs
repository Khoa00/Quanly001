using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class DanhmuchopdongModel
    {
        [Key]
        [Display(Name = "STT")]
        public int Madoituong { get; set; }

        [Required(ErrorMessage = "Bạn cần chọn loại hợp đồng")]
        [Display(Name = "Loại hợp đồng")]
        [StringLength(100)]
        public string Loaihopdong { get; set; }

        [Required(ErrorMessage = "Bạn cần chọn tên hợp đồng")]
        [Display(Name = "Tên hợp đồng")]
        [StringLength(100)]
        public string Tenhopdong { get; set; }

        [Required, Range(0, double.MaxValue)]
        [Display(Name = "Lương cơ bản")]
        public double Luongcoban  { get; set; }

        [Required, Range(0, double.MaxValue)]
        [Display(Name = "Bảo hiểm phải đóng")]
        public double Baohiemphaidong { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Tạo"), Display(Name = "Ngày tạo")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngaytao { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn File đính kèm")]
        [Display(Name = "File đính kèm")]
        [StringLength(100)]
        public string Filedinhkem { get; set; }
        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Chọn File Quyết Định")]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Trạng thái")]
        [StringLength(100)]
        public string Trangthai  { get; set; }
    }
}
