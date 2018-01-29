namespace SmartHomeApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.btnAddModule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegisterArduino = new System.Windows.Forms.Button();
            this.lblAddActions = new System.Windows.Forms.Label();
            this.lblAddAction = new System.Windows.Forms.Button();
=======
            this.btnManageModule = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
>>>>>>> upstream/master
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(19, 112);
=======
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(14, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
>>>>>>> upstream/master
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command Output";
            // 
            // OutputTB
            // 
            this.OutputTB.AcceptsReturn = true;
            this.OutputTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.OutputTB.Location = new System.Drawing.Point(15, 134);
            this.OutputTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.OutputTB.Location = new System.Drawing.Point(11, 157);
            this.OutputTB.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> upstream/master
            this.OutputTB.Multiline = true;
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.ReadOnly = true;
            this.OutputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
<<<<<<< HEAD
            this.OutputTB.Size = new System.Drawing.Size(589, 164);
=======
            this.OutputTB.Size = new System.Drawing.Size(913, 137);
>>>>>>> upstream/master
            this.OutputTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
=======
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
>>>>>>> upstream/master
            this.label2.TabIndex = 3;
            this.label2.Text = "Modules:";
            // 
            // btnManageModule
            // 
<<<<<<< HEAD
            this.btnAddModule.Location = new System.Drawing.Point(114, 26);
            this.btnAddModule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(100, 28);
            this.btnAddModule.TabIndex = 4;
            this.btnAddModule.Text = "Add";
            this.btnAddModule.UseVisualStyleBackColor = true;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
=======
            this.btnManageModule.Location = new System.Drawing.Point(89, 24);
            this.btnManageModule.Name = "btnManageModule";
            this.btnManageModule.Size = new System.Drawing.Size(81, 23);
            this.btnManageModule.TabIndex = 4;
            this.btnManageModule.Text = "Manage";
            this.btnManageModule.UseVisualStyleBackColor = true;
            this.btnManageModule.Click += new System.EventHandler(this.btnManageModule_Click);
>>>>>>> upstream/master
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Device :";
            // 
            // btnRegisterArduino
            // 
            this.btnRegisterArduino.Location = new System.Drawing.Point(114, 72);
            this.btnRegisterArduino.Name = "btnRegisterArduino";
            this.btnRegisterArduino.Size = new System.Drawing.Size(100, 28);
            this.btnRegisterArduino.TabIndex = 6;
            this.btnRegisterArduino.Text = "Register";
            this.btnRegisterArduino.UseVisualStyleBackColor = true;
            this.btnRegisterArduino.Click += new System.EventHandler(this.btnRegisterArduino_Click);
            // 
            // lblAddActions
            // 
            this.lblAddActions.AutoSize = true;
            this.lblAddActions.Location = new System.Drawing.Point(380, 32);
            this.lblAddActions.Name = "lblAddActions";
            this.lblAddActions.Size = new System.Drawing.Size(83, 17);
            this.lblAddActions.TabIndex = 7;
            this.lblAddActions.Text = "Add Actions";
            // 
            // lblAddAction
            // 
            this.lblAddAction.Location = new System.Drawing.Point(469, 26);
            this.lblAddAction.Name = "lblAddAction";
            this.lblAddAction.Size = new System.Drawing.Size(100, 28);
            this.lblAddAction.TabIndex = 8;
            this.lblAddAction.Text = "Click here";
            this.lblAddAction.UseVisualStyleBackColor = true;
            this.lblAddAction.Click += new System.EventHandler(this.lblAddAction_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(621, 313);
            this.Controls.Add(this.lblAddAction);
            this.Controls.Add(this.lblAddActions);
            this.Controls.Add(this.btnRegisterArduino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddModule);
=======
            this.ClientSize = new System.Drawing.Size(936, 305);
            this.Controls.Add(this.btnManageModule);
>>>>>>> upstream/master
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Smart Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputTB;
        private System.Windows.Forms.Label label2;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegisterArduino;
        private System.Windows.Forms.Label lblAddActions;
        private System.Windows.Forms.Button lblAddAction;
=======
        private System.Windows.Forms.Button btnManageModule;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
>>>>>>> upstream/master
    }
}

