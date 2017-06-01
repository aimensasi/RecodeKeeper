using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
        private string strName;
        string strContact;

        //Constructor
        public Person()
        {
            strName = "Unkown";
            strContact = "***-***-**-***";
        }

        public Person(string strName, string strContact)
        {
            this.strName = strName;
            this.strContact = strContact;
        }

        public string Name
        {
            set { strName = value; }
            get { return strName; }
        }

        public string Contact
        {
            set { strContact = value; }
            get { return strContact; }
        }

        public override string ToString()
        {
            return  "Name: " + Name + "\nContact Info" + Contact ;
        }

    }
}
