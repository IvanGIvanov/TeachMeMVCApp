using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeachMeMVCApp.Data
{
    public class DataConstants
    {
        public class Title
        {
            public const int minTitleLength = 2;
            public const int maxTitleLength = 100;
        }

        public class Description
        {

        }

        public class Common
        {
            public const string requiredFieldMessage = "This field is required!";
        }
    }
}
