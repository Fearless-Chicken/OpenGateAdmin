using System.Collections.Generic;
using System.Text;
using BCrypt.Net;
using System;

namespace OpenGate.Utils
{
    internal class HashUtils
    {
        public static string HashPASSWD(string passwd)
        {
            return BCrypt.Net.BCrypt.HashPassword(passwd);
        }

        public static bool verifyPASSWD(string passwd, string hashedpasswd)
        {
            return BCrypt.Net.BCrypt.Verify(passwd, hashedpasswd);
        }
    }
}
