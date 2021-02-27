using System;
using System.ComponentModel.DataAnnotations;

namespace EventWebApp.CustomValidation
{
    public class DateFutureOnlyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value != null && (DateTime)value > DateTime.Now;
        }
    }
}
