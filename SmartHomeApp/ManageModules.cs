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
using System.Data.SQLite;

namespace SmartHomeApp
{
    public partial class ManageModules : Form
    {
        public ManageModules()
        {
            InitializeComponent();
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            try
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM modules", conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgvModules.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to show modules! Exception: " + ex.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }
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

        // Insert and Update
        private void btnSave_Click(object sender, EventArgs e)
        {
            string macId = "12:34:32:21:21:22"; // Add dynamic MAC Address here, this is just for testing
            var command = tbCommandName.Text;
            var path = tbOpenDialog.Text;
            var args = tbArgs.Text;

            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            SQLiteCommand cmd = new SQLiteCommand(conn);

            if (command.Equals(""))
            {
                MessageBox.Show("Command name and Path is required!", "Warning!");
            }
            else if (path.Equals(""))
            {
                MessageBox.Show("Command name and Path is required!", "Warning!");
            }
            else
            { 
            // Check ID
            if (lblId.Text.Equals(""))
            {
                try
                {
                    string sql = "INSERT into modules (MacAddress, Command, Path, Args) VALUES (@macId, @command, @path, @args)";
                    cmd.Parameters.AddWithValue("@macId", macId);
                    cmd.Parameters.AddWithValue("@command", command);
                    cmd.Parameters.AddWithValue("@path", path);
                    cmd.Parameters.AddWithValue("@args", args);
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added module successfully!", "Success");
                    refreshTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add module! Exception: " + ex.ToString(), "Error");
                }
                finally
                {
                    conn.Close();
                }
                }
                else
                {
                    try
                    {
                        string sql = "UPDATE modules SET Command = @command, Path = @path, Args = @args WHERE Id = @id";
                        cmd.Parameters.AddWithValue("@command", command);
                        cmd.Parameters.AddWithValue("@path", path);
                        cmd.Parameters.AddWithValue("@args", args);
                        cmd.Parameters.AddWithValue("@id", lblId.Text);
                        conn.Open();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Module edtied!", "Success");
                        refreshTable();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to edit module! Exception:" + ex.ToString(), "Error");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }

        // Populates Text Box
        private void dgvModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow rowUpdate in dgvModules.SelectedRows)
            {
                lblId.Text = rowUpdate.Cells[0].Value.ToString();
                tbCommandName.Text = rowUpdate.Cells[2].Value.ToString();
                tbOpenDialog.Text = rowUpdate.Cells[3].Value.ToString();
                tbArgs.Text = rowUpdate.Cells[4].Value.ToString();
                btnSave.Text = "Update";
            }
        }

        // Delete 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            SQLiteCommand cmd = new SQLiteCommand(conn);
           
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this module?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM modules WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", lblId.Text);
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted!", "Success");
                    refreshTable();
                }
            }
            catch(Exception ex)
                {
                MessageBox.Show("Unable to delete module! Exception:" + ex.ToString(), "Error");
            }
                finally
            {
                conn.Close();
            }
        }

        public void refreshTable()
        {
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            try
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM modules", conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgvModules.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to refresh table! Exception: " + ex.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
