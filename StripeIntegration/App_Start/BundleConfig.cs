using System.Web.Optimization;

namespace StripeIntegration
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/common.js"));



            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/themes/base/*.css"));



        //bundles.Add(new ScriptBundle("~/Scripts/knockout").Include(
        //     "~/Scripts/Lib/knockout/knockout-{version}.js",
        //     "~/Scripts/Lib/knockout/knockout-deferred-updates.js")
        //);



            BundleTable.EnableOptimizations = true;
        }
    }
}
