using System;

namespace GymMaster.Models
{
    public class AuthManager
    {
        private readonly string _adminUser = "admin";
        private readonly string _adminPass = "admin123";

        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            return username == _adminUser && password == _adminPass;
        }
    }
}