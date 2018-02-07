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
            this.addActionBTN = new System.Windows.Forms.Button();
            this.manageModulesBTN = new System.Windows.Forms.Button();
            this.resgisterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addActionBTN
            // 
            this.addActionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addActionBTN.Location = new System.Drawing.Point(268, 272);
            this.addActionBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addActionBTN.Name = "addActionBTN";
            this.addActionBTN.Size = new System.Drawing.Size(100, 32);
            this.addActionBTN.TabIndex = 0;
            this.addActionBTN.Text = "Add";
            this.addActionBTN.UseVisualStyleBackColor = true;
            this.addActionBTN.Click += new System.EventHandler(this.addActionBTN_Click);
            // 
            // manageModulesBTN
            // 
            this.manageModulesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.manageModulesBTN.Location = new System.Drawing.Point(268, 116);
            this.manageModulesBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageModulesBTN.Name = "manageModulesBTN";
            this.manageModulesBTN.Size = new System.Drawing.Size(100, 32);
            this.manageModulesBTN.TabIndex = 1;
            this.manageModulesBTN.Text = "Manage";
            this.manageModulesBTN.UseVisualStyleBackColor = true;
            this.manageModulesBTN.Click += new System.EventHandler(this.manageModulesBTN_Click);
            // 
            // resgisterBtn
            // 
            this.resgisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resgisterBtn.Location = new System.Drawing.Point(268, 194);
            this.resgisterBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resgisterBtn.Name = "resgisterBtn";
            this.resgisterBtn.Size = new System.Drawing.Size(100, 32);
            this.resgisterBtn.TabIndex = 2;
            this.resgisterBtn.Text = "Register";
            this.resgisterBtn.UseVisualStyleBackColor = true;
            this.resgisterBtn.Click += new System.EventHandler(this.resgisterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Actions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(39, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "AllSmart Home Automation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(40, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Register User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(40, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Map Action to User:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resgisterBtn);
            this.Controls.Add(this.manageModulesBTN);
            this.Controls.Add(this.addActionBTN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addActionBTN;
        private System.Windows.Forms.Button manageModulesBTN;
        private System.Windows.Forms.Button resgisterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}