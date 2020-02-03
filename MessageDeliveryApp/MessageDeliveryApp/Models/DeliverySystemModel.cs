using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MessageDeliveryApp.Models
{
    public class DeliverySystemModel
    {
        public Guid IDDeliverySystem { get; set; }
        public Guid IDMesaj { get; set; }
        [Required(ErrorMessage = "Mandatory field!")]
        public string Provider { get; set; }
        [Required(ErrorMessage = "Mandatory field!")]
        public DateTime ExpiryDate { get; set; }
        
    }
}