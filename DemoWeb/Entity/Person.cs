using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Entity
{
    public class Person
    {
        String name;
        String note;

        public Person(String name, String note)
        {
            this.name = name;
            this.note = note;
        }

        public String Name
        {
            get { return name; }
        }

        public String Note
        {
            get { return note; }
        }
    }
}