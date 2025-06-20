using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadUserControl(new ucPatientInfo());
        }

        private void LoadUserControl(UserControl uc)
        {
            panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucPatientInfo());
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            LoadUserControl(new usDoctorInfo());
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucStaffInfo());
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucRoomInfo());
        }

        private void buttonappointment_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucAppointmentInfo());
        }

        private void buttonConsultation_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucConsultationInfo());
        }

        private void buttonAdmission_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucAdmissionInfo());
        }

        private void buttonTreatmentPlan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucTreatmentPlan());
        }
    }
}
