using System;
using System.Collections.Generic;
using System.Text;

namespace lab8.2
{
    public class SmartPhone : СolorScreenPhone
    {
        public bool IsSupportTouchScreen { get; set; }
        public int CountOfTouchs { get; set; }
        public int CountOfCameras { get; set; }
    }
}
