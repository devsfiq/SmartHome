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
            this.btnAdd = new System.Windows.Forms.Button();
            this.ddlSelectDevice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(39, 28);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(100, 17);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Device Name :";
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.Location = new System.Drawing.Point(159, 25);
            this.tbDeviceName.Multiline = true;
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(118, 20);
            this.tbDeviceName.TabIndex = 1;
            // 
            // lblSelectDevice
            // 
            this.lblSelectDevice.AutoSize = true;
            this.lblSelectDevice.Location = new System.Drawing.Point(39, 71);
            this.lblSelectDevice.Name = "lblSelectDevice";
            this.lblSelectDevice.Size = new System.Drawing.Size(102, 17);
            this.lblSelectDevice.TabIndex = 2;
            this.lblSelectDevice.Text = "Select Device :";
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.Location = new System.Drawing.Point(306, 62);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(88, 34);
            this.btnSelectDevice.TabIndex = 4;
            this.btnSelectDevice.Text = "Refresh";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.btnSelectDevice_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Register";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ddlSelectDevice
            // 
            this.ddlSelectDevice.FormattingEnabled = true;
            this.ddlSelectDevice.Location = new System.Drawing.Point(159, 68);
            this.ddlSelectDevice.Name = "ddlSelectDevice";
            this.ddlSelectDevice.Size = new System.Drawing.Size(121, 24);
            this.ddlSelectDevice.TabIndex = 6;
            // 
            // RegisterDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 336);
            this.Controls.Add(this.ddlSelectDevice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelectDevice);
            this.Controls.Add(this.lblSelectDevice);
            this.Controls.Add(this.tbDeviceName);
            this.Controls.Add(this.lblDeviceName);
            this.Name = "RegisterDevice";
            this.Text = "RegisterDevice";
            this.Load += new System.EventHandler(this.RegisterDevice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox tbDeviceName;
        private System.Windows.Forms.Label lblSelectDevice;
        private System.Windows.Forms.Button btnSelectDevice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox ddlSelectDevice;
    }
}