using System.Web;
using System.Web.Optimization;

namespace thousand
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            // Datatables grid
            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Scriptsy/jquery.dataTables.js",
                        "~/Scripts/dataTables.responsive.min.js",
                        "~/Scripts/sb-admin-2.js"));

            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                      "~/Content/jquery.dataTables.min.css",
                      //"~/Content/ThirdParty/responsive.dataTables.min.css",
                      "~/Content/dataTables.bootstrap.min.css",
                      "~/Content/sb-admin-2.css"));
        }
    }
}
