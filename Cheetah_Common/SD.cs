﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_Common
{
    public static class SD
    {
        public const string ShoppingCart = "ShoppingCart";
        public const string Status_Pending = "Pending";
        public const string Status_Confirmed = "Confirmed";
        public const string Status_Shipped = "Shipped";
        public const string Status_Refunded = "Refunded";
        public const string Status_Cancelled = "Cancelled";

        public const string Role_Admin = "Admin";
        public const string Role_Customer = "Customer";

        public const string Local_Token = "JWT Token";
        public const string Local_OrderDetails = "Local_OrderDetails";
        public const string Local_UserDetails = "UserDetails";

        public const string First = "First";
        public const string Second = "Second";

        public enum TableType
        {
            Dimentions,
            Links,
            Facts
        }

    }
    public enum FieldType
    {
        CInt,
        CNInt,
        CString,
        CBool
    }
}
