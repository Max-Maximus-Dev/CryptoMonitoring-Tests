using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CryptoMonitoring
{
    internal static class Program
    {
        static public bool achive1 = false;
        static public bool achive2 = false;
        static public bool achive3 = false;
        static public bool achive4 = false;
        public static List<User> users;
        public static int currentUserIndex;
        [STAThread]
        static void Main()
        {
            users = new List<User>();
            DeserialazeUsers();
            AchivesOfUsers();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }

        public static void AchivesOfUsers()
        {
            User currentUser = users[currentUserIndex];
            if (currentUser.balance >= 50000)
            {
                achive1 = true;
            }
            if (currentUser.cryptos.Count >= 1)
            {
                achive2 = true;
                foreach (Crypto crypto in currentUser.cryptos)
                {
                    if (crypto.name == "Bitcoin")
                        achive3 = true;
                    if (crypto.name == "Ethereum")
                        achive4 = true;
                }
            }
        }

        public static void SerialazeUsers()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            using (StreamWriter sw = new StreamWriter("users.json"))
            {
                sw.WriteLine(json);
            }
        }

        public static void DeserialazeUsers()
        {
            if (File.Exists("users.json"))
            {
                using (StreamReader sr = new StreamReader("users.json"))
                {
                    string json = sr.ReadToEnd();
                    users = JsonSerializer.Deserialize<List<User>>(json);
                }
            }
        }
    }
}