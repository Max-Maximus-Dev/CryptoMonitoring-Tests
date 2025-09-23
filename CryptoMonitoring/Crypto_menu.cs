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
    public partial class Crypto_menu : Form
    {
        private string cryptoName;
        public Crypto_menu(string cryptoName)
        {
            InitializeComponent();
            Program.AchivesOfUsers();
            this.cryptoName = cryptoName;
        }

        private void Crypto_menu_Load(object sender, EventArgs e)
        {

        }

        private void button_graphic_Click(object sender, EventArgs e)
        {
            Graphic graphic = new Graphic(cryptoName);
            graphic.Show();
        }
    }
}
