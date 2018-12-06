using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class AuthorDropDown
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="Autor")]
        public string Author { get; set; }
    }
}
