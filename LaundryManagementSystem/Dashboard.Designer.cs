namespace LaundryManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.PanelCategories = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonPayment = new System.Windows.Forms.Button();
            this.machineIconHome = new System.Windows.Forms.PictureBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machineIconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCategories
            // 
            this.PanelCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PanelCategories.Controls.Add(this.panel2);
            this.PanelCategories.Controls.Add(this.ButtonPayment);
            this.PanelCategories.Controls.Add(this.machineIconHome);
            this.PanelCategories.Controls.Add(this.LogOutButton);
            this.PanelCategories.Controls.Add(this.AdminButton);
            this.PanelCategories.Controls.Add(this.SettingsButton);
            this.PanelCategories.Controls.Add(this.ClientButton);
            this.PanelCategories.Controls.Add(this.CartButton);
            this.PanelCategories.ForeColor = System.Drawing.Color.White;
            this.PanelCategories.Location = new System.Drawing.Point(1, 0);
            this.PanelCategories.Name = "PanelCategories";
            this.PanelCategories.Size = new System.Drawing.Size(74, 458);
            this.PanelCategories.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(74, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 100);
            this.panel2.TabIndex = 11;
            // 
            // ButtonPayment
            // 
            this.ButtonPayment.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPayment.BackgroundImage")));
            this.ButtonPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPayment.ForeColor = System.Drawing.Color.Gray;
            this.ButtonPayment.Location = new System.Drawing.Point(23, 226);
            this.ButtonPayment.Name = "ButtonPayment";
            this.ButtonPayment.Size = new System.Drawing.Size(25, 25);
            this.ButtonPayment.TabIndex = 13;
            this.ButtonPayment.UseVisualStyleBackColor = false;
            this.ButtonPayment.Click += new System.EventHandler(this.ButtonPayment_Click);
            // 
            // machineIconHome
            // 
            this.machineIconHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.machineIconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.machineIconHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("machineIconHome.BackgroundImage")));
            this.machineIconHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.machineIconHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.machineIconHome.Location = new System.Drawing.Point(11, 11);
            this.machineIconHome.Name = "machineIconHome";
            this.machineIconHome.Size = new System.Drawing.Size(50, 51);
            this.machineIconHome.TabIndex = 12;
            this.machineIconHome.TabStop = false;
            this.machineIconHome.Click += new System.EventHandler(this.machineIconHome_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Turquoise;
            this.LogOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOutButton.BackgroundImage")));
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.Window;
            this.LogOutButton.Location = new System.Drawing.Point(22, 411);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(29, 26);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Turquoise;
            this.AdminButton.BackgroundImage = global::LaundryManagementSystem.Properties.Resources.icons8_male_user_50__2_;
            this.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AdminButton.Location = new System.Drawing.Point(22, 358);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(29, 29);
            this.AdminButton.TabIndex = 5;
            this.AdminButton.UseVisualStyleBackColor = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Turquoise;
            this.SettingsButton.BackgroundImage = global::LaundryManagementSystem.Properties.Resources.icons8_settings_48__1_;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.ForeColor = System.Drawing.Color.Gray;
            this.SettingsButton.Location = new System.Drawing.Point(22, 290);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(25, 25);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // ClientButton
            // 
            this.ClientButton.BackColor = System.Drawing.Color.Turquoise;
            this.ClientButton.BackgroundImage = global::LaundryManagementSystem.Properties.Resources.icons8_admin_settings_male_64__1_;
            this.ClientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientButton.ForeColor = System.Drawing.Color.White;
            this.ClientButton.Location = new System.Drawing.Point(22, 102);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(26, 26);
            this.ClientButton.TabIndex = 1;
            this.ClientButton.UseVisualStyleBackColor = false;
            // 
            // CartButton
            // 
            this.CartButton.BackColor = System.Drawing.Color.Turquoise;
            this.CartButton.BackgroundImage = global::LaundryManagementSystem.Properties.Resources.icons8_fast_cart_48__1_;
            this.CartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartButton.ForeColor = System.Drawing.Color.Cyan;
            this.CartButton.Location = new System.Drawing.Point(21, 158);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(26, 26);
            this.CartButton.TabIndex = 2;
            this.CartButton.UseVisualStyleBackColor = false;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(75, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(75, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 458);
            this.panel3.TabIndex = 11;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelCategories);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.PanelCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.machineIconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCategories;
        private System.Windows.Forms.Button ButtonPayment;
        private System.Windows.Forms.PictureBox machineIconHome;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}