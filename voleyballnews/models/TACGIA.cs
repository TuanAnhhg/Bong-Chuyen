using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace voleyballnews.models
{
    public class TACGIA
    {
        [ScaffoldColumn(false)]
        public int TACGIA_ID { get; set; }
        [System.ComponentModel.DataAnnotations.Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }
        public virtual ICollection<tintuc> TINTUC { get; set; }
        public string TENTACGIA { get; internal set; }
        public string EMAIL { get; internal set; }

        public static implicit operator TACGIA(string v)
        {
            throw new NotImplementedException();
        }
    }
}