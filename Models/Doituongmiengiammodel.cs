using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class Doituongmiengiammodel
    {
        [Key]
        [Display(Name = "Mã đối tượng")]
        public int Madoituong { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Mã Đối Tượng")]
        [Display(Name = "Đối tượng")]
        public int Doituong { get; set; }

        [Display(Name = "Mô tả")]
        [StringLength(100)]
        public string Mota { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn File Đính kèm")]
        [Display(Name = "File Đính kèm")]
        [StringLength(100)]
        public string Filedinhkem { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Chọn File Quyết Định")]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "Ghi chú")]
        [StringLength(100)]
        public string Ghichu { get; set; }
    }
}
