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
using System.Data.SqlClient;

namespace SmartHomeApp
{
    public partial class AddAction : Form
    {
        string[] lineOfContentForD;
        string[] lineOfContentForM;
        string[] lineOfContents;
        String selectpath;
        public AddAction()
        {
            InitializeComponent();
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            try
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM actions", conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgvModules.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to show actions! Exception: " + ex.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }

            try //populate dropdownlist modules
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT command FROM modules", conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Module");
                cbModule.DisplayMember = "command";
                cbModule.ValueMember = "command";
                cbModule.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate modules! Exception: " + ex.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }

            try //populate dropdownlist devices
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT devicename FROM devices", conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Device");
                cbDevice.DisplayMember = "devicename";
                cbDevice.ValueMember = "devicename";
                cbDevice.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate devices! Exception: " + ex.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnRefreshD_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT devicename FROM devices", conn);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Device");
            cbDevice.DisplayMember = "devicename";
            cbDevice.ValueMember = "devicename";
            cbDevice.DataSource = dataSet.Tables[0];
        }

        private void AddAction_Load(object sender, EventArgs e){}

        private void btnRefreshM_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT command FROM modules", conn);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Module");
            cbModule.DisplayMember = "command";
            cbModule.ValueMember = "command";
            cbModule.DataSource = dataSet.Tables[0];
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            SQLiteCommand cmd = new SQLiteCommand(conn);

            if ((cbDevice.Text == "") || (cbModule.Text == "") || (cbAction.Text == ""))
            {
                MessageBox.Show("Please select the items from all the Dropdownlist", "Error");
            }
            else
            {
                // Check ID
                if (lblId.Text.Equals(""))
                {
                    try
                    {
                        string sql = "INSERT into actions (devicename, command, action) VALUES (@name, @cmd, @action)";
                        cmd.Parameters.AddWithValue("@name", cbDevice.Text);
                        cmd.Parameters.AddWithValue("@cmd", cbModule.Text);
                        cmd.Parameters.AddWithValue("@action", cbAction.Text);
                        conn.Open();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added action successfully!", "Success");
                        refreshTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to add action! Exception: " + ex.ToString(), "Error");
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
                        string sql = "UPDATE actions SET devicename = @name, command = @cmd, action = @action WHERE aId = @id";
                        cmd.Parameters.AddWithValue("@name", cbDevice.Text);
                        cmd.Parameters.AddWithValue("@cmd", cbModule.Text);
                        cmd.Parameters.AddWithValue("@action", cbAction.Text);
                        cmd.Parameters.AddWithValue("@id", lblId.Text);
                        conn.Open();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Action edtied!", "Success");
                        refreshTable();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to edit action! Exception:" + ex.ToString(), "Error");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dgvModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow rowUpdate in dgvModules.SelectedRows)
            {
                lblId.Text = rowUpdate.Cells[0].Value.ToString();
                cbDevice.Text = rowUpdate.Cells[1].Value.ToString();
                cbModule.Text = rowUpdate.Cells[2].Value.ToString();
                cbAction.Text = rowUpdate.Cells[3].Value.ToString();
                btnApply.Text = "Update";
            }
        }

        public void refreshTable()
        {
            SQLiteConnection conn = new SQLiteConnection("data source=SmartHomeDB.db3");
            try
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM actions", conn);
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
                DialogResult result = MessageBox.Show("Are you sure you want to delete this action?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM actions WHERE aId = @id";
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
                MessageBox.Show("Unable to delete action! Exception:" + ex.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
