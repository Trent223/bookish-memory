using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6Practice.People
{
    public static class PersonExtensions
    {
        public static int GetAgeInDays(this Person person)
        {
            var age = DateTime.Today.TimeOfDay.Subtract(person.DateOfBirth.TimeOfDay);
            return age.Days;
        }

        public static int GetAgeInYears(this Person person)
            => DateTime.Today.Year - person.DateOfBirth.Year;

    }
}
