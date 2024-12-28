using System;

namespace BasicAuth
{
    public class ValidateUser
    {
        public static bool Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
