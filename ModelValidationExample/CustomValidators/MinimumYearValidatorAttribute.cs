using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.CustomValidators
{
    public class MinimumYearValidatorAttribute : ValidationAttribute
    {
        public int MinimumYear { get; set; } = 2000;
        public string DefualtErrorMessage { get; set; } =
        "Date of birth should not be nwere than Jan 01, {0}";
        public MinimumYearValidatorAttribute()
        {

        }
        public MinimumYearValidatorAttribute(int minimumYear) 
        {
            MinimumYear = minimumYear;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                if (date.Year >= MinimumYear)
                {
                    return new ValidationResult(string.Format(ErrorMessage?? 
                        DefualtErrorMessage, MinimumYear));
                }
                else 
                {
                    return ValidationResult.Success; 
                }
            }
            return null;
        }
    }
}
