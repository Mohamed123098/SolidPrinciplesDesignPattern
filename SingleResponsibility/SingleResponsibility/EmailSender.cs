using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleReposibility
{
    public static class EmailSender
    {
        public static string SendEmail(string email)
            => $"Email [{email}] is Sent successfully";
    }
}
