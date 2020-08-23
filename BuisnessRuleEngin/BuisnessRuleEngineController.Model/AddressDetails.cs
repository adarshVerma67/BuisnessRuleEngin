using System;
using System.ComponentModel.DataAnnotations;

namespace BuisnessRuleEngineControllers.Model
{
    public class AddressDetails
    {
        [Required]
        public int DoorNumber { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public String PinCode { get; set; }

    }
}
