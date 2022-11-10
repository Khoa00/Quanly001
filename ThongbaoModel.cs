using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Thuctap01.Models
{
    public class ThongbaoModel
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần chọn tiêu đề")]
        [Display(Name = "Tiêu đề")]
        [StringLength(100)]
        public string tieude { get; set; }

        [Required(ErrorMessage = "Bạn Cần chọn tên người nhận")]
        [Display(Name = "Người nhận")]
        [StringLength(100)]
        public string Nguoinhan { get; set; }

        [Required(ErrorMessage = "Bạn Cần chọn hình thức gửi")]
        [Display(Name = "Hình thức gửi")]
        [StringLength(100)]
        public string hinhthucgui { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn File đính kèm")]
        [Display(Name = "File đính kèm")]
        [StringLength(100)]
        public string Filedinhkem { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Chọn File Quyết Định")]
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Chọn Ngày nhận"), Display(Name = "Ngày nhận")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngaygui { get; set; }

        [Required(ErrorMessage = "Chọn giờ nhận"), Display(Name = "Giờ nhận")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Gionhan{ get; set; }

    }
    //public class ThongbaodaguiModels
    //{
        
    //    [Required(ErrorMessage = "Bạn Cần chọn tiêu đề")]
    //    [Display(Name = "Tiêu đề")]
    //    [StringLength(100)]
    //    public string tieude { get; set; }

    //    [Display(Name = "Người Gửi")]
    //    [StringLength(100)]
    //    public string Nguoigui { get; set; }

    //    [Required(ErrorMessage = "Bạn Cần chọn hình thức gửi")]
    //    [Display(Name = "Hình thức gửi")]
    //    [StringLength(100)]
    //    public string hinhthucgui { get; set; }

    //    [Required(ErrorMessage = "Bạn Cần Chọn File đính kèm")]
    //    [Display(Name = "File đính kèm")]
    //    [StringLength(100)]
    //    public string Filedinhkem { get; set; }

    //    [NotMapped]
    //    [DataType(DataType.Upload)]
    //    [Display(Name = "Chọn File Quyết Định")]
    //    public IFormFile ImageFile { get; set; }

    //    [Display(Name = "Ngày gửi")]
    //    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    //    public DateTime? Ngaygui { get; set; }

    //    [Display(Name = "Giờ gửi")]
    //    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    //    public DateTime? Giogui { get; set; }

    //    public ThongbaoModel Thongbaomodelss { get; set; }

    //}
    //public class ThongbaoluutamModels
    //{
    //    [Key]
    //    [Required(ErrorMessage = "Bạn Cần chọn tiêu đề")]
    //    [Display(Name = "Tiêu đề")]
    //    [StringLength(100)]
    //    public string tieude { get; set; }

    //    [Required(ErrorMessage = "Bạn Cần chọn tên người nhận")]
    //    [Display(Name = "Người nhận")]
    //    [StringLength(100)]
    //    public string Nguoinhan { get; set; }

    //    [Required(ErrorMessage = "Bạn Cần chọn hình thức gửi")]
    //    [Display(Name = "Hình thức gửi")]
    //    [StringLength(100)]
    //    public string hinhthucgui { get; set; }

    //    [Required(ErrorMessage = "Bạn Cần Chọn File đính kèm")]
    //    [Display(Name = "File đính kèm")]
    //    [StringLength(100)]
    //    public string Filedinhkem { get; set; }

    //    [NotMapped]
    //    [DataType(DataType.Upload)]
    //    [Display(Name = "Chọn File Quyết Định")]
    //    public IFormFile ImageFile { get; set; }

    //    [Display(Name = "Ngày tạo")]
    //    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    //    public DateTime? Ngaytao { get; set; }

    //    [Display(Name = "Giờ tạo")]
    //    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    //    public DateTime? Giotao { get; set; }

    //    public ThongbaoModel thongbaomodelss { get; set; }

    //}
}
