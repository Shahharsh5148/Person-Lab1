using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private string favouriteColour;
        private int age;
        private bool isWorking;

        public int PersonID { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Favouritecolour { get => favouriteColour; set => favouriteColour = value; }
        public int Age { get => age; set => age = value; }
        public bool Isworking { get => isWorking; set => isWorking = value; }

        public Person(int id, string firstName, string lastName, string favouriteColour, int age, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Favouritecolour = favouriteColour;
            Age = age;
            Isworking = isWorking;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "PersonID:" + PersonID + "\n";
            formatted += "FirstName:" + firstName + "\n";
            formatted += "LastName:" + lastName + "\n";
            formatted += "Favouritecolour:" + favouriteColour + "\n";
            formatted += "Age:" + age + "\n";
            formatted += "Isworking:" + isWorking + "\n";
            return formatted;

        }
        public string DisplayPersonInfo()
        {
            string formatted = "";
            formatted += id + ":" + firstName + "" + lastName + "'s" + "favourite colour is" + favouriteColour;
            return formatted;

        }

        public string ChangeFavouriteColour()
        {
            string formatted = "";
            formatted += id + ":" + firstName + "" + lastName + "'s" + "favourite colour is:white";
            return formatted;
        }
        public string GetAgeInTenYears()
        {
            string formatted = "";
            age = age + 10;

            formatted += firstName + "" + lastName + "'s Age in 10 years is:" + age;
            age = age - 10;

            return formatted;
        }

    }
}

