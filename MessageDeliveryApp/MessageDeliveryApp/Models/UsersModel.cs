using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MessageDeliveryApp.Models
{
    public class UsersModel
    {
        

        public Guid IDUser { get; set; }

        [Required(ErrorMessage="Mandatory field!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mandatory field!")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Mandatory field!")]
        [StringLength(250,ErrorMessage ="Description too long(max 250 chars")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Mandatory field!")]
        public DateTime JoinDate { get; set; }

        
    }
}