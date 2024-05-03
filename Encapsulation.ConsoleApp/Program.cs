using Encapsulation.ConsoleApp;

// Encapsulation -> Data Hiding
Person person = new()
{
    Name = "Zakir",
    Surname = "Rahimli",
    // Get 'age' field, by 'Age' property
    Age = 21,
    // If I set 'Age' less or equal 18, it will throw Exception!
    //Age = 18,
};
// Set 'age' field, by 'Age' property
Console.WriteLine(person.Age);

Console.ReadKey();
