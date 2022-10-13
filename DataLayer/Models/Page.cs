using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer
{
    public class Page
    {
        [Key]
        public int PageID { get; set; }
        [Required(ErrorMessage ="لطفا گروه خبر را وارد کنید")]
        [Display(Name ="گروه خبر")]
        public int GroupID { get; set; }
        [Required(ErrorMessage ="لطفا عنوان خبر را وارد کنید")]
        [Display(Name ="عنوان خبر")]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required(ErrorMessage ="لطفا شرح مختصر را وارد کنید")]
        [Display(Name ="شرح مختصر")]
        [MaxLength(350)]
        public string ShortDescription { get; set; }
        [Required(ErrorMessage ="لطفا متن خبر را وارد کنید")]
        [Display(Name ="متن خبر")]
        [MaxLength(500)]
        public string Text { get; set; }
        [Display(Name ="تعداد بازدید")]
        public int Visit { get; set; }
        [Display(Name ="عکس خبر")]
        public string ImageName { get; set; }
        [Display(Name =" نمایش در اسلایدر")]
        public bool ShowSlider { get; set; }
        [Display(Name ="ناریخ ایجاد")]
        public DateTime CreateDate { get; set; }
        public virtual PageGroup PageGroup { get; set; }
        public virtual List<PageComment> PageComments { get; set; }
        public Page()
        {

        }
    }
}
