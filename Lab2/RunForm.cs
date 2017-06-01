using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class RunForm : Form
    {
        public RunForm()
        {
            InitializeComponent();
        }

        private void btn_std_Click(object sender, EventArgs e)
        {
            StudentForm stdForm = new StudentForm();
            stdForm.ShowDialog();
        }

        private void btn_bk_Click(object sender, EventArgs e)
        {
            BookForm bkForm = new BookForm();
            bkForm.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
