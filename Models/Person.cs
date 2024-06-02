using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Models
{
  public class Person
  {
    string Name { get; set; }
    int Age {get; set; }
    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }
    //out -> out parameter
    //makes the oposite operation of the constructor
    // gets the propertys values and assigns to the variables name and age
    public void Deconstruct(out string name, out int age)
    {
      name = Name;
      age = Age;
    }
    public void PresentPerson()
    {
      Console.WriteLine(this.Name + this.Age);
    }
  }
}