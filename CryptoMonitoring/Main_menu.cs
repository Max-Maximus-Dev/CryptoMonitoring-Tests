using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMonitoring
{
    public partial class Main_menu : Form
    {
        cryptoUC СryptoUC;
        bool first_open_panel1 = true;
        bool is_some_menu_opem = false;
        public Main_menu()
        {
            InitializeComponent();
            Program.AchivesOfUsers();
            СryptoUC = new cryptoUC();
            crypto_list_panel.Controls.Add(СryptoUC);
            foreach (Crypto crypto in Program.users[Program.currentUserIndex].cryptos)
            {
                СryptoUC.AddCryptoButton(crypto.name);
            }
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            balance.Text = $"{Program.users[Program.currentUserIndex].balance} $";
            User user = Program.users[Program.currentUserIndex];
            if (user.avatar_id == 0)
            {
                button2.BackgroundImage = Properties.Resources.profile_img;
                change_avatar_button.BackgroundImage = Properties.Resources.profile_img;
            }
            else if (user.avatar_id == 1)
            {
                button2.BackgroundImage = Properties.Resources.dollar_logo;
                change_avatar_button.BackgroundImage = Properties.Resources.dollar_logo;
            }
            else if (user.avatar_id == 2)
            {
                button2.BackgroundImage = Properties.Resources.binance_coin_avatar;
                change_avatar_button.BackgroundImage = Properties.Resources.binance_coin_avatar;
            }
            else if (user.avatar_id == 3)
            {
                button2.BackgroundImage = Properties.Resources.laptop_right_avatr;
                change_avatar_button.BackgroundImage = Properties.Resources.laptop_right_avatr;
            }
            else if (user.avatar_id == 4)
            {
                button2.BackgroundImage = Properties.Resources.emerald_avatr;
                change_avatar_button.BackgroundImage = Properties.Resources.emerald_avatr;
            }
            else if (user.avatar_id == 5)
            {
                button2.BackgroundImage = Properties.Resources.laptop_avatar;
                change_avatar_button.BackgroundImage = Properties.Resources.laptop_avatar;
            }
            else if (user.avatar_id == 6)
            {
                button2.BackgroundImage = Properties.Resources.computer_avatr;
                change_avatar_button.BackgroundImage = Properties.Resources.computer_avatr;
            }
            else if (user.avatar_id == 7)
            {
                button2.BackgroundImage = Properties.Resources.gold_avatar;
                change_avatar_button.BackgroundImage = Properties.Resources.gold_avatar;
            }
            else if (user.avatar_id == 8)
            {
                button2.BackgroundImage = Properties.Resources.cup_avatar;
                change_avatar_button.BackgroundImage = Properties.Resources.cup_avatar;
            }
            else if (user.avatar_id == 9)
            {
                button2.BackgroundImage = Properties.Resources.upstat_avatar;
                change_avatar_button.BackgroundImage = Properties.Resources.upstat_avatar;
            }
            else if (user.avatar_id == 10)
            {
                button2.BackgroundImage = Properties.Resources.coins_avatar1;
                change_avatar_button.BackgroundImage = Properties.Resources.coins_avatar1;
            }
            else if (user.avatar_id == 11)
            {
                button2.BackgroundImage = Properties.Resources.coin_avatar;
                change_avatar_button.BackgroundImage = Properties.Resources.coin_avatar;
            }
            else if (user.avatar_id == 12)
            {
                button2.BackgroundImage = Properties.Resources.hacker_avatar;
                change_avatar_button.BackgroundImage = Properties.Resources.hacker_avatar;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_crypto_form add_Crypto_Form = new Add_crypto_form(СryptoUC);
            add_Crypto_Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AchiveMents achiveMents = new AchiveMents();
            achiveMents.Show();
        }

        private void crypto_list_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Location - 374; 77
            // Size - 625; 357
            User user = Program.users[Program.currentUserIndex];
            username_label.Text = user.username;
            itemail_label.Text = user.email;
            itbalance_label.Text = user.balance.ToString();
            int count_of_achivements = 0;
            for (int i = 0; i < 10; i++)
            {
                if (user.achievements[i])
                {
                    count_of_achivements++;
                }
            }
            label2.Text = count_of_achivements.ToString();

            if (first_open_panel1)
            {
                first_open_panel1 = false;
                //panel1.Location = new Point(374, 0);
                //panel1.Location = new Point(374, 77);
                panelAvatar.Size = new Size(619, 309);
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                first_open_panel1 = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void userrname_label_Click(object sender, EventArgs e)
        {

        }

        private void emaill_label_Click(object sender, EventArgs e)
        {

        }

        private void ballane_lable_Click(object sender, EventArgs e)
        {

        }

        private void achivee_label_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_2(object sender, EventArgs e)
        {

        }

        private void change_avatar_button_Click(object sender, EventArgs e)
        {
            change_avatr_button.Visible = true;
        }
        private void change_avatr_button_Click(object sender, EventArgs e)
        {

        }

        private void button_avatar1_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 1;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.dollar_logo;
            change_avatar_button.BackgroundImage = Properties.Resources.dollar_logo;
            panelAvatar.Visible = false;
        }

        private void button_avatar2_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 2;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.binance_coin_avatar;
            change_avatar_button.BackgroundImage = Properties.Resources.binance_coin_avatar;
            panelAvatar.Visible = false;
        }

        private void button_avatar3_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 3;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.laptop_right_avatr;
            change_avatar_button.BackgroundImage = Properties.Resources.laptop_right_avatr;
            panelAvatar.Visible = false;
        }

        private void button_avatar4_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 4;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.emerald_avatr;
            change_avatar_button.BackgroundImage = Properties.Resources.emerald_avatr;
            panelAvatar.Visible = false;
        }

        private void button_avatar5_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 5;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.laptop_avatar;
            change_avatar_button.BackgroundImage = Properties.Resources.laptop_avatar;
            panelAvatar.Visible = false;
        }

        private void button_avatar6_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 6;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.computer_avatr;
            change_avatar_button.BackgroundImage = Properties.Resources.computer_avatr;
            panelAvatar.Visible = false;
        }

        private void button_avatar7_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 7;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.gold_avatar;
            change_avatar_button.BackgroundImage = Properties.Resources.gold_avatar;
            panelAvatar.Visible = false;
        }

        private void button_avatar8_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 8;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.cup_avatar;
            change_avatar_button.BackgroundImage = Properties.Resources.cup_avatar;
            panelAvatar.Visible = false;
        }

        private void button_avatar9_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 9;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.upstat_avatar;
            change_avatar_button.BackgroundImage = Properties.Resources.upstat_avatar;
            panelAvatar.Visible = false;
        }

        private void button_avatar10_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 10;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.coins_avatar1;
            change_avatar_button.BackgroundImage = Properties.Resources.coins_avatar1;
            panelAvatar.Visible = false;
        }

        private void button_avatar11_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 11;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.coin_avatar;
            change_avatar_button.BackgroundImage = Properties.Resources.coin_avatar;
            panelAvatar.Visible = false;
        }

        private void button_avatar12_Click(object sender, EventArgs e)
        {
            User user = Program.users[Program.currentUserIndex];
            user.avatar_id = 12;
            Program.SerialazeUsers();
            button2.BackgroundImage = Properties.Resources.hacker_avatar;
            change_avatar_button.BackgroundImage = Properties.Resources.hacker_avatar;
            panelAvatar.Visible = false;
        }

        private void change_avatr_button_Click_1(object sender, EventArgs e)
        {
            //panelAvatar.Location = new Point(374, 0);
            panelAvatar.Location = new Point(374, 77);
            panelAvatar.Size = new Size(607, 251);
            panel1.Visible = false;
            panelAvatar.Visible = true;
            first_open_panel1 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLeaders tableLeaders = new tableLeaders();
            tableLeaders.Show();
        }
    }
}
