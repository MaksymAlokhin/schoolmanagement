using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Pages
{
    public class NavPages
    {
        public static string Admin => "Admin";

        public static string Steward => "Steward";

        public static string Teacher => "Teacher";

        public static string Librarian => "Librarian";

        public static string Parent => "Parent";

        public static string AdminNavClass(ViewContext viewContext) => PageNavClass(viewContext, Admin);

        public static string StewardNavClass(ViewContext viewContext) => PageNavClass(viewContext, Steward);

        public static string TeacherNavClass(ViewContext viewContext) => PageNavClass(viewContext, Teacher);

        public static string LibrarianNavClass(ViewContext viewContext) => PageNavClass(viewContext, Librarian);

        public static string ParentNavClass(ViewContext viewContext) => PageNavClass(viewContext, Parent);

        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }

    }
}
