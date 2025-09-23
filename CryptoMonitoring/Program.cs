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
            Application.Run(new Laptop());

        }

        public static void AchivesOfUsers()
        {
            foreach (User user in users)
            {
                if (user.balance >= 50000 && !achive1)
                {
                    achive1 = true;
                    Laptop laptop = new Laptop();
                    if (laptop != null && !laptop.IsDisposed)
                    {
                        MessageBox.Show("Хороший капітал!", "Ви отримали досягнення 'Хороший капітал'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    AchiveMents achiveMents = new AchiveMents();
                    achiveMents.Show();
                }
                if (user.cryptos.Count >= 1 && !achive2)
                {
                    achive2 = true;
                    // хелпанеш бо я не шарю як в тебе працює
                    //Laptop laptop = new Laptop();
                    //if (laptop != null && !laptop.IsDisposed)
                    //{
                    //    MessageBox.Show("Перша крипта!", "Ви отримали досягнення 'Перша крипта'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //AchiveMents achiveMents = new AchiveMents();
                    //achiveMents.Show();
                }
                foreach (Crypto crypto in user.cryptos)
                {
                    if (crypto.name == "Bitcoin" && !achive3)
                    {
                        achive3 = true;
                        Laptop laptop = new Laptop();
                        if (laptop != null && !laptop.IsDisposed)
                        {
                            MessageBox.Show("Мрія зробити це в 2012 році!", "Ви отримали досягнення 'Мрія зробити це в 2012 році'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        AchiveMents achiveMents = new AchiveMents();
                        achiveMents.Show();
                    }
                    if (crypto.name == "Ethereum" && !achive4)
                    {
                        achive4 = true;
                        Laptop laptop = new Laptop();
                        if (laptop != null && !laptop.IsDisposed)
                        {
                            MessageBox.Show("Мрія здійснилась!", "Ви отримали досягнення 'Мрія здійснилась'!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        AchiveMents achiveMents = new AchiveMents();
                        achiveMents.Show();
                    }
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