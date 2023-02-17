using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForm_21
{
    internal class Person
    {
        private string txtName;
        private string txtSurName;
        private string txtFamilyName;
        private int txtEgn;
        private string Pol;
        private string txtWork;

        public string Name
        {
            get { return txtName; } 
            set { txtName = value; } 
        }

        public string Surname
        {
            get { return txtSurName; }
            set { txtSurName = value; }
        }

        public string Familyname
        {
            get { return txtFamilyName; }
            set { txtFamilyName = value; }
        }

        public int Egn
        {
            get { return txtEgn; }
            set { txtEgn = value;}
        }
        public int Poll
        {
            get { return Pol; }
            set { Pol = value; }
        }

        public string Work
        {
            get { return txtWork; }
            set { txtWork = value;}
        }


    }
}
