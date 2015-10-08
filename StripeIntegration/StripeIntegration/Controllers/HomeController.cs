using System.Web.Mvc;
using StripeIntegration.Models.ViewModels;
using StripeIntegration.Services;
using Stripe;

namespace StripeIntegration.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new HomeViewModel());
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel model)
        {
            // Some code to determine price of purchase
            model.price = 100;

            // Stripe charge logic
            StripeChargeService chargeService = new StripeChargeService(AppConfig.stripePrivateKey);
            StripeChargeCreateOptions myCharge = new StripeChargeCreateOptions()
            {
                Currency = "aud",
                Amount = model.price,
                Source = new StripeSourceOptions()
                {
                    TokenId = model.stripeToken
                }
            };
            StripeCharge stripeCharge = chargeService.Create(myCharge);



            return View(model);
        }
    }
}