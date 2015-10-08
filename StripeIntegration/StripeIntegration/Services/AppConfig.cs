using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StripeIntegration.Services
{
    public static class AppConfig
    {
        // Private Properties
        private static string _stripePublicKey { get { return "pk_test_iyziHUJG2IbuEnbyIKY5wcwg"; } }
        private static string _stripePrivateKey { get { return "sk_test_bnC1Dc0mj9ifRRFRK1pJ9xmB"; } }
        // Public Properties
        public static string stripePublicKey { get { return _stripePublicKey; } }
        public static string stripePrivateKey { get { return _stripePrivateKey; } }
    }
}