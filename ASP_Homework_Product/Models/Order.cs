using System;
using System.ComponentModel.DataAnnotations;

namespace Advertisement.Models
{
    public class Order
    {
        public Order () 
        {
            OrderDate= DateTime.Now;
            Status = "новый";
        }
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [Phone]
        [StringLength(11, MinimumLength = 11)]
        public string PhoneNumber { get; set; }

        [Required]
        public string OrderType { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
