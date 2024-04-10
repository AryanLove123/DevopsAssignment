using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApp.CustomValidation
{
    public class DateValidator: ValidationAttribute
    {
        public DateValidator(): base("{0} Date should be greater than current date")
        {

        }

        public override bool IsValid(object value)
        {
            DateTime propValue = Convert.ToDateTime(value);
            if(propValue < DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    
}
