using System;
using System.Collections.Generic;
using System.Text;

namespace Dex
{
    class Person
    {
        string FIO { get; set; }
        DateTime Birthday { get; set; }
        string BirthPlace { get; set; }
        int PassportId { get; set; }

        public Person(string fio, DateTime birthday, string birthPlace, int passportId)
        {
            FIO = fio;
            Birthday = birthday;
            BirthPlace = birthPlace;
            PassportId = passportId;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Person))
            {
                return false;
            }

            Person person = (Person)obj;
            return person.FIO == FIO &&
                person.Birthday == Birthday &&
                person.BirthPlace == BirthPlace &&
                person.PassportId == PassportId;
        }
        public override int GetHashCode()
        {
            int result = FIO.GetHashCode() + Birthday.GetHashCode() + BirthPlace.GetHashCode() + PassportId.GetHashCode();
            return result;
        }
    }
}
