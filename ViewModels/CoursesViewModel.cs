using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool.Models;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCoures { get; set; }
        public bool ShowAction { get; set; }
    }
}