using System;
using System.Collections.Generic;

namespace FunWithGenericCollections
{
    public class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x is null || y is null)
            {
                throw new ArgumentNullException(x is null ? nameof(x) : nameof(y), "You can not pass null values as parameter");
            }
            if (x?.Age > y?.Age)
            {
                return 1;
            }

            if (x?.Age < y?.Age)
            {
                return -1;
            }

            return 0;
        }
    }
}