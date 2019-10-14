using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LnkdCours.Models
{
    public class FeedBack
    {
       
        public int ID { get; set; }

        [Required]
        [Display(Name = "Adresse Mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Commemtaire")]
        public string Comment { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime FeedBackDate { get; set; }
    }
}
