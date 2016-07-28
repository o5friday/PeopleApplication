namespace PeopleApplication
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() + LastName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person p = (Person)obj;
                return p.FirstName.Equals(this.FirstName) && p.LastName.Equals(this.LastName);
            }

            return false;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
