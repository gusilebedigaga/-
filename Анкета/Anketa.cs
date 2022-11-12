using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Анкета
{
    internal class Anketa
    {

        public int id { get; set; }

        private string name, gender, city, age, ninja;

        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }
        public string Gender 
        { 
            get { return gender; } 
            set { gender = value; } 
        }
        public string City 
        { 
            get { return city; } 
            set { city = value; } 
        }
        public string Age 
        { 
            get { return age; } 
            set { age = value; } 
        }
        public string Ninja 
        { 
            get { return ninja; } 
            set { ninja = value; } 
        }

        public Anketa () { }

        public Anketa (string name, string gender, string city, string age, string ninja)
        {
            this.name = name;
            this.gender = gender;
            this.city = city;
            this.age = age;
            this.ninja = ninja;
        }

        public override string ToString()
        {
            return "Имя: " + Name + ". Пол: " + Gender + ". Город: " + City + ". Возраст: " + Age + ". Черепашка Нинздя: " + Ninja;
        }

    }

        
}
