using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Common
{
   public static class EntityValidationConstants
    {
        public static class Product
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 2;
            public const int DescriptionMaxLength = 500;

        }
        public static class Request
        {
            public const int TitleMinLength = 2;
            public const int TitleMaxLength= 50;

            public const int DescriptionMinLength = 2;
            public const int DescriptionMaxLength = 300;

            public const int FirmNameMaxLength = 2;
            public const int FirmNameMinLength = 100;
        }


        public static class Board
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 40;
        }

        public static class Employee
        {
            public const int FirstNameMinLength = 1;
            public const int FirstNameMaxLength = 50;

            public const int SecondNameMinLength = 1;
            public const int SecondNameMaxLength = 50;

            public const int LastNameMinLength = 1;
            public const int LastNameMaxLength = 50;

            public const int PhoneNumberMinLength = 7;
            public const int PhoneNumberMaxLength = 15;
        }
    }

}
