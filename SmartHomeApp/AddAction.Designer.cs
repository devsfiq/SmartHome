namespace SmartHomeApp
{
    partial class AddAction
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
            this.lblSelectDevice = new System.Windows.Forms.Label();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.lblSelectModule = new System.Windows.Forms.Label();
            this.cbModule = new System.Windows.Forms.ComboBox();
            this.btnRefreshD = new System.Windows.Forms.Button();
            this.btnRefreshM = new System.Windows.Forms.Button();
            this.lblSelectAction = new System.Windows.Forms.Label();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectDevice
            // 
            this.lblSelectDevice.AutoSize = true;
            this.lblSelectDevice.Location = new System.Drawing.Point(35, 101);
            this.lblSelectDevice.Name = "lblSelectDevice";
            this.lblSelectDevice.Size = new System.Drawing.Size(106, 17);
            this.lblSelectDevice.TabIndex = 0;
            this.lblSelectDevice.Text = "Select Device : ";
            // 
            // cbDevice
            // 
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(147, 98);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(121, 24);
            this.cbDevice.TabIndex = 1;
            // 
            // lblSelectModule
            // 
            this.lblSelectModule.AutoSize = true;
            this.lblSelectModule.Location = new System.Drawing.Point(35, 137);
            this.lblSelectModule.Name = "lblSelectModule";
            this.lblSelectModule.Size = new System.Drawing.Size(109, 17);
            this.lblSelectModule.TabIndex = 2;
            this.lblSelectModule.Text = "Select Module : ";
            // 
            // cbModule
            // 
            this.cbModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModule.FormattingEnabled = true;
            this.cbModule.Location = new System.Drawing.Point(147, 134);
            this.cbModule.Name = "cbModule";
            this.cbModule.Size = new System.Drawing.Size(121, 24);
            this.cbModule.TabIndex = 3;
            // 
            // btnRefreshD
            // 
            this.btnRefreshD.Location = new System.Drawing.Point(274, 96);
            this.btnRefreshD.Name = "btnRefreshD";
            this.btnRefreshD.Size = new System.Drawing.Size(133, 27);
            this.btnRefreshD.TabIndex = 4;
            this.btnRefreshD.Text = "Refresh Devices";
            this.btnRefreshD.UseVisualStyleBackColor = true;
            this.btnRefreshD.Click += new System.EventHandler(this.btnRefreshD_Click);
            // 
            // btnRefreshM
            // 
            this.btnRefreshM.Location = new System.Drawing.Point(274, 132);
            this.btnRefreshM.Name = "btnRefreshM";
            this.btnRefreshM.Size = new System.Drawing.Size(133, 27);
            this.btnRefreshM.TabIndex = 5;
            this.btnRefreshM.Text = "Refresh Modules";
            this.btnRefreshM.UseVisualStyleBackColor = true;
            this.btnRefreshM.Click += new System.EventHandler(this.btnRefreshM_Click);
            // 
            // lblSelectAction
            // 
            this.lblSelectAction.AutoSize = true;
            this.lblSelectAction.Location = new System.Drawing.Point(35, 172);
            this.lblSelectAction.Name = "lblSelectAction";
            this.lblSelectAction.Size = new System.Drawing.Size(98, 17);
            this.lblSelectAction.TabIndex = 6;
            this.lblSelectAction.Text = "Select Action :";
            // 
            // cbAction
            // 
            this.cbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Enter",
            "Exit"});
            this.cbAction.Location = new System.Drawing.Point(147, 169);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(121, 24);
            this.cbAction.TabIndex = 7;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(147, 238);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(121, 33);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dgvModules
            // 
            this.dgvModules.AllowUserToAddRows = false;
            this.dgvModules.AllowUserToDeleteRows = false;
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(432, 32);
            this.dgvModules.Margin = new System.Windows.Forms.Padding(4);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.ReadOnly = true;
            this.dgvModules.Size = new System.Drawing.Size(593, 234);
            this.dgvModules.TabIndex = 11;
            this.dgvModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModules_CellContentClick);
            this.dgvModules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModules_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manage Actions";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(39, 68);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(925, 274);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 321);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvModules);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.lblSelectAction);
            this.Controls.Add(this.btnRefreshM);
            this.Controls.Add(this.btnRefreshD);
            this.Controls.Add(this.cbModule);
            this.Controls.Add(this.lblSelectModule);
            this.Controls.Add(this.cbDevice);
            this.Controls.Add(this.lblSelectDevice);
            this.Name = "AddAction";
            this.Text = "AddAction";
            this.Load += new System.EventHandler(this.AddAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDevice;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Label lblSelectModule;
        private System.Windows.Forms.ComboBox cbModule;
        private System.Windows.Forms.Button btnRefreshD;
        private System.Windows.Forms.Button btnRefreshM;
        private System.Windows.Forms.Label lblSelectAction;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDelete;
    }
}