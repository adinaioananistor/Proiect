using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MessageDeliveryApp.Models
{
    public class MesajeModel
    {
        public Guid IDMesaj { get; set; }
        public Guid IDUser { get; set; }
        [Required(ErrorMessage = "Mandatory field!")]
        [StringLength(2500, ErrorMessage = "Content too long(max 2500 chars")]
        public string Content { get; set; }
        
    }
}