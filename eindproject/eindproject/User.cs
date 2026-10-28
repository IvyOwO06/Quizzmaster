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
        int userId = 0;

        public User(string c_username, bool c_isAdmin, int c_userId)
        {
            username = c_username;
            isAdmin = c_isAdmin;
            userId = c_userId;
        }

        public string GetUsername()
        {
            return username;
        }

        public bool GetIsAdmin()
        {
            return isAdmin;
        }

        public int GetUserId()
        {
            return userId;
        }
    }
}
