using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WorkSheets.Models.Base;

namespace WorkSheets.Models
{
    public class MethodViewModel
        :BaseModel
    {
        [DisplayName("Наименование методики")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "поле обязательно для заполнения")]
        [StringLength(1024, ErrorMessage = "Наименование слишком длинное (максимально - 1024 символа)")]
        public string Name { get; set; }
    }
}