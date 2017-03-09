﻿using System.Web;
using System.Web.Optimization;

namespace MVCKendoBootstrap
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jQuery/jquery-1.11.3.min.js",
                        "~/Scripts/jQuery/jquery-migrate-1.2.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jQuery/jquery.unobtrusive.min.js",
                        "~/Scripts/jQuery/jquery.validate.min.js",
                        "~/Scripts/jQuery/jquery.mask.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/kendo2015Q2/kendo.all.min.js",
                //"~/Scripts/kendo/kendo.web.min.js.map",
                        "~/Scripts/kendo2015Q2/kendo.timezones.min.js", // uncomment if using the Scheduler
                        "~/Scripts/kendo2015Q2/kendo.aspnetmvc.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/template").Include(
                        "~/Scripts/template/ResponsiveTemplate.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/site.css",
                        "~/Content/template/Navigation.css",
                        "~/Content/template/Header.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                   "~/Content/kendo2015Q2/kendo.common.min.css",
                   "~/Content/kendo2015Q2/kendo.common-bootstrap.min.css",
                   "~/Content/kendo2015Q2/kendo.default.min.css",
                   "~/Content/kendo2015Q2/kendo.dataviz.min.css",
                   "~/Content/kendo2015Q2/kendo.dataviz.default.min.css",
                   "~/Content/kendo2015Q2/kendo.bootstrap.min.css",
                   "~/Content/kendo2015Q2/kendo.mobile.all.min.css",
                   "~/Content/kendo2015Q2/kendo.rtl.min.css",
                   "~/Content/kendo2015Q2/kendo.metro.min.css"));

            bundles.IgnoreList.Clear();
        }
    }
}