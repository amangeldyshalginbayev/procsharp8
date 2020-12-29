using System.Collections;

namespace SimpleIndexer
{
    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        public Person this[int index]
        {
            get => (Person) arPeople[index];
            set => arPeople.Insert(index, value);
        }

        // Cast for caller
        public Person GetPerson(int pos) => (Person) arPeople[pos];

        // Insert only Person objects
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }

        public void ClearPeople()
        {
            arPeople.Clear();
        }

        public int Count => arPeople.Count;


        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
}