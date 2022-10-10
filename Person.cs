namespace Breadth_first_search
{
    public class Person
    {
        private string _name;
        private string _job;

        public string Name => _name;
        public string Job => _job;

        public Person(string name, string job)
        {
            _name = name;
            _job = job;
        }
    }
}