using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not Match", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
            if(txtPassword.Text == "Password" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
            if(cmbSecurity.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a Security question", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSecurity.Focus();
            }
            if(txtSecurity.Text == "")
            {
                MessageBox.Show("Please answer the security question", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecurity.Focus();
            }


        }
    }
}
