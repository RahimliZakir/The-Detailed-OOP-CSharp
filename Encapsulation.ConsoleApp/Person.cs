namespace Encapsulation.ConsoleApp
{
    // This class encapsulates all 'fields', 'properties', 'variables' or '' methods.
    class Person
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;

        // Data Hiding:
        private int age;

        public int Age
        {
            get => age;

            set
            {
                if (value <= 18)
                    throw new Exception("Age cannot be less than 18!");
                else
                    age = value;
            }
        }
    }
}
