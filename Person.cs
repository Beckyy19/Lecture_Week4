using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Week4
{
    internal class Person
    {
        string name;


        public Person (string name) //Default Constructor. 
        {

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("There is no name.");
            }
            else
            {
                this.name = name;
            }
        }

        public string Name
        {
            get { return name;  }
            set{ name = value;  }
        }

        public override string ToString()
        {
            return "The name is : "+Name;
        }
    }
}
