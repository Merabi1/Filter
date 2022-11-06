using System;
using System.Collections.Generic;
using System.Text;

namespace FilterOfFIlter.Business_Logic.Extension
{
    public static class GetValueFromPropertyExtension
    {
        public static object GetValueFromProperty<T>(this T obj,string propertyName) 
        {
            return typeof(T).GetProperty(propertyName).GetValue(obj);        
        }
    }
}
