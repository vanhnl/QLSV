namespace QLSV
{
    partial class ManagementPage
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
            this.components = new System.ComponentModel.Container();
            this.UsersData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLSVUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLSVDataSet = new QLSV.QLSVDataSet();
            this.Update = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.QLSVUserTableAdapter = new QLSV.QLSVDataSetTableAdapters.QLSVUserTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsersData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersData
            // 
            this.UsersData.AllowUserToAddRows = false;
            this.UsersData.AllowUserToDeleteRows = false;
            this.UsersData.AllowUserToResizeRows = false;
            this.UsersData.AutoGenerateColumns = false;
            this.UsersData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.Password,
            this.FullName,
            this.PhoneNumber,
            this.Email,
            this.Contact});
            this.UsersData.DataSource = this.qLSVUserBindingSource;
            this.UsersData.Location = new System.Drawing.Point(12, 235);
            this.UsersData.Name = "UsersData";
            this.UsersData.ReadOnly = true;
            this.UsersData.RowTemplate.Height = 24;
            this.UsersData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersData.ShowCellErrors = false;
            this.UsersData.ShowCellToolTips = false;
            this.UsersData.ShowEditingIcon = false;
            this.UsersData.ShowRowErrors = false;
            this.UsersData.Size = new System.Drawing.Size(823, 420);
            this.UsersData.TabIndex = 0;
            this.UsersData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersData_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // qLSVUserBindingSource
            // 
            this.qLSVUserBindingSource.DataMember = "QLSVUser";
            this.qLSVUserBindingSource.DataSource = this.QLSVDataSet;
            // 
            // QLSVDataSet
            // 
            this.QLSVDataSet.DataSetName = "QLSVDataSet";
            this.QLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(12, 151);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(175, 59);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(224, 151);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(175, 59);
            this.Create.TabIndex = 2;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(443, 151);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(175, 59);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(660, 151);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(175, 59);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // QLSVUserTableAdapter
            // 
            this.QLSVUserTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.Logo_Greenwich;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.UsersData);
            this.Name = "ManagementPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Activated += new System.EventHandler(this.ManagementPage_Activated);
            this.Load += new System.EventHandler(this.ManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView UsersData;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QLSVDataSet QLSVDataSet;
        private System.Windows.Forms.BindingSource qLSVUserBindingSource;
        private QLSVDataSetTableAdapters.QLSVUserTableAdapter QLSVUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
    }
}