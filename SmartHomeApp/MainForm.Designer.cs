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
            this.SuspendLayout();
            // 
            // addActionBTN
            // 
            this.addActionBTN.Location = new System.Drawing.Point(13, 13);
            this.addActionBTN.Name = "addActionBTN";
            this.addActionBTN.Size = new System.Drawing.Size(75, 23);
            this.addActionBTN.TabIndex = 0;
            this.addActionBTN.Text = "button1";
            this.addActionBTN.UseVisualStyleBackColor = true;
            this.addActionBTN.Click += new System.EventHandler(this.addActionBTN_Click);
            // 
            // manageModulesBTN
            // 
            this.manageModulesBTN.Location = new System.Drawing.Point(13, 43);
            this.manageModulesBTN.Name = "manageModulesBTN";
            this.manageModulesBTN.Size = new System.Drawing.Size(75, 23);
            this.manageModulesBTN.TabIndex = 1;
            this.manageModulesBTN.Text = "button2";
            this.manageModulesBTN.UseVisualStyleBackColor = true;
            this.manageModulesBTN.Click += new System.EventHandler(this.manageModulesBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.manageModulesBTN);
            this.Controls.Add(this.addActionBTN);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addActionBTN;
        private System.Windows.Forms.Button manageModulesBTN;
    }
}