using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA2_CHAM_CONG.Forms
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMain openOtherForm = new formMain();
            this.Hide();
            openOtherForm.ShowDialog();
            this.Close();
        }
    }
}
