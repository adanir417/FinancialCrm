using FinancialCrm.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm
{
    public class UserManager
    {
        CryptoManager cryptoManager = new CryptoManager();
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public bool CheckLogin(string userName, string password, out string errorMessage)
        {
            var dbUser = db.Users.Where(x => x.Username == userName).FirstOrDefault();

            errorMessage = "";
            if (dbUser == null)
            {
                errorMessage = "Kullanıcı bulunamadı";
                return false;
            }
            byte[] hashedPassword = cryptoManager.ConvertStringToBase64(dbUser.HashedPassword);
            byte[] hashedSalt = cryptoManager.ConvertStringToBase64(dbUser.Salt);

            byte[] hashedNewPassword = cryptoManager.ConvertStringToBase64(cryptoManager.HashPassword(password, hashedSalt));

            var checkPassEquality = cryptoManager.ComparePasswordByteArray(hashedPassword, hashedNewPassword);

            if (checkPassEquality != true)
            {
                errorMessage = "Şifre yanlış";
            }
            return checkPassEquality;

        }

        public bool RegisterUser(string userName, string password) {

            try
            {
                var salt = cryptoManager.GenerateSalt();
                db.Users.Add(new Users
                {
                    Username = userName,
                    HashedPassword = cryptoManager.HashPassword(password, salt),
                    Salt = cryptoManager.ConvertBase64ToString(salt)
                });
                db.SaveChanges();
            return true;
            }
            catch(Exception e) { return false; }
        }

        public bool DeleteUser(int id) {
            try { 
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch(Exception e) { return false; }
        
        }

    }
}
