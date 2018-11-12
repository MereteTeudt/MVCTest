using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class SubscribeModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }
    }
}