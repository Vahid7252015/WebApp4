using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer
{
    public class PageComment
    {
        [Key]
        public int CommentID { get; set; }
        [Required(ErrorMessage = "لطفا خبر را وارد کنید")]
        [Display(Name = "خبر")]
        public int PageID { get; set; }
        [Required(ErrorMessage = "لطفا نام را وارد کنید")]
        [Display(Name = "نام")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "رایانامه")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Display(Name = "تارنما")]
        [MaxLength(50)]
        public string WebSite { get; set; }
        [Required(ErrorMessage ="لطفا نظر خود را وارد کنید")]
        [Display(Name ="نظر")]
        [MaxLength()]
        public string Comment { get; set; }
        [Display(Name ="تاریخ ایجاد")]
        public DateTime CreatedDate { get; set; }
        public virtual Page Page { get; set; }
        public PageComment()
        {
                
        }

    }
}
