namespace SmartHomeApp
{
    partial class RegisterDevice
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
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.tbDeviceName = new System.Windows.Forms.TextBox();
            this.lblSelectDevice = new System.Windows.Forms.Label();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.ddlSelectDevice = new System.Windows.Forms.ComboBox();
            this.lblMacAddress = new System.Windows.Forms.Label();
            this.tbMac = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(35, 101);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(100, 17);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Device Name :";
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.Location = new System.Drawing.Point(141, 101);
            this.tbDeviceName.Multiline = true;
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(121, 20);
            this.tbDeviceName.TabIndex = 1;
            // 
            // lblSelectDevice
            // 
            this.lblSelectDevice.AutoSize = true;
            this.lblSelectDevice.Location = new System.Drawing.Point(35, 149);
            this.lblSelectDevice.Name = "lblSelectDevice";
            this.lblSelectDevice.Size = new System.Drawing.Size(102, 17);
            this.lblSelectDevice.TabIndex = 2;
            this.lblSelectDevice.Text = "Select Device :";
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Location = new System.Drawing.Point(269, 143);
            this.btnSelectDevice.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(82, 30);
            this.btnSelectDevice.TabIndex = 4;
            this.btnSelectDevice.Text = "Refresh";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // ddlSelectDevice
            // 
            this.ddlSelectDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSelectDevice.Location = new System.Drawing.Point(141, 149);
            this.ddlSelectDevice.Name = "ddlSelectDevice";
            this.ddlSelectDevice.Size = new System.Drawing.Size(121, 24);
            this.ddlSelectDevice.TabIndex = 6;
            this.ddlSelectDevice.SelectedIndexChanged += new System.EventHandler(this.popuMacAddress);
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.AutoSize = true;
            this.lblMacAddress.Location = new System.Drawing.Point(39, 198);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(102, 17);
            this.lblMacAddress.TabIndex = 7;
            this.lblMacAddress.Text = "Mac Address : ";
            this.lblMacAddress.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbMac
            // 
            this.tbMac.Enabled = false;
            this.tbMac.Location = new System.Drawing.Point(141, 198);
            this.tbMac.Name = "tbMac";
            this.tbMac.ReadOnly = true;
            this.tbMac.Size = new System.Drawing.Size(121, 22);
            this.tbMac.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(152, 245);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register Device";
            // 
            // dgvModules
            // 
            this.dgvModules.AllowUserToAddRows = false;
            this.dgvModules.AllowUserToDeleteRows = false;
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(382, 32);
            this.dgvModules.Margin = new System.Windows.Forms.Padding(4);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.ReadOnly = true;
            this.dgvModules.Size = new System.Drawing.Size(693, 234);
            this.dgvModules.TabIndex = 11;
            this.dgvModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModules_CellContentClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(50, 69);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(975, 274);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RegisterDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 318);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvModules);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbMac);
            this.Controls.Add(this.lblMacAddress);
            this.Controls.Add(this.ddlSelectDevice);
            this.Controls.Add(this.btnSelectDevice);
            this.Controls.Add(this.lblSelectDevice);
            this.Controls.Add(this.tbDeviceName);
            this.Controls.Add(this.lblDeviceName);
            this.Name = "RegisterDevice";
            this.Text = "RegisterDevice";
            this.Load += new System.EventHandler(this.RegisterDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox tbDeviceName;
        private System.Windows.Forms.Label lblSelectDevice;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.ComboBox ddlSelectDevice;
        private System.Windows.Forms.Label lblMacAddress;
        private System.Windows.Forms.TextBox tbMac;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDelete;
    }
}