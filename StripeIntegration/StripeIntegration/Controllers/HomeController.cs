using System.Web.Mvc;
using StripeIntegration.Models.ViewModels;
using StripeIntegration.Services;
using Stripe;
using System.Collections.Generic;

namespace StripeIntegration.Controllers
{
    public class HomeController : Controller
    {
        private IEnumerable<StripeCharge> GetTransactions()
        {
            return new StripeChargeService(AppConfig.stripePrivateKey).List();
        }

        [HttpGet]
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.transactions = GetTransactions();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel model)
        {

            // Stripe charge logic
            StripeChargeService chargeService = new StripeChargeService(AppConfig.stripePrivateKey);
            StripeChargeCreateOptions myCharge = new StripeChargeCreateOptions()
            {
                Currency = "aud",
                Description = "Product x",
                Amount = model.cardDetails.price,
                Source = new StripeSourceOptions()
                {
                    TokenId = model.cardDetails.stripeToken
                }
            };
            StripeCharge stripeCharge = chargeService.Create(myCharge);

            model.transactions = GetTransactions();

            return View(model);
        }
    }
}