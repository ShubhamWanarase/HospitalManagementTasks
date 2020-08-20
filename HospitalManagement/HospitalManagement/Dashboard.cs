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
    public partial class frmDashboard : Form
    {
        SqlConnection con = new SqlConnection("server = localhost; integrated security = true; database = HospitalManageMent; MultipleActiveResultSets = true;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Dr;
        int i = 0;
        
        public frmDashboard()
        {
            InitializeComponent();
            con.Open();
            FillAllAppointmentData();
            FillAllPatientsData();
            FillAllUpdatedPatientsData();
            FillAllTransactionData();
            FillAllAppointmentsInfoData();
            LoadSerialAppointments();
            LoadSerialPatients();
            LoadSerialUpdatedPatients();
            LoadSerialTransactions();
            LoadSerialAppointmentsInfo();
            progressBar1.Visible = false;
            lblLoading.Visible = false;                
        }

        // Task 1 Code 

        private void LoadSerialAppointments()
        {
             int i = 1;
             foreach (DataGridViewRow row in dataGridViewTask1.Rows)
             {
                row.Cells["clmnSrNo"].Value = i;
                i++; 
             }
        }
         
        public void FillAllAppointmentData()
        {
            try
            {
                dataGridViewTask1.Rows.Clear();
                cmd = new SqlCommand("select clinicinfo.clinicid, clinicinfo.clinicname, DATEPART(YEAR, apptdate) AS Year, DATEPART(MONTH, apptdate) AS Month, Count(appointmentinfo.apptid) as Appointments from appointmentinfo INNER JOIN clinicinfo ON clinicinfo.clinicid = appointmentinfo.clinicid group by DATEPART(YEAR, apptdate), DATEPART(MONTH, apptdate), clinicinfo.clinicid,clinicinfo.clinicname order by Year, Month ASC;", con);
                Dr = cmd.ExecuteReader();
                i = 0;
                while (Dr.Read())
                {
                    dataGridViewTask1.Rows.Add();
                    dataGridViewTask1.Rows[i].Cells[1].Value = Dr[0];
                    dataGridViewTask1.Rows[i].Cells[2].Value = Dr[1];
                    dataGridViewTask1.Rows[i].Cells[3].Value = Dr[2];
                    dataGridViewTask1.Rows[i].Cells[4].Value = Dr[3];
                    dataGridViewTask1.Rows[i].Cells[5].Value = Dr[4];
                    i++;
                }
                Dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Task 2 Code

        private void LoadSerialPatients()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridViewTask2.Rows)
            {
                row.Cells["clmnSrNo2"].Value = i;
                i++;
            }
        }

        public void FillAllPatientsData()
        {
            try
            {
                dataGridViewTask2.Rows.Clear();
                cmd = new SqlCommand("Select appointmentinfo.patid, appointmentinfo.apptdate, patientinfo.firstname, patientinfo.lastname, patientinfo.city, patientinfo.state, patientinfo.gender, patientinfo.patientagegroup, patientinfo.birthdate, DATEDIFF(hour,birthdate,GETDATE())/8766 AS Age  from appointmentinfo INNER JOIN patientinfo ON patientinfo.patid = appointmentinfo.patid WHERE appointmentinfo.patid not in(Select patid from appointmentinfo WHERE apptdate  between GetDate() AND '04/15/2021') ORDER BY appointmentinfo.apptdate DESC;", con);
                Dr = cmd.ExecuteReader();
                i = 0;
                while (Dr.Read())
                {
                    dataGridViewTask2.Rows.Add();
                    dataGridViewTask2.Rows[i].Cells[1].Value = Dr[0];
                    dataGridViewTask2.Rows[i].Cells[2].Value = Dr[1];
                    dataGridViewTask2.Rows[i].Cells[3].Value = Dr[2];
                    dataGridViewTask2.Rows[i].Cells[4].Value = Dr[3];
                    dataGridViewTask2.Rows[i].Cells[5].Value = Dr[4];
                    dataGridViewTask2.Rows[i].Cells[6].Value = Dr[5];
                    dataGridViewTask2.Rows[i].Cells[7].Value = Dr[6];
                    dataGridViewTask2.Rows[i].Cells[8].Value = Dr[7];
                    dataGridViewTask2.Rows[i].Cells[9].Value = Dr[8];
                    dataGridViewTask2.Rows[i].Cells[10].Value = Dr[9];

                    i++;
                }
                Dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Task 3 Code

        private void LoadSerialUpdatedPatients()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridViewTask3.Rows)
            {
                row.Cells["clmnSrNo3"].Value = i;
                i++;
            }
        }

        public void FillAllUpdatedPatientsData()
        {
            try
            {
                dataGridViewTask3.Rows.Clear();
                cmd = new SqlCommand("Select patid, lastname, firstname, city, state, gender, patientagegroup, birthdate, age from patientinfo;", con);
                Dr = cmd.ExecuteReader();
                i = 0;
                while (Dr.Read())
                {
                    dataGridViewTask3.Rows.Add();
                    dataGridViewTask3.Rows[i].Cells[1].Value = Dr[0];
                    dataGridViewTask3.Rows[i].Cells[2].Value = Dr[1];
                    dataGridViewTask3.Rows[i].Cells[3].Value = Dr[2];
                    dataGridViewTask3.Rows[i].Cells[4].Value = Dr[3];
                    dataGridViewTask3.Rows[i].Cells[5].Value = Dr[4];
                    dataGridViewTask3.Rows[i].Cells[6].Value = Dr[5];
                    dataGridViewTask3.Rows[i].Cells[7].Value = Dr[6];
                    dataGridViewTask3.Rows[i].Cells[8].Value = Dr[7];
                    dataGridViewTask3.Rows[i].Cells[9].Value = Dr[8];
                    
                    i++;
                }
                Dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            lblLoading.Visible = true;
            timer1.Enabled = true;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                dataGridViewTask3.Rows.Clear();
                cmd = new SqlCommand("SELECT patid, DATEDIFF(hour,birthdate,GETDATE())/8766 AS Age from patientinfo;", con);
                Dr = cmd.ExecuteReader();
                i = 0;
                while (Dr.Read())
                {
                    cmd = new SqlCommand("proUpdateAgeAndPatientAgeGroup", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter p1;

                    p1 = new SqlParameter("@optr", SqlDbType.BigInt);
                    p1.Value = 1;
                    cmd.Parameters.Add(p1);

                    p1 = new SqlParameter("@patid", SqlDbType.BigInt);
                    p1.Value = Dr[0];
                    cmd.Parameters.Add(p1);

                    p1 = new SqlParameter("@age", SqlDbType.BigInt);
                    p1.Value = Dr[1];
                    cmd.Parameters.Add(p1);

                    if (int.Parse(Dr[1].ToString()) < 18)
                    {
                        p1 = new SqlParameter("@patientagegroup", SqlDbType.NVarChar);
                        p1.Value = "Minor";
                        cmd.Parameters.Add(p1);
                    }
                    else
                    {
                        p1 = new SqlParameter("@patientagegroup", SqlDbType.NVarChar);
                        p1.Value = "Adult";
                        cmd.Parameters.Add(p1);
                    }
                    cmd.ExecuteNonQuery();
                }
                this.Cursor = Cursors.Default;
                Dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if (progressBar1.Value > 99)
            {
                timer1.Enabled = false;
                MessageBox.Show("Age And Patient Age Group Successfully Upadated...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                lblLoading.Visible = false;
                this.Close();
                frmDashboard ds = new frmDashboard();
                ds.Show();
                ds.tabControlMain.SelectTab(2);
            }
        }       

        // Task 4 Code

        private void LoadSerialTransactions()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridViewTask4.Rows)
            {
                row.Cells["clmnSrNo4"].Value = i;
                i++;
            }
        }

        public void FillAllTransactionData()
        {
            try
            {
                dataGridViewTask4.Rows.Clear();
                cmd = new SqlCommand("SELECT transactioninfo.proceduretype, clinicinfo.clinicname, doctorinfo.firstname+'  '+doctorinfo.lastname, DATEPART(YEAR,proceduredate) as Year, DATEPART(MONTH, proceduredate) as Month, SUM(transactioninfo.amount) AS Amount FROM transactioninfo INNER JOIN clinicinfo ON transactioninfo.clinicid = clinicinfo.clinicid INNER JOIN doctorinfo ON doctorinfo.prov = transactioninfo.prov GROUP BY proceduretype, doctorinfo.firstname, doctorinfo.lastname, DATEPART(YEAR, proceduredate), DATEPART(MONTH, proceduredate), clinicinfo.clinicname order by Year, Month desc;", con);
                Dr = cmd.ExecuteReader();
                i = 0;
                while (Dr.Read())
                {
                    dataGridViewTask4.Rows.Add();
                    dataGridViewTask4.Rows[i].Cells[1].Value = Dr[0];
                    dataGridViewTask4.Rows[i].Cells[2].Value = Dr[1];
                    dataGridViewTask4.Rows[i].Cells[3].Value = Dr[2];
                    dataGridViewTask4.Rows[i].Cells[4].Value = Dr[3];
                    dataGridViewTask4.Rows[i].Cells[5].Value = Dr[4];
                    dataGridViewTask4.Rows[i].Cells[6].Value = Dr[5];
                    i++;
                }
                Dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Task 5 Code

        private void LoadSerialAppointmentsInfo()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridViewTask5.Rows)
            {
                row.Cells["clmnSrNo5"].Value = i;
                i++;
            }
        }

        public void FillAllAppointmentsInfoData()
        {
            try
            {
                dataGridViewTask5.Rows.Clear();
                cmd = new SqlCommand("select appointmentinfo.patid, appointmentinfo.apptid, appointmentinfo.apptdate, appointmentinfo.operatory, doctorinfo.firstname+'  '+doctorinfo.lastname, appointmentinfo.appttime, appointmentinfo.apptlength, appointmentinfo.amount, clinicinfo.clinicname from appointmentinfo INNER JOIN clinicinfo ON clinicinfo.clinicid = appointmentinfo.clinicid INNER JOIN doctorinfo ON doctorinfo.prov = appointmentinfo.prov;", con);
                Dr = cmd.ExecuteReader();
                i = 0;
                while (Dr.Read())
                {
                    dataGridViewTask5.Rows.Add();
                    dataGridViewTask5.Rows[i].Cells[1].Value = Dr[0];
                    dataGridViewTask5.Rows[i].Cells[2].Value = Dr[1];
                    dataGridViewTask5.Rows[i].Cells[3].Value = Dr[2];
                    dataGridViewTask5.Rows[i].Cells[4].Value = Dr[3];
                    dataGridViewTask5.Rows[i].Cells[5].Value = Dr[4];
                    dataGridViewTask5.Rows[i].Cells[6].Value = Dr[5];
                    dataGridViewTask5.Rows[i].Cells[7].Value = Dr[6];
                    dataGridViewTask5.Rows[i].Cells[8].Value = Dr[7];
                    dataGridViewTask5.Rows[i].Cells[9].Value = Dr[8];
                    i++;
                }
                Dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFetchAmountLessThan50_Click(object sender, EventArgs e)
        {
            frmManageAppointments manangeappt = new frmManageAppointments();
            manangeappt.Show();
        }
        
    }
}
