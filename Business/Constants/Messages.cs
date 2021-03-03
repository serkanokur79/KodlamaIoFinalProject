using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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

        public static string AuthorizationDenied = "You don't have authorization for this";

        public static string UserNotFound = "User not found!";
        public static string UserRegistered = "User registered!";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access Token Created";
        public static string SuccessfulLogin = "Login Successful";
        public static string PasswordError = "Password Error";
    }
}
