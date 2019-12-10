using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace voleyballnews.models
{
    public class tintuc
    {
        [ScaffoldColumn(false)]
        public int TINTUC_ID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string NOIDUNG { get; set; }
        [Required, StringLength(1000), Display(Name = "Book Description"),
        DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public float? UnitPrice { get; set; }
        public int? TACGIA_ID { get; set; }
        public virtual TACGIA TACGIA { get; set; }
    }
}