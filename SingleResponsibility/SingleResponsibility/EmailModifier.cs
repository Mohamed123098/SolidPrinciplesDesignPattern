using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleReposibility
{
    public class EmailModifier
    {
        public static string ModifyEmail(string updatedEmail)
            => $"this is final version : {updatedEmail}";
    }
}
