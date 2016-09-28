using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiEnumsValuesDemo
{
    public enum AddressType
    {
        Physical,
        Mailing,
        Shipping
    }

    public enum AccessLevel
    {
        Administrator,
        ReadWrite,
        ReadOnly
    }
}