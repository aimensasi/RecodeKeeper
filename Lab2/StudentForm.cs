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

namespace Lab2
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string id = "";
            string name = "";
            string contact = "";
            string intake = "";
            Student student = new Student();
            
            try
            {
                id = stdId_field.Text;
                name = stdName_field.Text;
                contact = stdContact_field.Text;
                intake = stdIntake_field.Text;

                if (id != "" && name != "" && contact != "" && intake != "")
                {
                    student = new Student(id, name, contact, intake);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException source: {0}", ex);
            }


            MessageBox.Show(student.ToString());
        }

    }
}
