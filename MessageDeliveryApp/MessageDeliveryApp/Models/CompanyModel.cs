using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MessageDeliveryApp.Models
{
    public class CompanyModel
    {
        public Guid IDCompany { get; set; }
        public Guid IDDeliverySystem { get; set; }
        [Required(ErrorMessage = "Mandatory field!")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Mandatory field!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Mandatory field!")]
        public string Country { get; set; }
        
    }
}