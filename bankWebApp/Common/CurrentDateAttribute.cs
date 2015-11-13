using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bankWebApp.Common
{
    public class CurrentDateAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (Convert.ToDateTime(value)<= DateTime.Now) ? true : false;
        }
    }
}