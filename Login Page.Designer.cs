namespace QLSV
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_PictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_Username_txtBox = new System.Windows.Forms.TextBox();
            this.Login_Password_txtBox = new System.Windows.Forms.TextBox();
            this.Login_SavePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.Login_ForgetPasswordCheckbox = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_loginButton
            // 
            resources.ApplyResources(this.Login_loginButton, "Login_loginButton");
            this.Login_loginButton.Name = "Login_loginButton";
            this.Login_loginButton.UseVisualStyleBackColor = true;
            this.Login_loginButton.Click += new System.EventHandler(this.Login_loginButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Login_PictureBox
            // 
            this.Login_PictureBox.Image = global::QLSV.Properties.Resources.Logo_Greenwich;
            resources.ApplyResources(this.Login_PictureBox, "Login_PictureBox");
            this.Login_PictureBox.Name = "Login_PictureBox";
            this.Login_PictureBox.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Login_Username_txtBox
            // 
            resources.ApplyResources(this.Login_Username_txtBox, "Login_Username_txtBox");
            this.Login_Username_txtBox.Name = "Login_Username_txtBox";
            this.Login_Username_txtBox.TextChanged += new System.EventHandler(this.Login_Username_txtBox_TextChanged);
            // 
            // Login_Password_txtBox
            // 
            resources.ApplyResources(this.Login_Password_txtBox, "Login_Password_txtBox");
            this.Login_Password_txtBox.Name = "Login_Password_txtBox";
            this.Login_Password_txtBox.UseSystemPasswordChar = true;
            this.Login_Password_txtBox.TextChanged += new System.EventHandler(this.Login_Password_txtBox_TextChanged);
            // 
            // Login_SavePasswordCheckBox
            // 
            resources.ApplyResources(this.Login_SavePasswordCheckBox, "Login_SavePasswordCheckBox");
            this.Login_SavePasswordCheckBox.Name = "Login_SavePasswordCheckBox";
            this.Login_SavePasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // Login_ForgetPasswordCheckbox
            // 
            resources.ApplyResources(this.Login_ForgetPasswordCheckbox, "Login_ForgetPasswordCheckbox");
            this.Login_ForgetPasswordCheckbox.Name = "Login_ForgetPasswordCheckbox";
            this.Login_ForgetPasswordCheckbox.TabStop = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ShowPassword
            // 
            resources.ApplyResources(this.ShowPassword, "ShowPassword");
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_ForgetPasswordCheckbox);
            this.Controls.Add(this.Login_SavePasswordCheckBox);
            this.Controls.Add(this.Login_Password_txtBox);
            this.Controls.Add(this.Login_Username_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_PictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_loginButton);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Login_PictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_Username_txtBox;
        private System.Windows.Forms.TextBox Login_Password_txtBox;
        private System.Windows.Forms.CheckBox Login_SavePasswordCheckBox;
        private System.Windows.Forms.LinkLabel Login_ForgetPasswordCheckbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}