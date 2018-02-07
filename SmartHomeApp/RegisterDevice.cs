using SmartHomeLib;
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
    public partial class RegisterDevice : Form
    {
        public RegisterDevice()
        {
            InitializeComponent();
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            try
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM devices", conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgvModules.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to show devices! Exception: " + ex.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void RegisterDevice_Load(object sender, EventArgs e)
        {
            ddlSelectDevice.DataSource = MainForm.Server.ConnectedHosts;
            ddlSelectDevice.DisplayMember = "IP";
            ddlSelectDevice.ValueMember = "MAC";

            if(ddlSelectDevice.SelectedValue !=  null)
            {
                tbMac.Text = ddlSelectDevice.SelectedValue.ToString();
            }
        }

        private void dgvModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow rowUpdate in dgvModules.SelectedRows)
            {
                lblId.Text = rowUpdate.Cells[0].Value.ToString();
                tbDeviceName.Text = rowUpdate.Cells[1].Value.ToString();
                tbMac.Text = rowUpdate.Cells[2].Value.ToString();
                btnRegister.Text = "Update";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void popuMacAddress(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //string macId = "12:34:32:21:21:22"; // Add dynamic MAC Address here, this is just for testing
            var name = tbDeviceName.Text;
            var mac = tbMac.Text;
           


            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            SQLiteCommand cmd = new SQLiteCommand(conn);

            if (name.Equals(""))
            {
                MessageBox.Show("Device name and Mac is required!", "Warning!");
            }
            else if (mac.Equals(""))
            {
                MessageBox.Show("Device name and Mac is required!", "Warning!");
            }
            else
            {
                // Check ID
                if (lblId.Text.Equals(""))
                {
                    try
                    {
                        string sql = "INSERT into devices (devicename, macaddress) VALUES (@name, @mac)";
                        cmd.Parameters.AddWithValue("@name", tbDeviceName.Text);
                        cmd.Parameters.AddWithValue("@mac", tbMac.Text);
                        conn.Open();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added device successfully!", "Success");
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
                        string sql = "UPDATE devices SET devicename = @name, macaddress = @mac WHERE Id = @id";
                        cmd.Parameters.AddWithValue("@name", tbDeviceName);
                        cmd.Parameters.AddWithValue("@mac", tbMac);
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
        }//btnregisterclick

        public void refreshTable()
        {
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            try
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM devices", conn);
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            SQLiteCommand cmd = new SQLiteCommand(conn);

            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this device?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM devices WHERE dId = @id";
                    cmd.Parameters.AddWithValue("@id", lblId.Text);
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted!", "Success");
                    refreshTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete module! Exception:" + ex.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void ddlSelectDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSelectDevice.SelectedValue != null)
            {
                tbMac.Text = ddlSelectDevice.SelectedValue.ToString();
            }
        }
    }
}
