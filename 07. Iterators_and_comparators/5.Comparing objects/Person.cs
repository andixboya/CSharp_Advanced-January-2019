﻿

namespace ComparinObjects
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Town { get; private set; }

        public int CompareTo(Person other)
        {

            int result = this.Name.CompareTo(other.Name);

            if (result==0)
            {
                result = this.Age - other.Age;
            }

            if (result==0)
            {
                result = this.Town.CompareTo(other.Town);
            }

            return result;
        }


        
        
    }
}
