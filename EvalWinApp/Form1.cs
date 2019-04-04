using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvalWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvParticipants.DataSource = EvalWinApp.DAL.ParticipantDB.GetAllParticipants();
            dgvFormations.DataSource = EvalWinApp.DAL.FormationDB.GetAllFormations();
            dgvSessions.DataSource = EvalWinApp.DAL.SessionDB.getAllSessions();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddFormation frmAddForm = new FrmAddFormation();
            DialogResult dr = frmAddForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
               // MessageBox.Show("Has been reload");
                dgvParticipants.DataSource = EvalWinApp.DAL.ParticipantDB.GetAllParticipants();
                dgvFormations.DataSource = EvalWinApp.DAL.FormationDB.GetAllFormations();
                dgvSessions.DataSource = EvalWinApp.DAL.SessionDB.getAllSessions();
            }
            // this.Load += new System.EventHandler(this.Form1_Load);

        }
    }
}
