using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stdWCF
{
    public class Student
    {
        public string name { get; set; }
        public string klasse { get; set; }
        public string rum { get; set; }

        public Student()
        {
        }

        public Student(string Name, string Klasse, string Rum)
        {
            name = Name;
            klasse = Klasse;
            rum = Rum;
        }
    }   
}