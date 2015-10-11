using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stripe;

namespace StripeIntegration.Models.ViewModels
{
    public class HomeViewModel
    {
        public CardDetails cardDetails { get; set; }
        public IEnumerable<StripeCharge> transactions { get; set; }
        
    }

    public class CardDetails
    {
        public string CardHolderName { get; set; }
        public int price { get; set; }
        public string stripeToken { get; set; }
    }

    

}