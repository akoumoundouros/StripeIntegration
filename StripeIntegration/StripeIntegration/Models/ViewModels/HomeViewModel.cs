using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StripeIntegration.Models.ViewModels
{
    public class HomeViewModel
    {
        public string CardHolderName { get; set; }
        public int price { get; set; }
        public string stripeToken { get; set; }
        
    }
}