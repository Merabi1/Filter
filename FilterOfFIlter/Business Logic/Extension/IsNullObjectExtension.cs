using System;
using System.Collections.Generic;
using System.Text;

namespace FilterOfFIlter
{
    public static class IsNullObjectExtension
    {
        public static bool IsNull(this object Object)
        {
            if (Object == null)
                return true;

            return false;
        }
    }
}
