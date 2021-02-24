using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product Name is invalid";
        public static string MaintenanceTime = "The system is under maintenance";
        public static string ProductsListed = "Products have been listed";

        public static string ProductCountInCategoryError = "Number of products can be at most 10";

        public static string ProductNameExist = "There is another product with the same product name";

        public static string CategoryLimitExceeded = "New Product addition is blocked since Category Limit exceeded";
    }
}
