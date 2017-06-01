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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string title = "";
            string isbn = "";
            string lang = "";
            string cat = "";
            int qty = 0;
            Book book = new Book();


            try
            {
                title = title_field.Text;
                isbn = isbn_field.Text;
                lang = lang_field.Text;
                cat = cat_field.Text;
                qty = int.Parse(qty_field.Text);

                if(title != "" && isbn != "" && lang != "" && cat != "" && qty != 0){
                    book = new Book(title, isbn, lang, cat, false, qty);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException source: {0}", ex);  
            }


            MessageBox.Show(book.ToString());
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
