using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddingBootstrapTheme.Models
{
    public class Police
    {
        public int ID { get; set; }
        [Display(Name="Officer Name")]
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentID { get; set; } // foreign key.
        public Department Department { get; set; } // navigation property.


    }
}