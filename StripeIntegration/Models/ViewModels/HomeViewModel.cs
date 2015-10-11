using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stripe;
using StripeIntegration.Data;
using System.Data.Entity;
using System.Linq;

namespace StripeIntegration.Models.ViewModels
{
    public class HomeViewModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public HomeViewModel()
        {
            products = GetProducts();
            cardDetails = new CardDetails()
            {
                CardHolderName = "E. Alderson",
                price = 100 // price in cents
            };
        }
        private SIDBEntities db = new SIDBEntities();
        private List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
        public CardDetails cardDetails { get; set; }
        public IEnumerable<StripeCharge> transactions { get; set; }
        public List<Product> products { get; set; }
    }

    public class CardDetails
    {
        public string CardHolderName { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public string stripeToken { get; set; }
    }

    

}