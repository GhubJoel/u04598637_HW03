using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace u04598637_HW03.Models
{
    public class FileModel 
    {
        [Display(Name = "File Name")]

        public string FileName { get; set; }
    }
}