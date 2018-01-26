using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHomeApp
{
    public partial class AddModule : Form
    {
        public AddModule()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialogModule.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialogModule.FilterIndex = 2;
            openFileDialogModule.RestoreDirectory = true;

            if (openFileDialogModule.ShowDialog() == DialogResult.OK)
            {
                string strfilename = openFileDialogModule.InitialDirectory + openFileDialogModule.FileName;
                tbOpenDialog.Text = strfilename;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((tbCommandName.Text == "") || (tbOpenDialog.Text == "") || (tbArgs.Text == ""))
            {
                MessageBox.Show("Please fill in the fields", "Error");
            }
            else
            {
                TextWriter txt = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\modules.txt", append: true);
                try
                {
                    txt.WriteLine(tbCommandName.Text + "|" + openFileDialogModule.FileName + "|" + tbArgs.Text);
                    txt.Close();
                    MessageBox.Show("Added module successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add module! Exception: " + ex.ToString(), "Error");
                }
            }
        }
    }
}
