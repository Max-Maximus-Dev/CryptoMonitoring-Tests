namespace CryptoMonitoring
{
    partial class Main_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            logo = new Button();
            balance = new Label();
            button1 = new Button();
            crypto_list_panel = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.FlatStyle = FlatStyle.Popup;
            logo.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logo.ForeColor = Color.Lime;
            logo.Image = Properties.Resources.banan_logo_img;
            logo.ImageAlign = ContentAlignment.MiddleLeft;
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(262, 103);
            logo.TabIndex = 3;
            logo.Text = "BANAN";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balance.ForeColor = Color.Lime;
            balance.Location = new Point(851, 54);
            balance.Name = "balance";
            balance.Size = new Size(31, 32);
            balance.TabIndex = 4;
            balance.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(12, 150);
            button1.Name = "button1";
            button1.Size = new Size(945, 43);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // crypto_list_panel
            // 
            crypto_list_panel.Location = new Point(12, 199);
            crypto_list_panel.Name = "crypto_list_panel";
            crypto_list_panel.Size = new Size(945, 284);
            crypto_list_panel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.purse_img1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(775, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 80);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.BackgroundImage = Properties.Resources.profile_img;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(280, 27);
            button2.Name = "button2";
            button2.Size = new Size(91, 84);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(408, 27);
            button3.Name = "button3";
            button3.Size = new Size(91, 84);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(521, 31);
            button4.Name = "button4";
            button4.Size = new Size(91, 84);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(645, 32);
            button5.Name = "button5";
            button5.Size = new Size(91, 84);
            button5.TabIndex = 11;
            button5.UseVisualStyleBackColor = false;
            // 
            // Main_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(969, 495);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(crypto_list_panel);
            Controls.Add(button1);
            Controls.Add(balance);
            Controls.Add(logo);
            Name = "Main_menu";
            Text = "Main_menu";
            Load += Main_menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logo;
        private Label balance;
        private Button button1;
        private Panel crypto_list_panel;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}