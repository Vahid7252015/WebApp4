using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace DataLayer
{
    public class PageGroup
    {
        [Key]
        public int GroupID { get; set; }
        [Required(ErrorMessage ="لطفا عنوان گروه را وارد نمایید")]
        [Display(Name ="عنوان گروه")]
        [MaxLength(50)]
        public string GroupTitle { get; set; }
        public virtual List<Page> Pages { get; set; }
        public PageGroup()
        {
                
        }

    }
}
