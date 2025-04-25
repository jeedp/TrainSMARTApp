using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace TrainSMARTApp
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Returns true if the input string is a well-formed email address.
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Quick check: use MailAddress
            try
            {
                var addr = new MailAddress(email);
                // Ensure no invalid characters or missing parts
                if (addr.Address != email.Trim())
                    return false;
            }
            catch
            {
                return false;
            }

            // Optional second check with a regex for stricter rules:
            // (local-part@domain.tld, no spaces, valid characters, TLD ≥ 2 chars)
            const string pattern = @"^[A-Za-z0-9]+([._%+-]?[A-Za-z0-9\-]+)*@[A-Za-z0-9]+([.-]?[A-Za-z0-9\-]+)*\.[A-Za-z]{2,}$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}
