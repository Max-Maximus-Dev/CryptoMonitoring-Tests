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
    public partial class AchiveMents : Form
    {
        public AchiveMents()
        {
            InitializeComponent();
            Program.AchivesOfUsers();
        }

        private void AchiveMents_Load(object sender, EventArgs e)
        {
            // Досягнення
            // Хороший капітал - нафармити 50.000$
            // Перша крипта - купити першу криптовалюту
            // Мрія зробити це в 2012 році - купити Bitcoin
            // Мрія здійснилась - купити Ethereum
            // Майнер - купити перший майнер
            if (Program.achive1)
            {
                pictureBox5.Image = Properties.Resources.approved;
                pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (Program.achive2)
            {
                pictureBox6.Image = Properties.Resources.approved;
                pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (Program.achive3)
            {
                pictureBox7.Image = Properties.Resources.approved;
                pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (Program.achive4)
            {
                pictureBox8.Image = Properties.Resources.approved;
                pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
