namespace CryptoMonitoring
{
    partial class Crypto_menu
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
            button_graphic = new Button();
            logo = new Button();
            SuspendLayout();
            // 
            // button_graphic
            // 
            button_graphic.BackColor = Color.Lime;
            button_graphic.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button_graphic.FlatAppearance.BorderSize = 0;
            button_graphic.FlatStyle = FlatStyle.Flat;
            button_graphic.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_graphic.ForeColor = Color.Black;
            button_graphic.Location = new Point(606, 23);
            button_graphic.Name = "button_graphic";
            button_graphic.Size = new Size(166, 47);
            button_graphic.TabIndex = 21;
            button_graphic.Text = "Graphic";
            button_graphic.UseVisualStyleBackColor = false;
            button_graphic.Click += button_graphic_Click;
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
            logo.Size = new Size(319, 103);
            logo.TabIndex = 20;
            logo.Text = "BANANCE";
            logo.TextImageRelation = TextImageRelation.ImageBeforeText;
            logo.UseVisualStyleBackColor = false;
            // 
            // Crypto_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button_graphic);
            Controls.Add(logo);
            Name = "Crypto_menu";
            Text = "Crypto_menu";
            Load += Crypto_menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_graphic;
        private Button logo;
    }
}