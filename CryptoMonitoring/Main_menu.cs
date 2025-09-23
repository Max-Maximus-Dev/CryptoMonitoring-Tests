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
        public Main_menu()
        {
            InitializeComponent();
            Program.AchivesOfUsers();
            СryptoUC = new cryptoUC();
            crypto_list_panel.Controls.Add(СryptoUC);
            foreach(Crypto crypto in Program.users[Program.currentUserIndex].cryptos)
            {
                СryptoUC.AddCryptoButton(crypto.name);
            }
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            balance.Text = $"{Program.users[Program.currentUserIndex].balance} $";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_crypto_form add_Crypto_Form = new Add_crypto_form(СryptoUC);
            add_Crypto_Form.Show();
        }
    }
}
