namespace TeachMeMVCApp.Data
{
    public class Constants
    {
        public class Title
        {
            public const int minTitleLength = 2;
            public const int maxTitleLength = 100;
        }

        public class Description
        {
            public const int minDescriptionLength = 2;
            public const int maxDescriptionLength = 1000;
        }

        public class Common
        {
            public const string requiredFieldMessage = "This field is required!";
            public const string requiredDropDownMessage = "Please select valid '{0}' from list!";
        }

        public class DateFormat
        {
            public const string dateFormat = "{0:yyyy-MM-dd}";
        }

        public class Login
        {
            public const int minEmailLength = 10;
            public const int maxEmailLength = 100;
            public const int minPasswordLength = 6;
            public const int maxPasswordLength = 256;
        }
    }
}
