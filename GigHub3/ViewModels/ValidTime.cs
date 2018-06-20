using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub3.ViewModels
{
    public class ValidTime : ValidationAttribute

    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isVaalid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentUICulture,
                DateTimeStyles.None,
                out dateTime);

            return (isVaalid);
        }
    }
}