using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_lab2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string phone { get; set; }

        public string Address { get; set; }


    }
}