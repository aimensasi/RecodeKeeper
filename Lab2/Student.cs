using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student : Person
    {
        private string strId;
        string strIntake;

        //Constructor
      public Student() : base()
        {
            strId = "TP046525";
            strIntake = "Not Assigned";
        }

      public Student(string strId, string strName, string strContact, string strIntake) : base(strName, strContact)
      {
          this.strId = strId;
          this.strIntake = strIntake;
      }

        public string ID
        {
            set { strId = value; }
            get { return strId; }
        }

        public string Intake
        {
            set { strIntake = value; }
            get { return strIntake; }
        }

        public override string ToString()
        {
            return "/Student ID: " + ID + "/Student Name: " + Name + "/Contact Info" + Contact + "/Intake" + Intake; 
        }
       
    }
}
