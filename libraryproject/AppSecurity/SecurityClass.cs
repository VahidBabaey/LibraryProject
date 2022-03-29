using libraryproject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppSecurity
{
    public static class SecurityClass
    {
        public static User UserOnline { get; private set; }
        public static DateTime LoginTime { get; private set; }
        public static bool IsAuthenticated { get; private set; }

        public static string NewPassword { get; private set; }
        public static void CheckAuthenticate(string UserName, string Password)
        {
            LoginTime = DateTime.Now;
            IsAuthenticated = false;
            //Password = Hash(Password, new MD5CryptoServiceProvider());
            UserOnline = DbCommon.Context.Users.SingleOrDefault(p => p.UserName == UserName && p.Password == Password);
            if (UserOnline == null)
                throw new Exception(" کلمه کاربری یا رمز عبور اشتباست ");

            IsAuthenticated = true;
        }
        public static bool CheckAuthorizeOnlineUser(int RoleID)
        {
            return UserOnline.Roles.Any(p => p.ID == RoleID);
        }
        public static List<User> GetUsers()
        {
           return DbCommon.Context.Users.ToList();
        }
        public static void RegisterUser(string Name, long Tel, long Mobile, string Email, string UserName, string Address)
        {
            User _user = new User();
            Random r = new Random();
            int _pass = r.Next(100, 999);
            _user.FullName = Name;
            _user.Tel = Tel;
            _user.Mobile = Mobile;
            _user.Email = Email;
            _user.UserName = UserName;
            _user.Address = Address;
            _user.Password = _pass.ToString();
            DbCommon.Context.Users.Add(_user);
            DbCommon.Context.SaveChanges();

        }
        public static List<Role> GetRoles()
        {
             return DbCommon.Context.Roles.ToList();
        }
        public static bool GetRolesOfUser(int userid,int roleid)
        {
            return DbCommon.Context.Users.SingleOrDefault(p => p.ID == userid).Roles.Any(p => p.ID == roleid);
        }
        public static void DedicateRolesForUser(int userid, List<int> rolesid)
        {
            User _user = DbCommon.Context.Users.SingleOrDefault(p => p.ID == userid);
            _user.Roles.Clear();
            foreach (var item in rolesid)
            {
                var role = DbCommon.Context.Roles.Find(item);
                _user.Roles.Add(role);
            }
            DbCommon.Save();
        }
        public static string Hash(string str, HashAlgorithm alg)
        {
            var buffer = alg.ComputeHash(UTF8Encoding.UTF8.GetBytes(str));
            return Convert.ToBase64String(buffer);
        }


    }
}
