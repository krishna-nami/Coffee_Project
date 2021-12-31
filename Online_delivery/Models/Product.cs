using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_delivery.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage ="PRoduct Name is Required")]
        [StringLength(30)]
        [DisplayName("Product Name") ]
        public string name { get; set; }
        [Required(ErrorMessage = "PRoduct PRice is Required")]
        public double price { get; set; }
        [Required(ErrorMessage = "PRoduct Image is Required")]
        public string Pimage { get; set; }
        public string Pbrief { get; set; } 
        
        public int qty { get; set; }
         
        public string details { get; set; }
        public double rating { get; set; }
        
    }
}