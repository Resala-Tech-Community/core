using System;
using System.ComponentModel.DataAnnotations;

namespace resala.core.Validation.Attributes
{
    public class ValidPastDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dt;
            bool IsValidDate = DateTime.TryParse(value.ToString(), out dt);

            return IsValidDate && dt < DateTime.Now;
        }
    }
}
