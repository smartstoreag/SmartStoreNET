﻿using SmartStore.Web.Framework.Mvc;

namespace SmartStore.Web.Models.Checkout
{
    public partial class CheckoutProgressModel : ModelBase
    {
        public CheckoutProgressStep CheckoutProgressStep { get; set; }
    }

    public enum CheckoutProgressStep
    {
        Cart,
        Address,
        Shipping,
        Payment,
        Confirm,
        Complete
    }
}