using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class DoanhmuckhoanthuModel
    {
        [Key]
        [Display(Name = "STT")]
        public int Madoituong { get; set; } 

        [Required(ErrorMessage = "Bạn cần chọn tên khoản thu")]
        [Display(Name = "Tên Khoản Thu")]
        [StringLength(100)]
        public string Tenkhoanthu { get; set; }

        [Display(Name = "Khoản thu theo")]
        [StringLength(100)]
        public string Khoanthutheo { get; set; }

        [Display(Name ="Thời lượng tính")]
        public int Thoiluongtinh { get; set; }

        [Display(Name = "Đơn vị tính")]
        [StringLength(100)]
        public string Donvitinh { get; set; }

        [Required, Range(0, double.MaxValue)]
        [Display(Name = "Mức thu(VNĐ)")]
        public double Mucthu { get; set; }

        [Display(Name = "Hình thức")]
        [StringLength(100)]
        public string Hinhthuc { get; set; }

        public MuchocphiModel muchocphiModel { get; set; }
    }
}
