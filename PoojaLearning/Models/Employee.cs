using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoojaLearning.Models
{
    public class Employee
    {
        private string firstname;
        private string lastname;
        private string gender;
        private int age;
        private string race;
        private DateTime dateOfBirth;

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Race { get => race; set => race = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}