using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FORUM_WEB_2._0.Models
{
    public class ReportModel
    {
        [Required(ErrorMessage = "Nội dung không được để trống !")]
        public string NoiDung { set; get; }
    }
}