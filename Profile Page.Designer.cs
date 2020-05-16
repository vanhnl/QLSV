namespace QLSV
{
    partial class Profile_Page
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
            this.button2 = new System.Windows.Forms.Button();
            this.ContactTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.FullnameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 44);
            this.button2.TabIndex = 27;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ContactTxt
            // 
            this.ContactTxt.Location = new System.Drawing.Point(187, 374);
            this.ContactTxt.Name = "ContactTxt";
            this.ContactTxt.Size = new System.Drawing.Size(267, 22);
            this.ContactTxt.TabIndex = 25;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(187, 320);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(267, 22);
            this.EmailTxt.TabIndex = 24;
            this.EmailTxt.Leave += new System.EventHandler(this.EmailTxt_Leave);
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Location = new System.Drawing.Point(187, 261);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(267, 22);
            this.PhoneTxt.TabIndex = 23;
            this.PhoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTxt_KeyPress);
            // 
            // FullnameTxt
            // 
            this.FullnameTxt.Location = new System.Drawing.Point(187, 201);
            this.FullnameTxt.Name = "FullnameTxt";
            this.FullnameTxt.Size = new System.Drawing.Size(267, 22);
            this.FullnameTxt.TabIndex = 22;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(187, 139);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(267, 22);
            this.PasswordTxt.TabIndex = 21;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(187, 76);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(267, 22);
            this.UsernameTxt.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone Number";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(48, 206);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 17);
            this.Name.TabIndex = 16;
            this.Name.Text = "Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(48, 139);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 15;
            this.Password.Text = "Password";
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(48, 76);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(51, 17);
            this.UserID.TabIndex = 14;
            this.UserID.Text = "UserID";
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(187, 167);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(129, 21);
            this.ShowPassword.TabIndex = 28;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Profile_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 572);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ContactTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.FullnameTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserID);
            this.Name = "Profile_Page";
            this.Text = "Profile_Page";
            this.Load += new System.EventHandler(this.Profile_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserID;
        public System.Windows.Forms.TextBox ContactTxt;
        public System.Windows.Forms.TextBox EmailTxt;
        public System.Windows.Forms.TextBox PhoneTxt;
        public System.Windows.Forms.TextBox FullnameTxt;
        public System.Windows.Forms.TextBox PasswordTxt;
        public System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}