namespace SmartHomeApp
{
    partial class AddModule
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
            this.SuspendLayout();
            // 
            // tbOpenDialog
            // 
            this.tbOpenDialog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbOpenDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOpenDialog.Location = new System.Drawing.Point(125, 69);
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
            this.lblSelectModule.Location = new System.Drawing.Point(20, 71);
            this.lblSelectModule.Name = "lblSelectModule";
            this.lblSelectModule.Size = new System.Drawing.Size(99, 13);
            this.lblSelectModule.TabIndex = 1;
            this.lblSelectModule.Text = "Open Module Path:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 237);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(352, 66);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(25, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.Location = new System.Drawing.Point(20, 32);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(88, 13);
            this.lblCommandName.TabIndex = 3;
            this.lblCommandName.Text = "Command Name:";
            // 
            // tbCommandName
            // 
            this.tbCommandName.Location = new System.Drawing.Point(125, 32);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(146, 20);
            this.tbCommandName.TabIndex = 4;
            // 
            // lblArgs
            // 
            this.lblArgs.AutoSize = true;
            this.lblArgs.Location = new System.Drawing.Point(23, 111);
            this.lblArgs.Name = "lblArgs";
            this.lblArgs.Size = new System.Drawing.Size(72, 13);
            this.lblArgs.TabIndex = 5;
            this.lblArgs.Text = "cmd line args:";
            // 
            // tbArgs
            // 
            this.tbArgs.Location = new System.Drawing.Point(125, 108);
            this.tbArgs.Name = "tbArgs";
            this.tbArgs.Size = new System.Drawing.Size(146, 20);
            this.tbArgs.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 237);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbArgs);
            this.Controls.Add(this.lblArgs);
            this.Controls.Add(this.tbCommandName);
            this.Controls.Add(this.lblCommandName);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblSelectModule);
            this.Controls.Add(this.tbOpenDialog);
            this.Name = "AddModule";
            this.Text = "Add Module";
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
    }
}