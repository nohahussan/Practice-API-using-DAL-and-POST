using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApIPractice.Models
{
    public class UserInput
    {
        [Required(ErrorMessage = "Must not be empty")]
        public string Title { get; set; }
    }
}