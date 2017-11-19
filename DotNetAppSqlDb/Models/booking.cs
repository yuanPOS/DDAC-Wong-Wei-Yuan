using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class booking
    {
        public int Id { get; set; }

        
        [ForeignKey("Customer")]
        [Display(Name = "Customer Name")]
        public int customer_id { get; set; }
        public virtual Customer Customer { get; set; }

        [Display(Name = "Origin")]
        public string origin { get; set; }

        [Display(Name = "Destination")]
        public string destination { get; set; }

        [Display(Name = "Depart Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime depart_date { get; set; }

        [Display(Name = "Return Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime return_date { get; set; }

        [Display(Name = "Trip Type")]
        public string trip_type { get; set; }

        [Display(Name = "Guests")]
        public int Guests { get; set; }
    }
}