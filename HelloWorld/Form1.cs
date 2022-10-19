using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            
            if (txtInput.TextLength <= 0)
            {
                MessageBox.Show("Error no Input", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                txtInput.SelectAll();
            }
            else {
                txtOutput.Visible = true;
                txtOutput.Text = "Hello " + txtInput.Text;
                txtInput.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
