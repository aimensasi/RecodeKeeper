using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Book : Resource
    {

        
        private string isbn;


        public Book() : base()
        {     
        }


        public Book(string title, string isbn, string language, string category, bool status, int qty) : base(title, language, category, status, qty)
        {  
            this.isbn = isbn;
        }

        public string Isbn
        {
            set { isbn = value; }
            get { return isbn; }
        }


        public override string ToString()
        {
            return "Title: " + Title + "\n ISBN: " + Isbn + "\n Language: " + Language + "\n Category: " + Category + "\n Status: " + Status + "\n GTY: " + Qty;
        }
    }
}
