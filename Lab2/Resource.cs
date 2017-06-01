using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Resource
    {
        private string title;
        private string language;
        private string category;
        private bool status;
        private int qty;
        private int balance;


        public Resource()
        {
            title = "";
            language = "";
            category = "";
            status = false;
            qty = 0;
        }


        public Resource(string title, string language, string category, bool status, int qty)
        {
            this.title = title;
            this.language = language;
            this.category = category;
            this.status = status;
            this.qty = qty;
            balance = qty;
        }

        public string Title
        {
            set { title = value; }
            get { return title; }
        }

        public string Language
        {
            set { language = value; }
            get { return language; }
        }

        public string Category
        {
            set { category= value; }
            get { return category; }
        }

        public bool Status
        {
            get 
            {
                if (Balance > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public int Qty
        {
            set { qty = value; }
            get { return qty; }
        }

        public int Balance
        {
            get { return balance; }
        }

        public override string ToString()
        {
            return "Title: " + Title +  "\n Language: " + Language + "\n Category: " + Category + "\n Status: " + Status + "\n GTY: " + Qty;
        }
    }
}
