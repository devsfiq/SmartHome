namespace SmartHomeApp
{
    partial class ManageModules
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
            this.tbOpenDialog = new System.Windows.Forms.Label();
            this.openFileDialogModule = new System.Windows.Forms.OpenFileDialog();
            this.lblSelectModule = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.tbCommandName = new System.Windows.Forms.TextBox();
            this.lblArgs = new System.Windows.Forms.Label();
            this.tbArgs = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOpenDialog
            // 
            this.tbOpenDialog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbOpenDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOpenDialog.Location = new System.Drawing.Point(131, 119);
            this.tbOpenDialog.Name = "tbOpenDialog";
            this.tbOpenDialog.Size = new System.Drawing.Size(221, 18);
            this.tbOpenDialog.TabIndex = 0;
            // 
            // openFileDialogModule
            // 
            this.openFileDialogModule.FileName = "openFileDialogModule";
            // 
            // lblSelectModule
            // 
            this.lblSelectModule.AutoSize = true;
            this.lblSelectModule.Location = new System.Drawing.Point(26, 121);
            this.lblSelectModule.Name = "lblSelectModule";
            this.lblSelectModule.Size = new System.Drawing.Size(99, 13);
            this.lblSelectModule.TabIndex = 1;
            this.lblSelectModule.Text = "Open Module Path:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 296);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(358, 116);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(25, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.Location = new System.Drawing.Point(26, 82);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(88, 13);
            this.lblCommandName.TabIndex = 3;
            this.lblCommandName.Text = "Command Name:";
            // 
            // tbCommandName
            // 
            this.tbCommandName.Location = new System.Drawing.Point(131, 82);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(146, 20);
            this.tbCommandName.TabIndex = 4;
            // 
            // lblArgs
            // 
            this.lblArgs.AutoSize = true;
            this.lblArgs.Location = new System.Drawing.Point(29, 161);
            this.lblArgs.Name = "lblArgs";
            this.lblArgs.Size = new System.Drawing.Size(72, 13);
            this.lblArgs.TabIndex = 5;
            this.lblArgs.Text = "cmd line args:";
            // 
            // tbArgs
            // 
            this.tbArgs.Location = new System.Drawing.Point(131, 158);
            this.tbArgs.Name = "tbArgs";
            this.tbArgs.Size = new System.Drawing.Size(146, 20);
            this.tbArgs.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvModules
            // 
            this.dgvModules.AllowUserToAddRows = false;
            this.dgvModules.AllowUserToDeleteRows = false;
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(414, 26);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.ReadOnly = true;
            this.dgvModules.Size = new System.Drawing.Size(520, 190);
            this.dgvModules.TabIndex = 8;
            this.dgvModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModules_CellContentClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(29, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(859, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Modules";
            // 
            // ManageModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvModules);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbArgs);
            this.Controls.Add(this.lblArgs);
            this.Controls.Add(this.tbCommandName);
            this.Controls.Add(this.lblCommandName);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblSelectModule);
            this.Controls.Add(this.tbOpenDialog);
            this.Name = "ManageModules";
            this.Text = "Add Module";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbOpenDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialogModule;
        private System.Windows.Forms.Label lblSelectModule;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.TextBox tbCommandName;
        private System.Windows.Forms.Label lblArgs;
        private System.Windows.Forms.TextBox tbArgs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
    }
}