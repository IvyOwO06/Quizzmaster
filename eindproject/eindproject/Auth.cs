using Microsoft.AspNetCore.Identity;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eindproject
{
    internal class Auth
    {
        DatabaseHandler databaseHandler = null;
        User user = null;
        DataTable dataTable = null;

        string hashedPassword = "";

        public bool Register(string username, string password, string cpassword, int isAdmin)
        {
            databaseHandler = new DatabaseHandler();
            dataTable = new DataTable();
            if (username == "" || password == "" || cpassword == "")
            {
                MessageBox.Show("Missing information", "Error");
                return false;
            } 
            else
            {

                databaseHandler.FillDataTable("SELECT * FROM users WHERE username='" + username + "'");

                dataTable = databaseHandler.GetDataTable();
                
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Username already exists", "Error");
                    return false;
                }

                if (password == cpassword)
                {
                    hashedPassword = PasswordHasher(password);

                    string query = "INSERT INTO users (username, password, isAdmin) VALUES ('" + username + "', '" + hashedPassword + "', '" + isAdmin + "')";

                    databaseHandler.ExecuteQuery(query);

                    MessageBox.Show("Signup successful", "Success");
                    return true;
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Error");
                    return false;
                }
            }
        }

        private string PasswordHasher(string password)
        {
            //initializes the hasher
            var hasher = new PasswordHasher<string>();

            // hashes the password
            var hash = hasher.HashPassword(null, password);

            return hash;
        }

        public bool Login(string username, string password)
        {
            databaseHandler = new DatabaseHandler();

            databaseHandler.FillDataTable("SELECT * FROM users WHERE username ='" + username + "'");
            dataTable = databaseHandler.GetDataTable();

            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("Username or password is invalid", "Error");
                return false;
            }

            string storedHash = dataTable.Rows[0]["password"].ToString();

            // verify password
            var hasher = new PasswordHasher<string>();

            var result = hasher.VerifyHashedPassword(null, storedHash, password);

            if (result == PasswordVerificationResult.Success)
            {
                string storedUsername = dataTable.Rows[0]["username"].ToString();
                bool isAdmin = Convert.ToInt32(dataTable.Rows[0]["isAdmin"]) == 1;
                int userId = Convert.ToInt32(dataTable.Rows[0]["userId"]);
                user = new User(storedUsername, isAdmin, userId);

                return true;
            }
            else if (result == PasswordVerificationResult.SuccessRehashNeeded)
            {
                var newHash = PasswordHasher(password);

                databaseHandler.ExecuteQuery("UPDATE users SET password = '" + newHash + "' WHERE username = '" + username + "'");

                string storedUsername = dataTable.Rows[0]["username"].ToString();
                bool isAdmin = Convert.ToInt32(dataTable.Rows[0]["isAdmin"]) == 1;
                int userId = Convert.ToInt32(dataTable.Rows[0]["userId"]);
                user = new User(storedUsername, isAdmin, userId);

                MessageBox.Show("Login was successful", "Success");
                return true;
            }
            else
            {
                MessageBox.Show("Username or password is invalid", "Error");
                return false;
            }
        }
        public User GetLoggedInUser()
        {
            return user;
        }
    }
}
