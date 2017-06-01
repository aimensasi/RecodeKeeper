using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Record
    {

        private Student student;
        private Book book;
        private int qty;
        private string borrowDate;
        private string returnDate;
        private int renewCount;


        public Record()
        {
            student = new Student();
            book = new Book();
            qty = 0;
            borrowDate = "10_02_2017";
            returnDate = "10_02_2017";
            renewCount = 0;
        }

        public Record(Student std, Book bk, int qty, string borrowDate, string returnDate, int renewCount)
        {
            student = std;
            book = bk;
            this.qty = qty;
            this.borrowDate = borrowDate;
            this.returnDate = returnDate;
            this.renewCount = renewCount;
        }

        public Student Std
        {
            set 
            { 
                student = value; 
            }
            get
            {
                return student;
            }
        }

        public Book Bk
        {
            set
            {
                book = value;
            }
            get
            {
                return book;
            }
        }

        public int Qty
        {
            set
            {
                qty = value;
            }
            get
            {
                return qty;
            }
        }


        public string BorrowDate
        {
            set
            {
                borrowDate = value;
            }
            get
            {
                return borrowDate;
            }
        }

        public string ReturnDate
        {
            set
            {
                returnDate = value;
            }
            get
            {
                return returnDate;
            }
        }

        public int RenewCount
        {
            set
            {
                renewCount = value;
            }
            get
            {
                return renewCount;
            }
        }

        public override string ToString()
        {
            return "Student: " + student + "\nBook: " + book + "\nQuantity: " + qty + "\nBorrow Date: " + borrowDate + "\nReturn Date: " + returnDate + "\nRenew Count: " + renewCount; 
        }

    }
}
