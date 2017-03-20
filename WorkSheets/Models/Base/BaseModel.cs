using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkSheets.Models.Base
{
    public class BaseModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
    }
}