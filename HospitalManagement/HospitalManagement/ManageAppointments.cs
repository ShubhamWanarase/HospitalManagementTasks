using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class frmManageAppointments : Form
    {

        SqlConnection con = new SqlConnection("server = localhost; integrated security = true; database = HospitalManageMent");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Dr;
        int i = 0;

        public frmManageAppointments()
        {
            InitializeComponent();
            con.Open();
            FillAllAppointmentsInfoDeleteData();
            progressBar1.Visible = false;
            lblProgressBar.Visible = false;
        }

        private void LoadSerialAppointmentsInfoDelete()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridViewDeleteFunctionality.Rows)
            {
                row.Cells["clmnSrNoPanel"].Value = i;
                i++;
            }
        }

        public void FillAllAppointmentsInfoDeleteData()
        {
            try
            {
                dataGridViewDeleteFunctionality.Rows.Clear();
                cmd = new SqlCommand("select appointmentinfo.patid, appointmentinfo.apptid, appointmentinfo.apptdate, appointmentinfo.operatory, doctorinfo.firstname+'  '+doctorinfo.lastname, appointmentinfo.appttime, appointmentinfo.apptlength, appointmentinfo.amount, clinicinfo.clinicname from appointmentinfo INNER JOIN clinicinfo ON clinicinfo.clinicid = appointmentinfo.clinicid INNER JOIN doctorinfo ON doctorinfo.prov = appointmentinfo.prov WHERE amount < 50;", con);
                Dr = cmd.ExecuteReader();
                i = 0;
                while (Dr.Read())
                {
                    dataGridViewDeleteFunctionality.Rows.Add();
                    dataGridViewDeleteFunctionality.Rows[i].Cells[2].Value = Dr[0];
                    dataGridViewDeleteFunctionality.Rows[i].Cells[3].Value = Dr[1];
                    dataGridViewDeleteFunctionality.Rows[i].Cells[4].Value = Dr[2];
                    dataGridViewDeleteFunctionality.Rows[i].Cells[5].Value = Dr[3];
                    dataGridViewDeleteFunctionality.Rows[i].Cells[6].Value = Dr[4];
                    dataGridViewDeleteFunctionality.Rows[i].Cells[7].Value = Dr[5];
                    dataGridViewDeleteFunctionality.Rows[i].Cells[8].Value = Dr[6];
                    dataGridViewDeleteFunctionality.Rows[i].Cells[9].Value = Dr[7];
                    dataGridViewDeleteFunctionality.Rows[i].Cells[10].Value = Dr[8];
                    i++;
                }
                Dr.Close();
                LoadSerialAppointmentsInfoDelete();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
           List<DataGridViewRow> selectedRows = (from row in dataGridViewDeleteFunctionality.Rows.Cast<DataGridViewRow>()
                                            where Convert.ToBoolean(row.Cells["clmnSelect"].Value) == true
                                            select row).ToList();

           if (selectedRows.Count == 0)
           {
               MessageBox.Show("Please Select The Appointment To Delete...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
                if (MessageBox.Show(string.Format("Do you want to delete {0} rows?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lblSelectRequest.Visible = false;
                    lblProgressBar.Visible = true;
                    progressBar1.Visible = true;
                    timer1.Enabled = true;

                    foreach (DataGridViewRow row in selectedRows)
                    {
                        cmd = new SqlCommand("delete from appointmentinfo where apptid= @ApptID", con);
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@ApptID", row.Cells["clmnApptIDPanel"].Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if (progressBar1.Value > 99)
            {
                timer1.Enabled = false;
                MessageBox.Show("Appoinments Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
                lblProgressBar.Visible = false;
                progressBar1.Visible = false;
                lblSelectRequest.Visible = true;
                this.Close();
                frmManageAppointments manangeappt = new frmManageAppointments();
                manangeappt.Show();
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.Cursor = Cursors.WaitCursor;
                foreach (DataGridViewRow row in dataGridViewDeleteFunctionality.Rows)
                {
                    DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)row.Cells[0];
                    check.Value = true;
                }
                this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                foreach (DataGridViewRow row in dataGridViewDeleteFunctionality.Rows)
                {
                    DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)row.Cells[0];
                    check.Value = false;
                }
                this.Cursor = Cursors.Default;
            }
        }
    }
}
