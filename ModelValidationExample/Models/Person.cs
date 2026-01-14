using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.Models
{
    public class Person
    {
        [Required(ErrorMessage = "{0} PersonName can't be empty or null")]
        [Display(Name = "Person name")]
        [StringLength(40, MinimumLength = 3, 
         ErrorMessage ="{0} should be between {2} and {1} chrachters long")]

        public string? PersonName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }

        [Range(0, 999.999, ErrorMessage ="{0} should be between ${1} and ${2}")]
        public double? Price { get; set; }

        public override string ToString()
        {
            return $"Person object - Person name: {PersonName}, Email: {Email}, " +
                $"Phone:{Phone}, Password:{Password},ConfirmPassword:{ConfirmPassword}, Price:{Price}";
        }
    }
}
