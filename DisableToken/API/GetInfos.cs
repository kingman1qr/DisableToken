using System;
using System.Net.Http;
using Newtonsoft.Json;


namespace DisableToken.API
{
    class GetInfos
    {
        public static bool NotValid = false;
        public static string Email;
        public static string Username;
        public static string Verified;
        public static string Phone;
        public static string Discriminator;
        public static string Avatar;
        public static string UserID;
        public static string Locale;

        static string Check(dynamic _User)
        {
            if (_User.verified == true)
            {
                string Checked1 = "Verified";
                return Checked1;
            }
            else
            {
                string Checked2 = "Not Verified";
                return Checked2;
            }
        }

        internal static dynamic Get(HttpClient client)
        {
            try
            {
                return JsonConvert.DeserializeObject<dynamic>(client.GetStringAsync("https://discordapp.com/api/v8/users/@me").Result);
            }
            catch
            {
                return 1;
            }
        }

        internal static void GetClient(HttpClient client)
        {
            try
            {
                dynamic _User = JsonConvert.DeserializeObject<dynamic>(client.GetStringAsync("https://discordapp.com/api/v8/users/@me").Result);
                Email = _User.email;
                Username = _User.username;
                Verified = Check(_User);
                Phone = _User.phone;
                Discriminator = _User.discriminator;
                Avatar = _User.avatar;
                UserID = _User.id;
                Locale = _User.locale;
                NotValid = false;
                Console.WriteLine($"Info: {_User}");
            }
            catch (Exception ex)
            {
                NotValid = true;
                Email = "N/A";
                Username = "N/A";
                Verified = "N/A";
                Phone = "N/A";
                Discriminator = "N/A";
                Avatar = "N/A";
                UserID = "N/A";
                Console.WriteLine($"Exception: {ex}");
            }
        }
    }
}
