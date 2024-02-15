using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome
{
    public class SigIn
    {
        public string Authentication(string username, string password)
        {
            string msg = "";
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "UserName and password reqired";
            }
            else
            {
                if (username == "Suresh" && password == "Suresh@123")
                {
                    msg = "Authendtication success";
                }
                else
                {
                    msg = "Authentication failed";
                }
            }
            return msg;
        }
    }
}
