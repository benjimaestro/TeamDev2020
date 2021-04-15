using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using ClassLibrary;
using System.Security.Cryptography;

namespace ClassLibrary
{
    public abstract class clsAbstractUser
    {
        protected Int32 mID;
        protected string mEmail;
        protected string mFirstName;
        protected string mLastName;
        public int ID
        {
            get { return mID; }
            set { mID = value; }
        }
        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }

        public string GetHashPassword(string ToHash)
        {
            //Generates a SHA512 hash of a given password
            //SHA512 is used here because it is the best hashing algorithm the System.Security.Cryptography provides
            //In real world use, a better hashing algorithm would be used, like SHA3

            if (ToHash != "")
            {
                SHA512Managed HashGen = new SHA512Managed();
                string HashString;
                byte[] TextBytes;
                byte[] HashBytes;

                TextBytes = System.Text.Encoding.UTF8.GetBytes(ToHash);
                HashBytes = HashGen.ComputeHash(TextBytes);
                HashString = BitConverter.ToString(HashBytes).Replace("-", "");
                return HashString;
            }
            else { return ""; }
        }

        public string SendResetEmail(string System)
        {
            //This function checks which system it is being called for, and changes the specified user's password
            //To a randomised code. This code is emailed to the user, and can be provided as a password change
            //authentication method.
            string Sproc = "";
            string TempPW = "";

            switch (System)
            {
                case "Timetable":
                    Sproc = "sproc_tblUser_ChangePassword";
                    break;
                case "TTrain":
                    Sproc = "";
                    break;
                case "Laptop":
                    Sproc = "";
                    break;
                default:
                    break;
            }

            //educative.io/edpresso/how-to-generate-a-random-string-in-c-sharp
            int length = 7;
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;
            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            //
            TempPW = GetHashPassword(str_build.ToString()).Substring(0, 50); ;

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Email", mEmail);
            DB.AddParameter("@Password", TempPW);
            DB.Execute(Sproc);

            //Finish so it actually sends reset codes
            string Email = "teamdroptable2020@gmail.com";
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(Email, "Teamdroptable123!"),
                EnableSsl = true,
            };

            //Can't do redirects to pages with query strings because it's all localhost, use hash as a code
            smtpClient.Send(Email, mEmail, $"Change password for {System} System", $"Your code is: {TempPW}");

            return TempPW;
        }
    }
}
