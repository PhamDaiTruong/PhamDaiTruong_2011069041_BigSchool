using PhamDaiTruong_2011069041.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhamDaiTruong_2011069041.Viewmodels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        //[FutureDate]
        public string Date { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }

}