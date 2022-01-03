using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Authorisation
{
    public class Operations
    {
        public class Constants
        {
            public static readonly string CreateOperationName = "Create";
            public static readonly string ReadOperationName = "Read";
            public static readonly string UpdateOperationName = "Update";
            public static readonly string DeleteOperationName = "Delete";
            public static readonly string ApproveOperationName = "Approve";
            public static readonly string RejectOperationName = "Reject";

            public static readonly string AdministratorsRole ="Адміністратор";
            public static readonly string StewardsRole = "Завгосп";
            public static readonly string TeachersRole = "Вчитель";
            public static readonly string LibrariansRole = "Бібліотекар";
            public static readonly string ParentsRole = "Батьки";
        }
    }
}
