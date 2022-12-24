using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddingBootstrapTheme.Models
{
    public class Issue
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public int UserID { get; set; } // foreign key  : Assigned to which user.
        public User User { get; set; } // navigation prop for the assigned user.
        [Display(Name="Issued on")]
        [DataType(DataType.Date)]
        public DateTime IssuedOn { get; set; } // datepicker for the issue open date
        [Display(Name = "Deadline")]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; } // datepicker for the deadline


        //public string Status { get; set; } this is the status colum. LATER

    }
}