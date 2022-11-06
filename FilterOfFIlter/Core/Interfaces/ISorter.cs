using System;
using System.Collections.Generic;
using System.Text;

namespace FilterOfFIlter
{
    public interface ISorter
    {
        void SortingAfterAndBefore(ref List<string> list);
    }
}
