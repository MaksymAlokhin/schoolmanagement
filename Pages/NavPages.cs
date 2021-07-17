using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Pages
{
    public class NavPages
    {
        public static string Admin => "Адміністратор";
        public static string Roles => "Повноваження";
        public static string Steward => "Завгосп";
        public static string Teacher => "Вчитель";
        public static string Librarian => "Бібліотекар";
        public static string Parent => "Батьки";

        public static string AdminNavClass(ViewContext viewContext) => PageNavClass(viewContext, Admin);
        public static string RolesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Roles);
        public static string StewardNavClass(ViewContext viewContext) => PageNavClass(viewContext, Steward);
        public static string TeacherNavClass(ViewContext viewContext) => PageNavClass(viewContext, Teacher);
        public static string LibrarianNavClass(ViewContext viewContext) => PageNavClass(viewContext, Librarian);
        public static string ParentNavClass(ViewContext viewContext) => PageNavClass(viewContext, Parent);


        public static string AdminNavClassShow(ViewContext viewContext) => PageNavClassShow(viewContext, Admin);
        public static string RolesNavClassShow(ViewContext viewContext) => PageNavClassShow(viewContext, Roles); 
        public static string StewardNavClassShow(ViewContext viewContext) => PageNavClassShow(viewContext, Steward);
        public static string TeacherNavClassShow(ViewContext viewContext) => PageNavClassShow(viewContext, Teacher);
        public static string LibrarianNavClassShow(ViewContext viewContext) => PageNavClassShow(viewContext, Librarian);
        public static string ParentNavClassShow(ViewContext viewContext) => PageNavClassShow(viewContext, Parent);


        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }

        private static string PageNavClassShow(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "show" : null;
        }
        //private static string PageNavClassCollapse(ViewContext viewContext, string page)
        //{
        //    var activePage = viewContext.ViewData["ActivePage"] as string
        //        ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
        //    return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? null : "collapsed";
        //}
    }
}
