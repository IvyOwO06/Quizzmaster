using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eindproject
{
    internal class User
    {
        string username = string.Empty;
        bool isAdmin = false;

        public User(string c_username, bool c_isAdmin)
        {
            username = c_username;
            isAdmin = c_isAdmin;
        }

        public string GetUsername()
        {
            return username;
        }

        public bool GetIsAdmin()
        {
            return isAdmin;
        }

        
    }
}
