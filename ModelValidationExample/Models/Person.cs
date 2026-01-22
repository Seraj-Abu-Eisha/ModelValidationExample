using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ModelValidationExample.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.Models
{
    public class Person
    {
        [Required(ErrorMessage = "{0} PersonName can't be empty or null")]
        [Display(Name = "Person name")]
        [StringLength(40, MinimumLength = 3,
         ErrorMessage = "{0} should be between {2} and {1} chrachters long")]
        [RegularExpression("^[A-Za-z .]$", ErrorMessage = "{0} should only have contain only alphabets" +
            ",space and dot (.)")]
        public string? PersonName { get; set; }
        [EmailAddress(ErrorMessage = "{0} error should contain proper address")]
        [Required(ErrorMessage ="{0} can't be left empty")]
        public string? Email { get; set; }
        [Phone(ErrorMessage= "{0} Error, write a number contain 10 digits and no alphabets")]
        //[ValidateNever]
        public string? Phone { get; set; }
        [Required (ErrorMessage = "{0} make a proper password")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "{0} confirm the password")]
        [Compare("Password", ErrorMessage ="{0} and {1} do not match")]
        [Display(Name = "Re-Password")]
        public string? ConfirmPassword { get; set; }

        [Range(0, 999.999, ErrorMessage ="{0} should be between ${1} and ${2}")]
        public double? Price { get; set; }

        [MinimumYearValidator(2005)]
        public DateTime? DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"Person object - Person name: {PersonName}, Email: {Email}, " +
                $"Phone:{Phone}, Password:{Password},ConfirmPassword:{ConfirmPassword}, Price:{Price}";
        }
    }
}
