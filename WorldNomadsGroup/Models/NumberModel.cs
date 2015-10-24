using System;
using System.Collections.Generic;
using System.Web.DynamicData;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldNomadsGroup.Models
{
    public class NumberModel
    {
        //[Range(1,Int32.MaxValue)]
        //[DataType(DataType.Custom)]
        [Minimumvalue(1)]
        [Required(ErrorMessage = "Number is Required")]
        [DisplayName("Value")]
        public int NumberVal { get; set; }
    }
    public class MinimumvalueAttribute : ValidationAttribute
    {
        private int m_minimumValue;

        public MinimumvalueAttribute(int value)
        {
            m_minimumValue = value;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) // lets check if we have some value
            {
                if (value is int) // check if it is a valid integer
                {
                    int suppliedValue = (int)value;
                    if (suppliedValue < m_minimumValue)
                    {
                        // let the user know about the validation error
                        return new ValidationResult("Minimum value for this field should be " + m_minimumValue);
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}