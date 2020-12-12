namespace ObjectOverrides
{
    public class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }

        public string SSN { get; } = "";

        public Person(string firstName, string lastName, int age, string ssn = "")
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Person temp))
            {
                return false;
            }

            if (temp.FirstName == this.FirstName
                && temp.LastName == this.LastName
                && temp.Age == this.Age)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode() => SSN.GetHashCode();
    }
}