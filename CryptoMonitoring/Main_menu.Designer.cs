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
            panelAvatar = new Panel();
            button_avatar12 = new Button();
            button_avatar11 = new Button();
            button_avatar10 = new Button();
            button_avatar9 = new Button();
            button_avatar8 = new Button();
            button_avatar7 = new Button();
            button_avatar6 = new Button();
            button_avatar5 = new Button();
            button_avatar4 = new Button();
            button_avatar3 = new Button();
            button_avatar2 = new Button();
            label4 = new Label();
            button_avatar1 = new Button();
            panel1 = new Panel();
            change_avatr_button = new Button();
            label2 = new Label();
            label3 = new Label();
            itbalance_label = new Label();
            balance_label = new Label();
            itemail_label = new Label();
            email_label = new Label();
            username_label = new Label();
            label1 = new Label();
            change_avatar_button = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panelAvatar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.FlatStyle = FlatStyle.Popup;
            logo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logo.ForeColor = Color.Lime;
            logo.Image = Properties.Resources.banan_logo_img;
            logo.ImageAlign = ContentAlignment.MiddleLeft;
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(314, 103);
            logo.TabIndex = 3;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balance.ForeColor = Color.Lime;
            balance.Location = new Point(1005, 55);
            balance.Name = "balance";
            balance.Size = new Size(30, 32);
            balance.TabIndex = 4;
            balance.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(12, 150);
            button1.Name = "button1";
            button1.Size = new Size(1023, 43);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // crypto_list_panel
            // 
            crypto_list_panel.AutoScroll = true;
            crypto_list_panel.Location = new Point(12, 199);
            crypto_list_panel.Name = "crypto_list_panel";
            crypto_list_panel.Size = new Size(1023, 284);
            crypto_list_panel.TabIndex = 6;
            crypto_list_panel.Paint += crypto_list_panel_Paint;
            // 
            // panelAvatar
            // 
            panelAvatar.Controls.Add(button_avatar12);
            panelAvatar.Controls.Add(button_avatar11);
            panelAvatar.Controls.Add(button_avatar10);
            panelAvatar.Controls.Add(button_avatar9);
            panelAvatar.Controls.Add(button_avatar8);
            panelAvatar.Controls.Add(button_avatar7);
            panelAvatar.Controls.Add(button_avatar6);
            panelAvatar.Controls.Add(button_avatar5);
            panelAvatar.Controls.Add(button_avatar4);
            panelAvatar.Controls.Add(button_avatar3);
            panelAvatar.Controls.Add(button_avatar2);
            panelAvatar.Controls.Add(label4);
            panelAvatar.Controls.Add(button_avatar1);
            panelAvatar.Location = new Point(332, 67);
            panelAvatar.Name = "panelAvatar";
            panelAvatar.Size = new Size(607, 251);
            panelAvatar.TabIndex = 24;
            panelAvatar.Visible = false;
            // 
            // button_avatar12
            // 
            button_avatar12.BackColor = SystemColors.ActiveCaptionText;
            button_avatar12.BackgroundImage = Properties.Resources.hacker_avatar;
            button_avatar12.BackgroundImageLayout = ImageLayout.Stretch;
            button_avatar12.FlatAppearance.BorderSize = 0;
            button_avatar12.FlatStyle = FlatStyle.Popup;
            button_avatar12.Location = new Point(498, 143);
            button_avatar12.Name = "button_avatar12";
            button_avatar12.Size = new Size(104, 100);
            button_avatar12.TabIndex = 12;
            button_avatar12.UseVisualStyleBackColor = false;
            button_avatar12.Click += button_avatar12_Click;
            // 
            // button_avatar11
            // 
            button_avatar11.BackColor = SystemColors.ActiveCaptionText;
            button_avatar11.BackgroundImage = Properties.Resources.coin_avatar;
            button_avatar11.BackgroundImageLayout = ImageLayout.Stretch;
            button_avatar11.FlatAppearance.BorderSize = 0;
            button_avatar11.FlatStyle = FlatStyle.Popup;
            button_avatar11.Location = new Point(399, 143);
            button_avatar11.Name = "button_avatar11";
            button_avatar11.Size = new Size(104, 100);
            button_avatar11.TabIndex = 11;
            button_avatar11.UseVisualStyleBackColor = false;
            button_avatar11.Click += button_avatar11_Click;
            // 
            // button_avatar10
            // 
            button_avatar10.BackColor = SystemColors.ActiveCaptionText;
            button_avatar10.BackgroundImage = Properties.Resources.coins_avatar1;
            button_avatar10.BackgroundImageLayout = ImageLayout.Zoom;
            button_avatar10.FlatAppearance.BorderSize = 0;
            button_avatar10.FlatStyle = FlatStyle.Popup;
            button_avatar10.Location = new Point(300, 143);
            button_avatar10.Name = "button_avatar10";
            button_avatar10.Size = new Size(104, 100);
            button_avatar10.TabIndex = 10;
            button_avatar10.UseVisualStyleBackColor = false;
            button_avatar10.Click += button_avatar10_Click;
            // 
            // button_avatar9
            // 
            button_avatar9.BackColor = SystemColors.ActiveCaptionText;
            button_avatar9.BackgroundImage = Properties.Resources.upstat_avatar1;
            button_avatar9.BackgroundImageLayout = ImageLayout.Stretch;
            button_avatar9.FlatAppearance.BorderSize = 0;
            button_avatar9.FlatStyle = FlatStyle.Popup;
            button_avatar9.Location = new Point(201, 143);
            button_avatar9.Name = "button_avatar9";
            button_avatar9.Size = new Size(104, 100);
            button_avatar9.TabIndex = 9;
            button_avatar9.UseVisualStyleBackColor = false;
            button_avatar9.Click += button_avatar9_Click;
            // 
            // button_avatar8
            // 
            button_avatar8.BackColor = SystemColors.ActiveCaptionText;
            button_avatar8.BackgroundImage = Properties.Resources.cup_avatar;
            button_avatar8.BackgroundImageLayout = ImageLayout.Zoom;
            button_avatar8.FlatAppearance.BorderSize = 0;
            button_avatar8.FlatStyle = FlatStyle.Popup;
            button_avatar8.Location = new Point(102, 143);
            button_avatar8.Name = "button_avatar8";
            button_avatar8.Size = new Size(104, 100);
            button_avatar8.TabIndex = 8;
            button_avatar8.UseVisualStyleBackColor = false;
            button_avatar8.Click += button_avatar8_Click;
            // 
            // button_avatar7
            // 
            button_avatar7.BackColor = SystemColors.ActiveCaptionText;
            button_avatar7.BackgroundImage = Properties.Resources.gold_avatar;
            button_avatar7.BackgroundImageLayout = ImageLayout.Zoom;
            button_avatar7.FlatAppearance.BorderSize = 0;
            button_avatar7.FlatStyle = FlatStyle.Popup;
            button_avatar7.Location = new Point(3, 143);
            button_avatar7.Name = "button_avatar7";
            button_avatar7.Size = new Size(104, 100);
            button_avatar7.TabIndex = 7;
            button_avatar7.UseVisualStyleBackColor = false;
            button_avatar7.Click += button_avatar7_Click;
            // 
            // button_avatar6
            // 
            button_avatar6.BackColor = SystemColors.ActiveCaptionText;
            button_avatar6.BackgroundImage = Properties.Resources.computer_avatr;
            button_avatar6.BackgroundImageLayout = ImageLayout.Stretch;
            button_avatar6.FlatAppearance.BorderSize = 0;
            button_avatar6.FlatStyle = FlatStyle.Popup;
            button_avatar6.Location = new Point(498, 45);
            button_avatar6.Name = "button_avatar6";
            button_avatar6.Size = new Size(104, 100);
            button_avatar6.TabIndex = 6;
            button_avatar6.UseVisualStyleBackColor = false;
            button_avatar6.Click += button_avatar6_Click;
            // 
            // button_avatar5
            // 
            button_avatar5.BackColor = SystemColors.ActiveCaptionText;
            button_avatar5.BackgroundImage = Properties.Resources.laptop_avatar;
            button_avatar5.BackgroundImageLayout = ImageLayout.Stretch;
            button_avatar5.FlatAppearance.BorderSize = 0;
            button_avatar5.FlatStyle = FlatStyle.Popup;
            button_avatar5.Location = new Point(399, 45);
            button_avatar5.Name = "button_avatar5";
            button_avatar5.Size = new Size(104, 100);
            button_avatar5.TabIndex = 5;
            button_avatar5.UseVisualStyleBackColor = false;
            button_avatar5.Click += button_avatar5_Click;
            // 
            // button_avatar4
            // 
            button_avatar4.BackColor = SystemColors.ActiveCaptionText;
            button_avatar4.BackgroundImage = Properties.Resources.emerald_avatr;
            button_avatar4.BackgroundImageLayout = ImageLayout.Stretch;
            button_avatar4.FlatAppearance.BorderSize = 0;
            button_avatar4.FlatStyle = FlatStyle.Popup;
            button_avatar4.Location = new Point(300, 45);
            button_avatar4.Name = "button_avatar4";
            button_avatar4.Size = new Size(104, 100);
            button_avatar4.TabIndex = 4;
            button_avatar4.UseVisualStyleBackColor = false;
            button_avatar4.Click += button_avatar4_Click;
            // 
            // button_avatar3
            // 
            button_avatar3.BackColor = SystemColors.ActiveCaptionText;
            button_avatar3.BackgroundImage = Properties.Resources.laptop_right_avatr;
            button_avatar3.BackgroundImageLayout = ImageLayout.Stretch;
            button_avatar3.FlatAppearance.BorderSize = 0;
            button_avatar3.FlatStyle = FlatStyle.Popup;
            button_avatar3.Location = new Point(201, 45);
            button_avatar3.Name = "button_avatar3";
            button_avatar3.Size = new Size(104, 100);
            button_avatar3.TabIndex = 3;
            button_avatar3.UseVisualStyleBackColor = false;
            button_avatar3.Click += button_avatar3_Click;
            // 
            // button_avatar2
            // 
            button_avatar2.BackColor = SystemColors.ActiveCaptionText;
            button_avatar2.BackgroundImage = Properties.Resources.binance_coin_avatar;
            button_avatar2.BackgroundImageLayout = ImageLayout.Zoom;
            button_avatar2.FlatAppearance.BorderSize = 0;
            button_avatar2.FlatStyle = FlatStyle.Popup;
            button_avatar2.Location = new Point(102, 45);
            button_avatar2.Name = "button_avatar2";
            button_avatar2.Size = new Size(104, 100);
            button_avatar2.TabIndex = 2;
            button_avatar2.UseVisualStyleBackColor = false;
            button_avatar2.Click += button_avatar2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic Cyrillic", 19.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 2);
            label4.Name = "label4";
            label4.Size = new Size(570, 40);
            label4.TabIndex = 1;
            label4.Text = "choose avatar for your profile";
            // 
            // button_avatar1
            // 
            button_avatar1.BackColor = SystemColors.ActiveCaptionText;
            button_avatar1.BackgroundImage = Properties.Resources.dollar_logo;
            button_avatar1.BackgroundImageLayout = ImageLayout.Stretch;
            button_avatar1.FlatAppearance.BorderSize = 0;
            button_avatar1.FlatStyle = FlatStyle.Popup;
            button_avatar1.Location = new Point(3, 45);
            button_avatar1.Name = "button_avatar1";
            button_avatar1.Size = new Size(104, 100);
            button_avatar1.TabIndex = 0;
            button_avatar1.UseVisualStyleBackColor = false;
            button_avatar1.Click += button_avatar1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(change_avatr_button);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(itbalance_label);
            panel1.Controls.Add(balance_label);
            panel1.Controls.Add(itemail_label);
            panel1.Controls.Add(email_label);
            panel1.Controls.Add(username_label);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(change_avatar_button);
            panel1.Location = new Point(379, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 309);
            panel1.TabIndex = 13;
            panel1.Visible = false;
            // 
            // change_avatr_button
            // 
            change_avatr_button.BackColor = SystemColors.ActiveCaptionText;
            change_avatr_button.FlatStyle = FlatStyle.Flat;
            change_avatr_button.Font = new Font("Showcard Gothic Cyrillic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            change_avatr_button.ForeColor = Color.White;
            change_avatr_button.Location = new Point(14, 85);
            change_avatr_button.Name = "change_avatr_button";
            change_avatr_button.Size = new Size(140, 29);
            change_avatr_button.TabIndex = 23;
            change_avatr_button.Text = "Change Avatar";
            change_avatr_button.UseVisualStyleBackColor = false;
            change_avatr_button.Visible = false;
            change_avatr_button.Click += change_avatr_button_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic Cyrillic", 19F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(279, 247);
            label2.Name = "label2";
            label2.Size = new Size(36, 40);
            label2.TabIndex = 22;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic Cyrillic", 19F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 247);
            label3.Name = "label3";
            label3.Size = new Size(260, 40);
            label3.TabIndex = 21;
            label3.Text = "achivements - ";
            // 
            // itbalance_label
            // 
            itbalance_label.AutoSize = true;
            itbalance_label.Font = new Font("Showcard Gothic Cyrillic", 19F);
            itbalance_label.ForeColor = Color.White;
            itbalance_label.Location = new Point(200, 183);
            itbalance_label.Name = "itbalance_label";
            itbalance_label.Size = new Size(36, 40);
            itbalance_label.TabIndex = 20;
            itbalance_label.Text = "0";
            itbalance_label.Click += label5_Click;
            // 
            // balance_label
            // 
            balance_label.AutoSize = true;
            balance_label.Font = new Font("Showcard Gothic Cyrillic", 19F);
            balance_label.ForeColor = Color.White;
            balance_label.Location = new Point(33, 183);
            balance_label.Name = "balance_label";
            balance_label.Size = new Size(178, 40);
            balance_label.TabIndex = 19;
            balance_label.Text = "balance - ";
            // 
            // itemail_label
            // 
            itemail_label.AutoSize = true;
            itemail_label.Font = new Font("Showcard Gothic Cyrillic", 19F);
            itemail_label.ForeColor = Color.White;
            itemail_label.Location = new Point(154, 119);
            itemail_label.Name = "itemail_label";
            itemail_label.Size = new Size(144, 40);
            itemail_label.TabIndex = 18;
            itemail_label.Text = "itlogin";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Showcard Gothic Cyrillic", 19F);
            email_label.ForeColor = Color.White;
            email_label.Location = new Point(33, 119);
            email_label.Name = "email_label";
            email_label.Size = new Size(137, 40);
            email_label.TabIndex = 17;
            email_label.Text = "login - ";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Showcard Gothic Cyrillic", 19F);
            username_label.ForeColor = Color.White;
            username_label.Location = new Point(115, 37);
            username_label.Name = "username_label";
            username_label.Size = new Size(182, 40);
            username_label.TabIndex = 16;
            username_label.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 97);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // change_avatar_button
            // 
            change_avatar_button.BackColor = SystemColors.ActiveCaptionText;
            change_avatar_button.BackgroundImage = Properties.Resources.profile_img;
            change_avatar_button.BackgroundImageLayout = ImageLayout.Stretch;
            change_avatar_button.FlatAppearance.BorderSize = 0;
            change_avatar_button.FlatStyle = FlatStyle.Popup;
            change_avatar_button.Location = new Point(33, 13);
            change_avatar_button.Name = "change_avatar_button";
            change_avatar_button.Size = new Size(91, 84);
            change_avatar_button.TabIndex = 14;
            change_avatar_button.TextImageRelation = TextImageRelation.TextBeforeImage;
            change_avatar_button.UseVisualStyleBackColor = false;
            change_avatar_button.Click += change_avatar_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.purse_img1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(929, 32);
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
            button2.Location = new Point(329, 27);
            button2.Name = "button2";
            button2.Size = new Size(91, 84);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(457, 27);
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
            button4.Location = new Point(570, 31);
            button4.Name = "button4";
            button4.Size = new Size(91, 84);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(694, 32);
            button5.Name = "button5";
            button5.Size = new Size(91, 84);
            button5.TabIndex = 11;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.BackgroundImage = Properties.Resources.icons8_achivement_100;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(810, 32);
            button6.Name = "button6";
            button6.Size = new Size(91, 84);
            button6.TabIndex = 10;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Main_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1048, 495);
            Controls.Add(panelAvatar);
            Controls.Add(button6);
            Controls.Add(panel1);
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
            panelAvatar.ResumeLayout(false);
            panelAvatar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button6;
        private Panel panel1;
        private Label label1;
        private Button change_avatar_button;
        private Label username_label;
        private Label itbalance_label;
        private Label balance_label;
        private Label itemail_label;
        private Label email_label;
        private Label label2;
        private Label label3;
        private Button change_avatr_button;
        private Panel panelAvatar;
        private Button button_avatar1;
        private Button button_avatar2;
        private Label label4;
        private Button button_avatar12;
        private Button button_avatar11;
        private Button button_avatar10;
        private Button button_avatar9;
        private Button button_avatar8;
        private Button button_avatar7;
        private Button button_avatar6;
        private Button button_avatar5;
        private Button button_avatar4;
        private Button button_avatar3;
    }
}