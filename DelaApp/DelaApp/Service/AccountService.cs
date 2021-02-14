using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DelaApp.Entity;

namespace DelaApp.Service
{
    public static class Account
    {
        public static bool SearchAccount(string user, string password)
        {
            var mainUser = new Models.Account();
            using (var context = new DelaDB())
            {
                mainUser = (from account in context.Accounts
                            where account.Username == user && account.Password == password
                            select account).FirstOrDefault();
            }
            if(mainUser != null && user == mainUser.Username && password == mainUser.Password)
            {
                return true;
            }
            return false;
        }
    }
}