using System;
using Zodiac.Exceptions;

namespace Zodiac.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Dates Birthday { get; set; }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (!value.Contains('@') && !value.Contains('.')) throw new InvalidEmailException();
                _email = value;
            }
        }
        

        public bool IsAdult => Birthday.Age >= 18;
        public string SunSign => Birthday.ZodiacW;
        public string ChineseSign => Birthday.ZodiacC;
        public bool IsBirthday => Birthday.isBirthday();


        public Person(string name, string surname, string email, Dates birthday)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Birthday = birthday;
        }

        public Person(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Birthday = default;
        }

        public Person(string name, string surname, Dates birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Email = default;
        }
    }
}
