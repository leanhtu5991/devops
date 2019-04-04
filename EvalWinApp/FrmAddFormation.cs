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
    public partial class FrmAddFormation : Form
    {
        public FrmAddFormation()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lblStatus.Text = EvalWinApp.DAL.FormationDB.AddOneFormation(txtTitre.Text, txtDescription.Text, txtProgramme.Text);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();

            //this.Load += new System.EventHandler(this.Form1_Load);
        }
    }
}
