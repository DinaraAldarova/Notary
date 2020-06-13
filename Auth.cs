using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Нотариус
{
    public class Auth
    {
        public enum UserType : ushort
        {
            Admin = 0,
            User = 1,
            None = 2,
        }

        public UserType userType = UserType.None;

        private Dictionary<string, string> users;

        public Auth()
        {
        }

        public Auth(string login, string password)
        {
            users = new Dictionary<string, string>();
            users.Add("admin", "㏐⫢䣣떮སᓂ蔵䴌鞩");
            users.Add("user", "�澩⃬㕙ꭦ極餬奉㍨즭");

            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] bytePassword = Encoding.ASCII.GetBytes(password);
            byte[] hashPassword = sha.ComputeHash(bytePassword);

            if (users.ContainsKey(login))
            {
                if (Encoding.Unicode.GetString(hashPassword) == users[login])
                {
                    if (login == "admin")
                        userType = UserType.Admin;
                    else if (login == "user")
                        userType = UserType.User;
                    else
                        userType = UserType.None;
                }
            }
            else
                userType = UserType.None;
        }
    }
}